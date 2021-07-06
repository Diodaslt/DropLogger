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
        public static LogViewModel Instance = new LogViewModel();
        public static ObservableCollection<ItemModel> ItemDisplayList { get; set; }
        public static ObservableCollection<ItemModel> DropList { get; set; }
        public ICommand AddItemCommand { get; set; }
        public LogViewModel()
        {
            //Skip if list is not null
            if (DropList == null)
                DropList = new ObservableCollection<ItemModel>();

            if (ItemDisplayList == null)
                ItemDisplayList = new ObservableCollection<ItemModel>();

            //Need this flag no to reset the list after everytime this model is selecetd
            //The display is supposed to be empty if the profile is empty as well
            //If the profile is not empty, then a new display should be initialized
            if (ItemDisplayList.Count == 0 && ProfileViewModel.ProfileList.Count != 0)
                ItemDisplayList = new ObservableCollection<ItemModel>
            {
               new ItemModel
               {
                   id = 0,
                   itemName = "Grimy lantadyme",
                   imgSrc = "/Design/Images/Grimy_lantadyme_detail.png",
                   minItemQuantity = 40,
                   maxItemQuantity = 55,
                   itemQuantity = 40,
                   itemValue = 7500,
               },
               new ItemModel
               {
                   id = 1,
                   itemName = "Grimy dwarf weed",
                   imgSrc = "/Design/Images/Grimy_lantadyme_detail.png",
                   itemQuantity = 45,
                   itemValue = 8400
               },
               new ItemModel
               {
                   id = 2,
                   itemName = "Grimy avantoe",
                   imgSrc = "/Design/Images/Grimy_avantoe_detail.png",
                   itemQuantity = 45,
                   itemValue = 1000
               },
               new ItemModel
               {
                   id = 3,
                   itemName = "Black dragonhide",
                   imgSrc = "/Design/Images/Black_dragonhide_detail.png",
                   minItemQuantity = 70,
                   maxItemQuantity = 90,
                   itemQuantity = 70,
                   itemValue = 3400
               },
               new ItemModel
               {
                   id = 4,
                   itemName = "Magic logs",
                   imgSrc = "/Design/Images/800px-Magic_logs_detail.png",
                   minItemQuantity = 5,
                   maxItemQuantity = 8,
                   itemQuantity = 5,
                   itemValue = 52000
               },
               new ItemModel
               {
                   id = 5,
                   itemName = "Yew logs",
                   imgSrc = "/Design/Images/800px-Yew_logs_detail.png",
                   itemQuantity = 600,
                   itemValue = 167
               },
               new ItemModel
               {
                   id = 6,
                   itemName = "Huge plated rune salvage",
                   imgSrc = "/Design/Images/800px-Huge_plated_rune_salvage_detail.png",
                   itemQuantity = 10,
                   itemValue = 66000
               },
               new ItemModel
               {
                   id = 7,
                   itemName = "Necrite stone spirit",
                   imgSrc = "/Design/Images/120px-Necrite_stone_spirit_detail.png",
                   itemQuantity = 20,
                   itemValue = 834
               },
               new ItemModel
               {
                   id = 8,
                   itemName = "Coins",
                   imgSrc = "/Design/Images/100px-Coins_detail.png",
                   minItemQuantity = 400024,
                   maxItemQuantity = 449225,
                   itemQuantity = 400024, 
                   itemValue = 1
               },
               new ItemModel
               {
                   id = 9,
                   itemName = "Water talisman",
                   imgSrc = "/Design/Images/Water_talisman_detail.png",
                   minItemQuantity = 40,
                   maxItemQuantity = 70,
                   itemQuantity = 40,
                   itemValue = 4650
               },
               new ItemModel
               {
                   id = 10,
                   itemName = "Banite stone spirit",
                   imgSrc = "/Design/Images/Banite_stone_spirit_detail.png",
                   itemQuantity = 25,
                   itemValue = 5000
               },
               new ItemModel
               {
                   id = 11,
                   itemName = "Dwarf weed seed",
                   imgSrc = "/Design/Images/Grimy_dwarf_weed_detail.png",
                   itemQuantity = 10,
                   itemValue = 8000
               },
               new ItemModel
               {
                   id = 12,
                   itemName = "Magic seed",
                   imgSrc = "/Design/Images/800px-Magic_seed_detail.png",
                   minItemQuantity = 5,
                   maxItemQuantity = 8,
                   itemQuantity = 5,
                   itemValue = 21000
               },
               new ItemModel
               {
                   id = 13,
                   itemName = "Battlestaff",
                   imgSrc = "/Design/Images/100px-Battlestaff_detail.png",
                   minItemQuantity = 50,
                   maxItemQuantity = 70,
                   itemQuantity = 50,
                   itemValue = 7000
               },
               new ItemModel
               {
                   id = 14,
                   itemName = "Onyx bolts (e)",
                   imgSrc = "/Design/Images/Onyx_bolts_(e)_detail.png",
                   minItemQuantity = 100,
                   maxItemQuantity = 251,
                   itemQuantity = 100,
                   itemValue = 8000
               },
               new ItemModel
               {
                   id = 15,
                   itemName = "Sirenic scale",
                   imgSrc = "/Design/Images/800px-Sirenic_scale_detail.png",
                   minItemQuantity = 2,
                   maxItemQuantity = 3,
                   itemQuantity = 2,
                   itemValue = 376000
               },
               new ItemModel
               {
                   id = 16,
                   itemName = "Uncut onyx",
                   imgSrc = "/Design/Images/Onyx_bolts_(e)_detail.png",
                   itemQuantity = 2,
                   itemValue = 3400000
               },
               new ItemModel
               {
                   id = 17,
                   itemName = "Hydrix bolt tips",
                   imgSrc = "/Design/Images/Hydrix_bolt_tips_detail.png",
                   itemQuantity = 40,
                   itemValue = 39600
               },
               new ItemModel
               {
                   id = 18,
                   itemName = "Spider leg top",
                   imgSrc = "/Design/Images/800px-Spider_leg_top_detail.png",
                   itemQuantity = 1,
                   itemValue = 48659794
               },
               new ItemModel
               {
                   id = 19,
                   itemName = "Spider leg middle",
                   imgSrc = "/Design/Images/120px-Spider_leg_middle_detail.png",
                   itemQuantity = 1,
                   itemValue = 48659794
               },
               new ItemModel
               {
                   id = 20,
                   itemName = "Spider leg bottom",
                   imgSrc = "/Design/Images/Spider_leg_bottom_detail.png",
                   itemQuantity = 1,
                   itemValue = 48659794
               },
               new ItemModel
               {
                   id = 21,
                   itemName = "Araxxi's fang",
                   imgSrc = "/Design/Images/85px-Araxxi's_fang_detail.png",
                   itemQuantity = 1,
                   itemValue = 221037761
               },
               new ItemModel
               {
                   id = 22,
                   itemName = "Araxxi's web",
                   imgSrc = "/Design/Images/Araxxi's_web_detail.png",
                   itemQuantity = 1,
                   itemValue = 2901075
               },
               new ItemModel
               {
                   id = 23,
                   itemName = "Araxxi's eye",
                   imgSrc = "/Design/Images/100px-Araxxi's_eye_detail.png",
                   itemQuantity = 1,
                   itemValue = 12228545
               },
               new ItemModel
               {
                   id = 24,
                   itemName = "Araxyte pet",
                   imgSrc = "/Design/Images/Dave_chathead.png"
               },
               new ItemModel
               {
                   id = 25,
                   itemName = "Araxyte egg",
                   imgSrc = "/Design/Images/100px-Araxxi's_eye_detail.png"
               },
               new ItemModel
               {
                   id = 26,
                   itemName = "Araxyte spider egg (unchecked)",
                   imgSrc = "/Design/Images/Araxyte_spider_egg_(unchecked)_detail.png",
               },
            };
        }

        /// <summary>
        /// Add a new item
        /// </summary>
        public void AddItem(object obj)
        {
            int index = (int)obj;

            LootValue.Instance.AddValue(ItemDisplayList[index].itemQuantity, ItemDisplayList[index].itemValue);

            if (ProfileViewModel.ProfileList.Count == 0)
            {
                //Show system message that he profile is empty
                ListProperties.Instance.isProfileListEmpty = true;
                return;
            }

            ItemDisplayList[index].multiId++;

            DropList.Add(new ItemModel
            {
                id = DropList.Count,
                itemName = ItemDisplayList[index].itemName,
                itemValue = ItemDisplayList[index].itemValue,
                itemQuantity = ItemDisplayList[index].itemQuantity,
                multiId = ItemDisplayList[index].multiId,
                uniqueId = ItemDisplayList[index].id
            });

            //Create an instance of this list in the ProfileList as a copy
            ProfileViewModel.Profile.CreateDropList(DropList, ItemDisplayList, index);

            //Check if the drop log is empty
            ListProperties.Instance.CheckDropList();

            //Notify the json file that changes have been made
            JSONDriver.WriteJson(ProfileViewModel.ProfileList);
        }
    }
}
