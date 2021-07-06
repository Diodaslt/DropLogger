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

            LogViewCommand = new RelayCommand(() => LogView());
            ProfileViewCommand = new RelayCommand(() => ProfileView());
            ExtraViewCommand = new RelayCommand(() => ExtraView());

            CloseWindowCommand = new RelayCommand(() => window.Close());
            MinimizeWindowCommand = new RelayCommand(() => window.WindowState = WindowState.Minimized);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();

            //Read data from the save file
            JSONDriver.ReadJson();

            LogView();
            //Write data to json when closing the window
            //This should prompt once the app is started 
            //and before it's closed
            JSONDriver.WriteJson(ProfileViewModel.ProfileList);

            //Initial load up
            //Profile view model load prior this
            if(ProfileViewModel.ProfileList.Count != 0)
            {
                //Recreate the selected list
                foreach (var item in ProfileViewModel.ProfileList[0].DropList)
                {
                    LogViewModel.DropList.Add(new ItemModel
                    {
                        id = item.id,
                        itemName = item.itemName,
                        itemValue = item.itemValue,
                        multiId = item.multiId,
                        totalValue = item.totalValue,
                        itemQuantity = item.itemQuantity,
                        uniqueId = item.uniqueId
                    });
                }

                //Change the total value of the trip
                LootValue.Instance.formattedValue = ProfileViewModel.ProfileList[0].tripValue;
                LootValue.Instance.CompleteValue = ProfileViewModel.ProfileList[0].rawTripValue;

                //Change the profile to the selected one
                LogViewModel.ItemDisplayList = new ObservableCollection<ItemModel>(ProfileViewModel.ProfileList[0].ItemDisplayList);
            }
        }

        private void ExtraView()
        {
            CurrentView = new ExtraViewModel();
        }

        private void ProfileView()
        {
            CurrentView = new ProfileViewModel();
        }

        private void LogView()
        {
            //Disable the system message which says that the profile is empty
            ListProperties.Instance.isProfileListEmpty = false;

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();

            CurrentView = new LogViewModel();
        }
    }
}
