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
        public WindowViewModel(Window window)
        {
            //Default view
            CurrentView = new LogViewModel();

            LogViewCommand = new RelayCommand(() => ChangeView());
            ProfileViewCommand = new RelayCommand(() => ProfileView());
            ExtraViewCommand = new RelayCommand(() => ExtraView());

            CloseWindowCommand = new RelayCommand(() => window.Close());
            MinimizeWindowCommand = new RelayCommand(() => window.WindowState = WindowState.Minimized);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();
        }

        private void ExtraView()
        {
            CurrentView = new ExtraViewModel();
        }

        private void ProfileView()
        {
            CurrentView = new ProfileViewModel();
        }

        private void ChangeView()
        {
            //Disable the system message which says that the profile is empty
            ListProperties.Instance.isProfileListEmpty = false;

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();

            CurrentView = new LogViewModel();
        }
    }
}
