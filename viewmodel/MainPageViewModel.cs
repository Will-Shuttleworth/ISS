using ISS.Model;
using ISS.Services.CrewService;
using ISS.ViewModel;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISS.ViewModel.MainPageViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    CrewService _crewService;

    [ObservableProperty]
    CrewMemberRoot crewMembers = new CrewMemberRoot();

    public MainPageViewModel() { }

    public MainPageViewModel(CrewService crewService)
    {
        Title = "MainPage";
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
            CrewMembers = await _crewService.GetCrewMembers();


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

