using System.Windows.Controls;
using System.Windows.Input;

namespace DropLogger
{
    public class WindowModel : BaseViewModel
    {
        public ICommand CloseWindowCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; set; }
        public ICommand MenuCommand { get; set; }
        public ICommand OpenLogCommand { get; set; }
        public ICommand OpenExtraCommand { get; set; }
        private ContentControl _SelectedViewModel;
        public ContentControl SelectedViewModel 
        {
            get { return _SelectedViewModel; }
            set
            {
                _SelectedViewModel = value;
                OnPropertyChanged("SelectedViewModel");
            } 
        }
    }
}
