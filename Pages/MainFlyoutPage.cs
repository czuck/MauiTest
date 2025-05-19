using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace CleanApp.Pages
{
    public class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            Flyout = new MenuPage();
            Detail = new NavigationPage(new AnnouncementPage());

        }
        public MainFlyoutPage(string s)
        {
            //Flyout = new MenuPage();
            //Detail = new NavigationPage(new AnnouncementPage());
            Flyout = new ContentPage()
            {
                Title = "Menu Page"
            };
            Detail = new ContentPage();

        }
    }
}