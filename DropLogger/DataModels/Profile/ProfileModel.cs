using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DropLogger
{
    public class ProfileModel : BaseViewModel
    {
        public ObservableCollection<ItemModel> DropList { get; set; }
        public ObservableCollection<ItemModel> ItemDisplayList { get; set; }
        /// <summary>
        /// Log id number
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
        /// Name of the drop log
        /// </summary>
        private string _logname;
        public string logname
        {
            get { return _logname; }
            set
            {
                _logname = value;
                OnPropertyChanged("logname");
            }
        }
        /// <summary>
        /// Number of kills
        /// </summary>
        private int _killCount;
        public int killCount
        {
            get { return _killCount; }
            set
            {
                _killCount = value;
                OnPropertyChanged("killCount");
            }
        }
        private string _type;
        public string type
        {
            get { return _type; }
            set
            {
                _type = value;
                OnPropertyChanged("type");
            }
        }
        /// <summary>
        /// Total trip value
        /// </summary>
        private string _tripValue;
        public string tripValue
        {
            get { return _tripValue; }
            set
            {
                _tripValue = value;
                OnPropertyChanged("tripValue");
            }
        }
        /// <summary>
        /// Raw value of the trip value
        /// this is before the k, m, b label is attached
        /// </summary>
        private decimal _rawTripValue;
        public decimal rawTripValue
        {
            get { return _rawTripValue; }
            set
            {
                _rawTripValue = value;
                OnPropertyChanged("rawTripValue");
            }
        }
    }
}
