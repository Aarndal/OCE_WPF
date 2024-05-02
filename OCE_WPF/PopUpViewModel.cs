using System.Windows;

namespace OCE_WPF
{
    class PopUpViewModel : BaseViewModel
    {
        public DelegateCommand DoneCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        public PopUpViewModel()
        {
            DoneCommand = new DelegateCommand(
                o =>
                {

                },
                o =>
                {
                    return true;
                });

            CancelCommand = new DelegateCommand(
                o =>
                {

                },
                o =>
                {
                    return true;
                });
        }
    }
}
