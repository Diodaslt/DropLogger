using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    /// <summary>
    /// Class designed to calculate the total value of a single drop
    /// </summary>
    public class LootValue : BaseViewModel
    {
        public static LootValue Instance = new LootValue();
        private decimal _CompleteValue;
        public decimal CompleteValue 
        {
            get { return _CompleteValue; }
            set
            {
                _CompleteValue = value;
                OnPropertyChanged("CompleteValue");
            } 
        }
        private string _formattedValue;
        public string formattedValue
        {
            get { return _formattedValue; }
            set
            {
                _formattedValue = value;
                OnPropertyChanged("formattedValue");
            }
        }
        /// <summary>
        /// Total value of the drop
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
        /// Add the new item value to the current total value
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="value"></param>
        public void AddValue(int quantity, decimal value)
        {
            totalValue = quantity * value;
            CompleteValue = CompleteValue + totalValue;
            ValueFormatter(CompleteValue);
        }
        /// <summary>
        /// Remove the selected item from the total value
        /// </summary>
        /// <param name="quantity"></param>
        /// <param name="value"></param>
        public void RemoveValue(int quantity, decimal value)
        {
            totalValue = quantity * value;
            CompleteValue = CompleteValue - totalValue;
            ValueFormatter(CompleteValue);
        }

        /// <summary>
        /// Value reformatter
        /// Format between normal, k, m and b
        /// </summary>
        /// <param name="completevalue"></param>
        private void ValueFormatter(decimal completevalue)
        {
            if (completevalue > 999 && completevalue < 1000000)
            {
                completevalue = completevalue / 1000;
                formattedValue = String.Format("{0:F}k", completevalue);
            }
            else if (completevalue >= 1000000 && completevalue < 1000000000)
            {
                completevalue = completevalue / 1000000;
                formattedValue = String.Format("{0:F}m", completevalue);
            }
            else if (completevalue >= 1000000000)
            {
                completevalue = completevalue / 1000000000;
                formattedValue = String.Format("{0:F}b", completevalue);
            }
            else if (completevalue <= 999)
                formattedValue = completevalue.ToString();
        }
    }
}
