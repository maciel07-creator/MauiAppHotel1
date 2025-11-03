using Microsoft.Extensions.Logging;

namespace MauiAppHotel1
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
                    fonts.AddFont("Satisfy-Regular.ttf", "SatisfyRegular");
                    fonts.AddFont("LobsterTwo-Bold.ttf", "LobsterTwoBold");
                    fonts.AddFont("LobsterTwo-BoldItalic.ttf", "LobsterTwoBoldItalic");
                    fonts.AddFont("LobsterTwo-Italic.ttf", "LobsterTwoItalic");
                    fonts.AddFont("LobsterTwo-Regular.ttf", "LobsterTwoRegular");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
