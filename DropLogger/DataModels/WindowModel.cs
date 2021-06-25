using System.Windows.Controls;
using System.Windows.Input;

namespace DropLogger
{
    public class WindowModel : BaseViewModel
    {
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand LogViewCommand { get; set; }
        public ICommand ProfileViewCommand { get; set; }
        public ICommand ExtraViewCommand { get; set; }
        /// <summary>
        /// Variable that will have view assigned to it
        /// </summary>
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
    }
}
