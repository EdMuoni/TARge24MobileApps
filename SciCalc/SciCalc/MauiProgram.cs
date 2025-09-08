using Microsoft.Extensions.Logging;

namespace SciCalc
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
                    fonts.AddFont("Cair-Light.ttf", "RegularFont");
                    fonts.AddFont("Cair-ExtraLight.ttf", "LightFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
