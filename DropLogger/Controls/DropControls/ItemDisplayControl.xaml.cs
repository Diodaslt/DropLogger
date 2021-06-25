using System.Windows.Controls;

namespace DropLogger
{
    /// <summary>
    /// Interaction logic for DropLogControl.xaml
    /// </summary>
    public partial class ItemDisplayControl : UserControl
    {
        public ItemDisplayControl()
        {
            InitializeComponent();
            this.DataContext = new LogViewModel();
        }
    }
}
