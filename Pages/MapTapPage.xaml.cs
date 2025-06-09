namespace CleanApp.Pages;

public partial class MapTapPage : ContentPage
{
	public MapTapPage()
	{
		InitializeComponent();
	}

    private void LoadMap_OnPressed(object sender, EventArgs e)
    {
        if (Parent is NavigationPage navPage)
        {
            var mapPage = new MapPage();
            navPage.PushAsync(mapPage);
        }
        else
        {
            DisplayAlert("Error", "Navigation page not found.", "OK");
        }
    }
}