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
        public static LogViewModel LogInstance { get; set; }
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
        /// Number of items received from the same drop
        /// between min and max
        /// </summary>
        private int _itemQuantity;
        public int itemQuantity
        {
            get { return _itemQuantity; }
            set
            {
                _itemQuantity = value;
                OnPropertyChanged("itemQuantity");
            }
        }
        /// <summary>
        /// Multiple quantity drop min value
        /// </summary>
        private int _minItemQuantity;
        public int minItemQuantity
        {
            get { return _minItemQuantity; }
            set
            {
                _minItemQuantity = value;
                OnPropertyChanged("minItemQuantity");
            }
        }
        /// <summary>
        /// Multiple quantity drop max value
        /// </summary>
        private int _maxItemQuantity;
        public int maxItemQuantity
        {
            get { return _maxItemQuantity; }
            set
            {
                _maxItemQuantity = value;
                OnPropertyChanged("maxItemQuantity");
            }
        }
        /// <summary>
        /// Total value of the drop received
        /// Quantity * Item value
        /// </summary>
        private decimal _totalValue;
        public decimal totalValue
        {
            get { return _totalValue; }
            set
            {
                _totalValue = value;
                OnPropertyChanged("totalValue");
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
