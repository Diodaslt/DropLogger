using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DropLogger
{
    public class ItemModel : BaseViewModel
    {
        public static ObservableCollection<ItemModel> ItemList { get; set; }
        public static LogViewModel LogInstance { get; set; }
        public ICommand AddItemCommand { get; set; }
        /// <summary>
        /// Item number 
        /// </summary>
        private int _id;
        public int id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged("id");
            }
        }
        /// <summary>
        /// Quantity of the specific item
        /// </summary>
        private int _multiId;
        public int multiId
        {
            get { return _multiId; }
            set
            {
                _multiId = value;
                OnPropertyChanged("multiId");
            }
        }
        /// <summary>
        /// Name of the drop
        /// </summary>
        private string _itemName;
        public string itemName
        {
            get { return _itemName; }
            set
            {
                _itemName = value;
                OnPropertyChanged("itemName");
            }
        }
        /// <summary>
        /// Path to item image
        /// </summary>
        private string _imgSrc;
        public string imgSrc
        {
            get { return _imgSrc; }
            set
            {
                _imgSrc = value;
                OnPropertyChanged("imgSrc");
            }
        }
        /// <summary>
        /// Value of the selected item
        /// </summary>
        private decimal _itemValue;
        public decimal itemValue
        {
            get { return _itemValue; }
            set
            {
                _itemValue = value;
                OnPropertyChanged("itemValue");
            }
        }
        /// <summary>
        /// Variable that links up the ItemDisplayList id with the DropList id
        /// </summary>
        private int _uniqueId;
        public int uniqueId
        {
            get { return _uniqueId; }
            set
            {
                _uniqueId = value;
                OnPropertyChanged("uniqueId");
            }
        }
    }
}
