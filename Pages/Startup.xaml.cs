
namespace CleanApp.Pages;

public partial class Startup : ContentPage
{
    public Startup()
    {
        InitializeComponent();

        _ = LoadContent();
    }

    public async Task LoadContent()
    {
        await Task.Factory.StartNew(() =>
        {
            Thread.Sleep(5000);
        }); 
        MainThread.BeginInvokeOnMainThread(() =>
        {
            GetApp(Parent).ShowMainPage();
        });
    }
    public static App GetApp(Element parent)
    {
        while (parent is not App && parent is not null)
        {
            parent = parent.Parent;
        }
        return (App)parent;
    }
}