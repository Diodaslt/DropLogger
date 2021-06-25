using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropLogger
{
    public class ListProperties : BaseViewModel
    {
        public static ListProperties Instance = new ListProperties();
        private bool _isProfileListEmpty;
        public bool isProfileListEmpty
        {
            get { return _isProfileListEmpty; }
            set
            {
                _isProfileListEmpty = value;
                OnPropertyChanged("isProfileListEmpty");
            }
        }
        private bool _isDropLogEmpty;
        public bool isDropLogEmpty
        {
            get { return _isDropLogEmpty; }
            set
            {
                _isDropLogEmpty = value;
                OnPropertyChanged("isDropLogEmpty");
            }
        }
        public ListProperties()
        {

        }
        public void CheckDropList()
        {
            if (ProfileViewModel.ProfileList.Count == 0)
                return;

            if (ProfileViewModel.ProfileList[ProfileViewModel.CurrentlySelectedProfile].DropList.Count == 0)
                isDropLogEmpty = true;
            else
                isDropLogEmpty = false;
        }
    }
}
