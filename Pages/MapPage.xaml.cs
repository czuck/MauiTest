namespace CleanApp.Pages;

public partial class MapPage : ContentPage
{
	public MapPage()
	{
		InitializeComponent();
	}

    private void BackButton_OnPressed(object sender, EventArgs e)
    {
        if (Parent is NavigationPage navPage)
        {
            var mapPage = new MapPage();
            navPage.PopToRootAsync();
        }
        else
        {
            DisplayAlert("Error", "Navigation page not found.", "OK");
        }
    }
}