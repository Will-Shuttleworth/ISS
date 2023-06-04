using ISS.Services;

namespace ISS.ViewModel;

public partial class ISSViewModel : BaseViewModel
{
    private readonly SpaceStationService _spaceStationService;
    private readonly CrewService _crewService;

    public ObservableCollection<Crew> Crew { get; } = new();
    public ObservableCollection<SpaceStation> SpaceStationLocations { get; } = new();

    private readonly IConnectivity _connectivity;
    private readonly IGeolocation _geolocation;

    public ISSViewModel(SpaceStationService spaceStationService, CrewService crewService, IConnectivity connectivity)
    {
        Title = "Space Station Locator";
        this._spaceStationService = spaceStationService;
        this._crewService = crewService;
        this._connectivity = connectivity;
    }

    [ObservableProperty]
    private Crew? _issCrew;

    [RelayCommand]
    async Task GetSpaceStationLocationAsync()
    {
        if (IsBusy)
            return;

        try
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Internet issue",
                $"Check your internet connection and try again!", "OK");
                return;
            }

            IsBusy = true;
            var spaceStationLocations = await _spaceStationService.GetSpaceStationLocation();

            if(SpaceStationLocations.Count != 0) 
                SpaceStationLocations.Clear();

            foreach(var spaceStationLocation in SpaceStationLocations)
                SpaceStationLocations.Add(spaceStationLocation);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to get space station location: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }

    [RelayCommand]
    async Task GetCrewAsync()
    {
        if (IsBusy)
            return;

        try
        {
            if (_connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Internet issue",
                $"Check your internet connection and try again!", "OK");
                return;
            }

            IsBusy = true;
            var crew = await _crewService.GetCrew();

            if (Crew.Count != 0)
                Crew.Clear();

            foreach (var crewMember in Crew)
                Crew.Add(crewMember);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to get space station location: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}

