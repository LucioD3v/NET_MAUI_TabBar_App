using Microsoft.Extensions.Logging;
using StarWars_TabBar.Services;
using StarWars_TabBar.Views;

namespace StarWars_TabBar
{
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

            // Register the IStarWarsService implementation
            builder.Services.AddSingleton<IStarWarsService, StarWarsService>();

            // Register the PlanetPage
            builder.Services.AddTransient<PlanetPage>();
            builder.Services.AddTransient<StarShipPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
