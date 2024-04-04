﻿using System.Collections;
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
        private readonly IEnumerable<MenuItem> source;
        private MenuItem selectedMenuItem;

        public ObservableCollection<MenuItem> MenuItems { get; private set; }

        public MenuItem SelectedMenuItem
        {
            get => selectedMenuItem;
            set => selectedMenuItem = value;
        }

        public MenuItemsViewModel()
        {

            source = GetMenuItems().ToList();
            MenuItems = new ObservableCollection<MenuItem>(source);
            SelectedMenuItem = source.First();
            OnPropertyChanged(nameof(SelectedMenuItem));

        }

        public IEnumerable<MenuItem> GetMenuItems()
        {
            var source = new List<MenuItem>
            {
                new
                    MenuItem
                    {
                        DisplayName = "Main Page",
                        PageName = "Main"
                    },
                new
                    MenuItem
                    {
                        DisplayName = "Title Disappearing Issue",
                        PageName = "TitleIssue"
                    },
                new
                    MenuItem
                    {
                        DisplayName = "Announcement Page",
                        PageName = "Announcement"
                    },
            };
            return source;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
