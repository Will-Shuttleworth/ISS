using ISS.ViewModel.CrewViewModel;

namespace ISS;

public partial class MainPage : ContentPage
{
	public MainPage(CrewViewModel crewViewModel)
	{
		InitializeComponent();
		BindingContext = crewViewModel;
	}

}

