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
    public class ProfileViewModel : ProfileModel
    {
        /// <summary>
        /// Static singleton
        /// </summary>
        public static ObservableCollection<ProfileModel> ProfileList { get; set; }
        public static ProfileViewModel Profile = new ProfileViewModel();
        public static int CurrentlySelectedProfile { get; set; }
        private string _selectedprofilename;
        public string selectedprofilename
        {
            get { return _selectedprofilename; }
            set
            {
                _selectedprofilename = value;
                OnPropertyChanged("selectedprofilename");
            }
        }
        public ICommand AddProfileCommand { get; set; }
        public ICommand RemoveProfileCommand { get; set; }
        public ICommand RemoveItemCommand { get; set; }
        public ICommand SelectProfileCommand { get; set; }
        /// <summary>
        /// Command for adding an item to the display list
        /// </summary>
        public ICommand AddItemCommand { get; set; }
        /// <summary>
        /// Property that adjusts the scroll bar to the bottom
        /// each time a new item is added
        /// </summary>
        private bool _ScrollBarAdjustment;
        public bool ScrollBarAdjustment
        {
            get { return _ScrollBarAdjustment; }
            set
            {
                _ScrollBarAdjustment = value;
                OnPropertyChanged("ScrollBarAdjustment");
            }
        }
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

        public ProfileViewModel()
        {
            //If list hasn't been initialized, initialize it
            //Need this or else the list will be restarted
            if(ProfileList == null)
                ProfileList = new ObservableCollection<ProfileModel>();

            //Reset the scrollbar
            ScrollBarAdjustment = true;

            RemoveItemCommand = new RelayCommand((par) => RemoveDrop(par));
            RemoveProfileCommand = new RelayCommand(par => RemoveProfile(par));
            AddProfileCommand = new RelayCommand(() => AddProfile());
            SelectProfileCommand = new RelayCommand((par) => SelectProfile(par));
            AddItemCommand = new RelayCommand((par) => LogViewModel.Instance.AddItem(par));
        }

        /// <summary>
        /// Select a profile
        /// </summary>
        /// <param name="par">Index of the profile</param>
        private void SelectProfile(object par)
        {
            int index = (int)par;
            CurrentlySelectedProfile = index;

            //Select the profile name display at the top right corner
            selectedprofilename = ProfileList[index].logname;

            //Clear the previous profile
            LogViewModel.DropList.Clear();
            LogViewModel.ItemDisplayList.Clear();

            //Recreate the selected list
            foreach(var item in ProfileList[CurrentlySelectedProfile].DropList)
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
            LootValue.Instance.formattedValue = ProfileList[CurrentlySelectedProfile].tripValue;
            LootValue.Instance.CompleteValue = ProfileList[CurrentlySelectedProfile].rawTripValue;
            
            //Change the profile to the selected one
            LogViewModel.ItemDisplayList = new ObservableCollection<ItemModel>(ProfileList[CurrentlySelectedProfile].ItemDisplayList);
        }

        /// <summary>
        /// Add an item to the list
        /// </summary>
        public void CreateDropList(ObservableCollection<ItemModel> itn, ObservableCollection<ItemModel> display, int index)
        {
            //Reset scroll bar
            ScrollBarAdjustment = true;

            WriteLineDebug.Write("Adding " + itn[itn.Count - 1].itemName + " To Profile number " + CurrentlySelectedProfile + "\n");

            ProfileList[CurrentlySelectedProfile].DropList.Add(new ItemModel
            {
                id = ProfileList[CurrentlySelectedProfile].DropList.Count,
                itemName = itn[itn.Count-1].itemName,
                imgSrc = itn[itn.Count - 1].imgSrc,
                itemValue = itn[itn.Count - 1].itemValue,
                multiId = itn[itn.Count - 1].multiId,
                uniqueId = itn[itn.Count - 1].uniqueId,
                itemQuantity = itn[itn.Count - 1].itemQuantity,
            });

            ProfileList[CurrentlySelectedProfile].ItemDisplayList = new ObservableCollection<ItemModel>(display);
            ProfileList[CurrentlySelectedProfile].tripValue = LootValue.Instance.formattedValue;
            ProfileList[CurrentlySelectedProfile].rawTripValue = LootValue.Instance.CompleteValue;
            ProfileList[CurrentlySelectedProfile].killCount = ProfileList[CurrentlySelectedProfile].DropList.Count;

            //Reset scroll bar
            ScrollBarAdjustment = false;

            //Export the profile to a json file
            JSONDriver.WriteJson(ProfileList);
        }

        private void ProfileView()
        {
            CurrentView = new ProfileViewModel();
        }

        private void ChangeView()
        {
            CurrentView = new LogViewModel();
        }

        private void AddProfile()
        {
            CurrentView = new AddProfileViewModel();
        }
        private void RemoveDrop(object obj)
        {
            int index = (int)obj;

            //Place holder for the item quantity and value
            var itemPlaceholder = ProfileList[CurrentlySelectedProfile].DropList[index];

            WriteLineDebug.Write("Removed the item from  " + CurrentlySelectedProfile + " Profile\n");

            //Re-adjust the multi id of the item
            LogViewModel.ItemDisplayList[ProfileList[CurrentlySelectedProfile].DropList[index].uniqueId].multiId--;

            //Remove the item value
            LootValue.Instance.RemoveValue(itemPlaceholder.itemQuantity, itemPlaceholder.itemValue);

            //Remove the loot value from the profile
            ProfileList[CurrentlySelectedProfile].tripValue = LootValue.Instance.formattedValue;
            ProfileList[CurrentlySelectedProfile].rawTripValue = LootValue.Instance.CompleteValue;

            //Remove item from the list
            LogViewModel.DropList.RemoveAt(index);
            ProfileList[CurrentlySelectedProfile].DropList.RemoveAt(index);

            //Deduce the count of the profilelist.killcount
            ProfileList[CurrentlySelectedProfile].killCount--;

            //Restruct the list
            RestructInnerList(index, LogViewModel.DropList);
            RestructInnerList(index, ProfileList[CurrentlySelectedProfile].DropList);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();
            JSONDriver.WriteJson(ProfileList);
        }

        private void RemoveProfile(object obj)
        {
            //Gets the index of the selected item
            int index = (int)obj;

            //Remove the selected item
            ProfileList.RemoveAt(index);

            //Clear all the records of the drop view
            LogViewModel.ItemDisplayList.Clear();
            LogViewModel.DropList.Clear();

            //Fix the index after the item has been removed
            this.RestructList(index, ProfileList);

            //Check if the drop log is empty in the profile that was removed
            ListProperties.Instance.CheckDropList();

            //Write the change to the json file
            JSONDriver.WriteJson(ProfileList);
        }

        /// <summary>
        /// Index fix for the profile list
        /// </summary>
        /// <param name="index">Index of the selected item</param>
        /// <param name="clist">Adjustable list</param>
        public void RestructList(int index, ObservableCollection<ProfileModel> clist)
        {
            for (int i = index; i <= clist.Count-1; i++)
                clist[i].id--;
        }

        /// <summary>
        /// Fix the index for the drop list in the profile list
        /// </summary>
        /// <param name="index">Index of the selected item</param>
        /// <param name="clist">Adjustable list</param>
        public void RestructInnerList(int index, ObservableCollection<ItemModel> clist)
        {
            for (int i = index; i <= clist.Count - 1; i++)
            {
                clist[i].id--;
            }
        }
    }
}
