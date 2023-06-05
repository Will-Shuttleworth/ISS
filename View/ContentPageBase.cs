using ISS.ViewModel;

namespace ISS.View;

public class ContentPageBase : ContentPage
{
	public ContentPageBase()
	{
		
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		
		if(BindingContext is BaseViewModel ivmb && !ivmb.IsInitialized) 
		{
			ivmb.IsInitialized = true;
			await ivmb.InitializeAsync();
		}
	}
}