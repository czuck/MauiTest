namespace CleanApp.Pages;

public partial class ImageAspect : ContentPage
{
	public ImageAspect()
	{
		InitializeComponent();
        BannerImage1.Source = new UriImageSource
        {
            Uri = new Uri("https://jmo.jenzabar.net/welcome.png"),
        };
        BannerImage2.Source = "welcome.png";
    }
}