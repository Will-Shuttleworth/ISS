using ISS.View;
using ISS.ViewModel.MainPageViewModel;

namespace ISS;

public partial class MainPage : ContentPageBase
{
	public MainPage(MainPageViewModel mainPageViewModel)
	{
        BindingContext = mainPageViewModel;
        InitializeComponent();
	}

}

