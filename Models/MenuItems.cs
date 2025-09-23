using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace CleanApp.Models
{
    public class MenuItem
    {
        public string DisplayName { get; set; }
        public string PageName { get; set; }
    }

    public class MenuItemsViewModel : INotifyPropertyChanged
    {
        private MenuItem _selectedMenuItem;

        public ObservableCollection<MenuItem> MenuItems { get; private set; }

        public MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set => _selectedMenuItem = value;
        }

        public MenuItemsViewModel()
        {
            IEnumerable<MenuItem> source = GetMenuItems().ToList();
            MenuItems = new ObservableCollection<MenuItem>(source);
            SelectedMenuItem = source.First();
            OnPropertyChanged(nameof(SelectedMenuItem));

        }

        private IEnumerable<MenuItem> GetMenuItems()
        {
            var menuItems = new List<MenuItem>
            {
                new() {
                        DisplayName = "Main Page",
                        PageName = "Main"
                    },
                new() {
                        DisplayName = "Title Disappearing Issue #21645",
                        PageName = "TitleIssue"
                    },
                new() {
                        DisplayName = "Announcement Page #21646",
                        PageName = "Announcement"
                    },
                new() {
                        DisplayName = "Grid Tap Gesture #21740",
                        PageName = "GridTap"
                    },
                new() {
                        DisplayName = "Display Prompt Async #25585",
                        PageName = "DisplayPrompt"
                    },
                new() {
                        DisplayName = "WebView Cancel #29575",
                        PageName = "WebView"
                    },
                new() {
                    DisplayName = "Map Tap",
                    PageName = "MapTap"
                },
                new() {
                    DisplayName = "Carousel #29913",
                    PageName = "Carousel"
                },
                new() {
                    DisplayName = "Image Aspect in Grid",
                    PageName = "ImageAspect"
                },
            };
            return menuItems;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
