using CleanApp.Pages;

namespace CleanApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Startup());
            //return new Window(new MainFlyoutPage());
        }

        public void ShowMainPage()
        {
            Windows[0].Page = new MainFlyoutPage();
        }
    }
}
