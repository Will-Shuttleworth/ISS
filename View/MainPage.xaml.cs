using ISS.ViewModel.CrewViewModel;

namespace ISS;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewmodel crewViewModel)
	{
		InitializeComponent();
		BindingContext = crewViewModel;
	}

}

