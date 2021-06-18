using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DropLogger
{
    public class WindowViewModel : WindowModel
    {
        public ObservableCollection<MenuItemDetails> MenuItems { get; set; }
        public WindowViewModel(Window window)
        {
            MenuItems = new ObservableCollection<MenuItemDetails>();

            //Create menu items
            MenuItems.Add(new LogViewModel());
            MenuItems.Add(new ProfileViewModel());
            MenuItems.Add(new ExtraViewModel());

            CloseWindowCommand = new RelayCommand(() => window.Close());
            MinimizeWindowCommand = new RelayCommand(() => window.WindowState = WindowState.Minimized);
            OpenLogCommand = new RelayCommand(() => OpenLog());
        }
        private void OpenLog()
        {

        }
    }
}
