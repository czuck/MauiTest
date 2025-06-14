using CleanApp.Models;
using MenuItem = CleanApp.Models.MenuItem;

namespace CleanApp.Pages;

public partial class MenuPage : ContentPage
{
    public MenuItemsViewModel MenuItemsViewModel;
    public MenuPage()
	{
		InitializeComponent();
        MenuItemsViewModel = new MenuItemsViewModel();
        MenuListView.ItemsSource = MenuItemsViewModel.MenuItems;
    }

    private void MenuListView_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Page nextPage;
        switch (((MenuItem)e.SelectedItem).PageName)
        {
            case "Announcement":
                nextPage = new AnnouncementPage();
                break;
            case "TitleIssue":
                nextPage = new TitleIssuePage();
                break;
            case "GridTap":
                nextPage = new GridTapPage();
                break;
            case "DisplayPrompt":
                nextPage = new DisplayPromptPage();
                break;
            case "WebView":
                nextPage = new WebViewPage();
                break;
            case "MapTap":
                nextPage = new MapTapPage();
                break;
            case "Carousel":
                nextPage = new CarouselPage();
                break;
            default:
                nextPage = new MainPage();
                break;
        }

        var flyoutPage = (FlyoutPage)Parent;
        flyoutPage.Detail = new NavigationPage(nextPage);
        flyoutPage.IsPresented = false;
    }
}