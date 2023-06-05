using ISS.Model;
using ISS.Services.CrewService;

namespace ISS.ViewModel.CrewViewModel;

public partial class MainPageViewmodel : BaseViewModel
{
    readonly CrewService _crewService;

    public ObservableCollection<CrewMemberRoot> CrewMembers { get; } = new();

    public MainPageViewmodel(CrewService crewService)
    {
        Title = "ISS Locator";
        this._crewService = crewService;
    }

    [RelayCommand]
    async Task GetCrewMembersAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var _crewMembers = await _crewService.GetCrewMembers();

            if (CrewMembers.Count != 0)
                CrewMembers.Clear();

            foreach(var _crewMember in _crewMembers)
                CrewMembers.Add(_crewMember);
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex);
            await Shell.Current.DisplayAlert("Error!",
                $"Unable to get crew members: {ex.Message}", "OK");
        }
        finally
        {
            IsBusy = false;
        }
    }
}

