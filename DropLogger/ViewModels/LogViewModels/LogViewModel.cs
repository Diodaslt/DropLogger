using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DropLogger
{
    public class LogViewModel : ItemModel
    {
        public static ObservableCollection<ItemModel> ItemDisplayList { get; set; }
        public LogViewModel()
        {
            //Skip if list is not null
            if (ItemList == null)
                ItemList = new ObservableCollection<ItemModel>();

            if (ItemDisplayList == null)
                ItemDisplayList = new ObservableCollection<ItemModel>();

            ItemDisplayList = new ObservableCollection<ItemModel>
            {
               new ItemModel
               {
                   id = 0,
                   itemName = "Grimy lantadyme",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Grimy_lantadyme_detail.png"
               },
               new ItemModel
               {
                   id = 1,
                   itemName = "Grimy dwarf weed",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Grimy_lantadyme_detail.png"
               },
               new ItemModel
               {
                   id = 2,
                   itemName = "Grimy avantoe",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Grimy_avantoe_detail.png"
               },
               new ItemModel
               {
                   id = 3,
                   itemName = "Black dragonhide",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Black_dragonhide_detail.png"
               },
               new ItemModel
               {
                   id = 4,
                   itemName = "Magic logs",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Magic_logs_detail.png"
               },
               new ItemModel
               {
                   id = 5,
                   itemName = "Yew logs",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Yew_logs_detail.png"
               },
               new ItemModel
               {
                   id = 6,
                   itemName = "Huge plated rune salvage",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Huge_plated_rune_salvage_detail.png"
               },
               new ItemModel
               {
                   id = 7,
                   itemName = "Necrite stone spirit",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/120px-Necrite_stone_spirit_detail.png"
               },
               new ItemModel
               {
                   id = 8,
                   itemName = "Coins",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/100px-Coins_detail.png"
               },
               new ItemModel
               {
                   id = 9,
                   itemName = "Water talisman",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Water_talisman_detail.png"
               },
               new ItemModel
               {
                   id = 10,
                   itemName = "Banite stone spirit",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Banite_stone_spirit_detail.png"
               },
               new ItemModel
               {
                   id = 11,
                   itemName = "Dwarf weed seed",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Grimy_dwarf_weed_detail.png"
               },
               new ItemModel
               {
                   id = 12,
                   itemName = "Magic seed",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Magic_seed_detail.png"
               },
               new ItemModel
               {
                   id = 13,
                   itemName = "Battlestaff",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/100px-Battlestaff_detail.png"
               },
               new ItemModel
               {
                   id = 14,
                   itemName = "Onyx bolts (e)",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Onyx_bolts_(e)_detail.png"
               },
               new ItemModel
               {
                   id = 15,
                   itemName = "Sirenic scale",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Sirenic_scale_detail.png"
               },
               new ItemModel
               {
                   id = 16,
                   itemName = "Uncut onyx",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Onyx_bolts_(e)_detail.png"
               },
               new ItemModel
               {
                   id = 17,
                   itemName = "Hydrix bolt tips",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Hydrix_bolt_tips_detail.png"
               },
               new ItemModel
               {
                   id = 18,
                   itemName = "Spider leg top",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/800px-Spider_leg_top_detail.png"
               },
               new ItemModel
               {
                   id = 19,
                   itemName = "Spider leg middle",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/120px-Spider_leg_middle_detail.png"
               },
               new ItemModel
               {
                   id = 20,
                   itemName = "Spider leg bottom",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Spider_leg_bottom_detail.png"
               },
               new ItemModel
               {
                   id = 21,
                   itemName = "Araxxi's fang",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/85px-Araxxi's_fang_detail.png"
               },
               new ItemModel
               {
                   id = 22,
                   itemName = "Araxxi's web",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Araxxi's_web_detail.png"
               },
               new ItemModel
               {
                   id = 23,
                   itemName = "Araxxi's eye",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/100px-Araxxi's_eye_detail.png"
               },
               new ItemModel
               {
                   id = 24,
                   itemName = "Araxyte pet",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Dave_chathead.png"
               },
               new ItemModel
               {
                   id = 25,
                   itemName = "Araxyte egg",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/100px-Araxxi's_eye_detail.png"
               },
               new ItemModel
               {
                   id = 26,
                   itemName = "Araxyte spider egg (unchecked)",
                   AddItemCommand = new RelayCommand((par) => AddItem(par)),
                   imgSrc = "/Design/Images/Araxyte_spider_egg_(unchecked)_detail.png"
               },
            };
        }

        /// <summary>
        /// Add a new item
        /// </summary>
        private void AddItem(object obj)
        {
            int index = (int)obj;

            if (ProfileViewModel.ProfileList.Count == 0)
            {
                //Show system message that he profile is empty
                ListProperties.Instance.isProfileListEmpty = true;
                return;
            }

            ProfileViewModel.Profile.CreateDropList(ItemDisplayList, index);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();
        }
    }
}
