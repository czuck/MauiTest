﻿using Microsoft.Extensions.Logging;

namespace CleanApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureMauiHandlers(handlers =>
                {
                })
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiMaps();
#if IOS
                builder.ConfigureMauiHandlers((handlers) =>
                {
                    handlers.AddHandler<Microsoft.Maui.Controls.Maps.Map, CleanApp.Platforms.iOS.Handlers.CustomMapHandler>();
                });
#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
