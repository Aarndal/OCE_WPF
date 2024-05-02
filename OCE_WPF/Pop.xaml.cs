using System.Windows;

namespace OCE_WPF
{
    /// <summary>
    /// Interaction logic for Pop.xaml
    /// </summary>
    public partial class Pop : Window
    {
        public Pop()
        {
            InitializeComponent();
        }

        private void PopLoaded(object sender, RoutedEventArgs e)
        {
            //((ViewModel)DataContext).NewTaskCommand.CanExecute = false;
        }

        private void PopClosed(object sender, EventArgs e)
        {

        }
    }
}
