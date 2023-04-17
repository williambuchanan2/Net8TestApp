using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Net8TestApp.ViewModels;
using Net8TestApp.Views;

namespace Net8TestApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            RegisterViews(builder);
            return builder.Build();
        }



        public static void RegisterViews(MauiAppBuilder builder)
        {


            builder.Services.AddTransient<KeyboardIssueVm>();
            builder.Services.AddTransient<KeyboardIssue>();
            Routing.RegisterRoute(nameof(KeyboardIssue), typeof(KeyboardIssue));
        }

    }
}