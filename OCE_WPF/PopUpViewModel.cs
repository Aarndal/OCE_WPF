using System.Collections.ObjectModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;

namespace OCE_WPF
{
    class PopUpViewModel : BaseViewModel
    {
        public Window PopUpWindowItem { get; set; }
        public DelegateCommand DoneCommand { get; set; }
        public DelegateCommand CancelCommand { get; set; }
        public DelegateCommand AddCategoryCommand { get; set; }
        public static ObservableCollection<string> categoryList { get; set; }

        public event EventHandler PopUpSave;
        private int id;
        private string title;
        private string description;
        private string date;
        private string priority;
        private string category;
        private bool isDone;
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
        public ObservableCollection<string> CategoryList
        {
            get => categoryList;
            set
            {
                if (categoryList != value)
                {
                    categoryList = value;
                    RaisePropertyChanged();
                }
            }
        }


        public PopUpViewModel()
        {
            CategoryList = new ObservableCollection<string>(Card.CategoryList);
            title = "Title";
            description = "Description";
            date = "6/1/2005";
            priority = "n None";
            category = "";
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
            AddCategoryCommand = new DelegateCommand(
                o =>
                {
                    if (Category == "Category" || Category == null)
                    {
                        CategoryList.Add("New Category");
                        Category = CategoryList.Last();
                        return;
                    }
                    if (!CategoryList.Contains(Category))
                    {
                        CategoryList.Add(Category);
                        Category = CategoryList.Last();
                    }
                },
                o =>
                {
                    return true;
                });
        }
    }
}
