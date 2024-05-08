using System.Windows;

namespace OCE_WPF
{
    class PopUpViewModel : BaseViewModel
    {
        public Window PopUpWindowItem { get; set; }
        public DelegateCommand DoneCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }

        public event EventHandler PopUpSave;
        public int id;
        public string title;
        public string description;
        public string date;
        public string priority;
        public string category;
        public bool isDone;
        public int ID
        {
            get => id;
            set
            {
                if (id != value)
                {
                    id = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Description
        {
            get => description;
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Date
        {
            get => date;
            set
            {
                if (date != value)
                {
                    date = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Priority
        {
            get => priority;
            set
            {
                if (priority != value)
                {
                    priority = value;
                    RaisePropertyChanged();
                }
            }
        }
        public string Category
        {
            get => category;
            set
            {
                if (category != value)
                {
                    category = value;
                    RaisePropertyChanged();
                }
            }
        }
        public bool IsDone
        {
            get => isDone;
            set
            {
                if (isDone != value)
                {
                    isDone = value;
                    RaisePropertyChanged();
                }
            }
        }


        public PopUpViewModel()
        {
            title = "Title";
            description = "Description";
            date = "6/1/2005";
            priority = "None";
            category = "Category";
            isDone = false;

            DoneCommand = new DelegateCommand(
                o =>
                {
                    PopUpSave?.Invoke(this, EventArgs.Empty);
                    PopUpWindowItem.Close();
                },
                o =>
                {
                    return true;
                });

            CancelCommand = new DelegateCommand(
                o =>
                {
                    PopUpWindowItem.Close();
                },
                o =>
                {
                    return true;
                });
        }
    }
}
