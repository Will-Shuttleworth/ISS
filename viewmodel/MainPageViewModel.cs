using ISS.Model;
using ISS.Services.CrewService;
using CuttingEdge.Conditions;
using ISS.ViewModel;
using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Condition = CuttingEdge.Conditions.Condition;

namespace ISS.ViewModel.MainPageViewModel;

public partial class MainPageViewModel : BaseViewModel
{
    private readonly ICrewService _crewService;
    private readonly List<CrewMember> _membersStubData = new List<CrewMember>() 
    { 
        new CrewMember()
        {
            Name = "Bob",
            Craft = "mynecraft"
        },
        new CrewMember()
        {
            Name = "Phil",
            Craft = "mynecraft"
        },
    };

    public ObservableCollection<CrewMember> CrewMembers { get; } = new ObservableCollection<CrewMember>();

    public MainPageViewModel(ICrewService crewService)
    {
        Condition.Requires(crewService, nameof(crewService)).IsNotNull();
        Title = "MainPage";
        this._crewService = crewService;
        AddItems(_membersStubData);
    }

    public Task AddItems(List<CrewMember> crewMembers)
    {
        int index = 0;
        foreach(var member in crewMembers)
        {
            CrewMembers.Insert(index, member);
            index++;
        }
        
        return Task.CompletedTask;
    }

    [RelayCommand]
    async Task GetCrewMembersAsync()
    {
        if (IsBusy)
            return;

        try
        {
            IsBusy = true;
            var CrewMembersData = await _crewService.GetCrewMembers();
            await AddItems(CrewMembersData);
            

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

