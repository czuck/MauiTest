namespace CleanApp.Pages;

public partial class WebViewPage : ContentPage
{
	public WebViewPage()
	{
		InitializeComponent();
		WebView.Source = "https://www.google.com";
    }
}