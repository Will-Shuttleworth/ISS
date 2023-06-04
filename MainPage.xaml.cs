using ISS.ViewModel;

namespace ISS;

public partial class MainPage : ContentPage
{
	public MainPage(ISSViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}

}

