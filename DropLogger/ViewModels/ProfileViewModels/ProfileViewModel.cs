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
        public ICommand AddProfileCommand { get; set; }
        public ICommand RemoveProfileCommand { get; set; }
        public ICommand RemoveItemCommand { get; set; }
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

            //Set to 0 for testing
            CurrentlySelectedProfile = 0;

            //Reset the scrollbar
            ScrollBarAdjustment = true;

            //DropList = new ObservableCollection<ItemModel>();

            if (ProfileList.Count == 0)
                ProfileList = new ObservableCollection<ProfileModel>
                {
                    new ProfileModel
                    {
                        id = 0,
                        logname = "LOG1",
                        type = "Araxii",
                        killCount = 10,
                        tripValue = 5,
                        DropList = new ObservableCollection<ItemModel>()
                    }
                };

            RemoveItemCommand = new RelayCommand((par) => RemoveDrop(par));
            RemoveProfileCommand = new RelayCommand(par => RemoveProfile(par));
            AddProfileCommand = new RelayCommand(() => AddProfile());
        }

        /// <summary>
        /// Add an item to the list
        /// </summary>
        public void CreateDropList(ObservableCollection<ItemModel> itn, int index)
        {
            //Reset scroll bar
            ScrollBarAdjustment = true;

            ProfileList[CurrentlySelectedProfile].DropList.Add(new ItemModel
            {
                id = ProfileList[CurrentlySelectedProfile].DropList.Count,
                itemName = itn[index].itemName,
                imgSrc = itn[index].imgSrc,
                itemValue = itn[index].itemValue,
                multiId = itn[index].multiId++,
                uniqueId = itn[index].id
            });

            //Reset scroll bar
            ScrollBarAdjustment = false;
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

            LogViewModel.ItemDisplayList[ProfileList[CurrentlySelectedProfile].DropList[index].uniqueId].multiId--;

            //Remove item from the list
            ProfileList[CurrentlySelectedProfile].DropList.RemoveAt(index);

            //Restruct the list
            RestructInnerList(index, ProfileList);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();
        }

        private void RemoveProfile(object obj)
        {
            //Gets the index of the selected item
            int index = (int)obj;

            //Remove the selected item
            ProfileList.RemoveAt(index);

            //Fix the index after the item has been removed
            this.RestructList(index, ProfileList);
        }

        /// <summary>
        /// Index fix for the profile list
        /// </summary>
        /// <param name="index">Index of the selected item</param>
        /// <param name="clist">Adjustable list</param>
        public void RestructList(int index, ObservableCollection<ProfileModel> clist)
        {
            for (int i = index; i <= ProfileList.Count-1; i++)
                clist[i].id--;
        }

        /// <summary>
        /// Fix the index for the drop list in the profile list
        /// </summary>
        /// <param name="index">Index of the selected item</param>
        /// <param name="clist">Adjustable list</param>
        public void RestructInnerList(int index, ObservableCollection<ProfileModel> clist)
        {
            for (int i = index; i <= clist[CurrentlySelectedProfile].DropList.Count - 1; i++)
            {
                clist[CurrentlySelectedProfile].DropList[i].id--;
            }
        }
    }
}
