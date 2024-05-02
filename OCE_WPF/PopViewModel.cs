using System.Windows;

namespace OCE_WPF
{
    class PopViewModel : BaseViewModel
    {
        public DelegateCommand ClosePopCommand { get; set; }

        public PopViewModel()
        {
            ClosePopCommand = new DelegateCommand(
                o =>
                {
                    Window? win = o as Window;
                    win?.Close();
                },
                o =>
                {
                    return true;
                });
        }
    }
}
