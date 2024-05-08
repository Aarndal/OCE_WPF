using System.Reflection;
using System.Windows;

namespace OCE_WPF
{
    /// <summary>
    /// Interaction logic for Pop.xaml
    /// </summary>
    public partial class PopUpWindow : Window
    {
        public PopUpWindow()
        {
            InitializeComponent();
        }

        private void PopUpLoaded(object sender, RoutedEventArgs e)
        {
            ((PopUpViewModel) DataContext).PopUpWindowItem = (Window)sender;
        }

        private void PopUpClosed(object sender, RoutedEventArgs e)
        {

        }
    }
}
