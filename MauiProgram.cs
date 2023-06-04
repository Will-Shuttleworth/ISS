using Microsoft.Extensions.Logging;
using ISS.Services;
using ISS.ViewModel;

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
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddSingleton<SpaceStationService>();
		builder.Services.AddSingleton<CrewService>();

		builder.Services.AddSingleton<ISSViewModel>();
		return builder.Build();
	}
}
