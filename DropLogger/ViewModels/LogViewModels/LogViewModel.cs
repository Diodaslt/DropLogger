using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    public class LogViewModel : MenuItemDetails
    {
        public static ObservableCollection<MenuItemDetails> DropList { get; set; }
        public LogViewModel()
        {
            this.name = "LOG";

            DropList = new ObservableCollection<MenuItemDetails>
            {
                new MenuItemDetails
                {
                    name = "DROP"
                }
            };
        }
    }
}
