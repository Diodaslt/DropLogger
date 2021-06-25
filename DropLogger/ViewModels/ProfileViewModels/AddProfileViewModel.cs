using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace DropLogger
{
    public class AddProfileViewModel : ProfileModel
    {
        public ICommand GoBackCommand { get; set; }
        public ICommand SaveProfileCommand { get; set; }
        public ObservableCollection<ProfileModel> ComboList { get; set; }
        public ProfileModel SelectedItem { get; set; }

        private object _CurrentView;
        public object CurrentView 
        {
            get { return _CurrentView; }
            set
            {
                _CurrentView = value;
                OnPropertyChanged("CurrentView");
            }
        }
        public AddProfileViewModel()
        {
            ComboList = new ObservableCollection<ProfileModel>
            {
                new ProfileModel { type = "Araxii" }
            };

            GoBackCommand = new RelayCommand(() => GoBackToProfile());
            SaveProfileCommand = new RelayCommand(() => SaveProfile());
        }

        /// <summary>
        /// Check if the name is entered before pressing "Enter"
        /// </summary>
        private void SaveProfile()
        {
            // Skip if the name or log hasn't been selected
            if (String.IsNullOrEmpty(logname))
                return;

            if (SelectedItem == null)
                return;

            WriteLineDebug.Write(logname);
            WriteLineDebug.Write(SelectedItem.type);

            //Add a new item to the list
            ProfileViewModel.ProfileList.Add(
                new ProfileModel
                {
                    id = ProfileViewModel.ProfileList.Count,
                    killCount = 5,
                    logname = this.logname,
                    tripValue = 16,
                    type = SelectedItem.type
                }
            );

            CurrentView = new ProfileViewModel();
        }

        private void GoBackToProfile()
        {
            CurrentView = new ProfileViewModel();
        }
    }
}
