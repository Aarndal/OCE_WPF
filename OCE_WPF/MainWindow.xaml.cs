using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OCE_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CardList cards = new CardList();
            cards.CreateCard();

            SaveClass saveClass = new SaveClass();
            saveClass.Save();

            saveClass.Load();

            saveClass.Save();
        }

        private void OpenWindow(object sender, RoutedEventArgs e)
        {
            Pop myPop = new Pop();
            myPop.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}