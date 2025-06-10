using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Maps.Handlers;
using Microsoft.Maui.Maps.Platform;

namespace CleanApp.Platforms.iOS.Handlers
{
    public class CustomMapHandler : MapHandler
    {
        protected override void DisconnectHandler(MauiMKMapView platformView)
        {
            //base.DisconnectHandler(platformView);
        }
    }
}
