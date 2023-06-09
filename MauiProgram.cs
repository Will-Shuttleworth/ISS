using CommunityToolkit.Maui;
using ISS.Services.CrewService;
using ISS.ViewModel.MainPageViewModel;
using Microsoft.Extensions.Logging;

namespace ISS;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			}).UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		//builder.Services.AddSingleton<SpaceStationService>();
		builder.Services.AddSingleton<ICrewService, CrewService>();

		builder.Services.AddSingleton<MainPageViewModel>();
        builder.Services.AddSingleton<MainPage>();
        return builder.Build();
	}
}
