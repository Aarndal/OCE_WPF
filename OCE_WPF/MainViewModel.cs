namespace OCE_WPF
{
    class MainViewModel : BaseViewModel
    {


        public DelegateCommand NewTaskCommand { get; set; }
        public DelegateCommand LoadListCommand { get; set; }
        public DelegateCommand SaveListCommand { get; set; }
        public DelegateCommand QuitCommand { get; set; }

        private CardList cardList;
        private SaveClass saveClass;
        private List<Card> activeCards;
        private List<Card> finishedCards;
        public CardList CardList
        {
            get => cardList;
            set
            {
                if (cardList != value)
                {
                    cardList = value;
                    RaisePropertyChanged();
                }
            }
        }
        public SaveClass SaveClass
        {
            get => saveClass;
            set
            {
                if (saveClass != value)
                {
                    saveClass = value;
                    RaisePropertyChanged();
                }
            }
        }
        public List<Card> ActiveCards
        {
            get => activeCards;
            set
            {
                if (activeCards != value)
                {
                    activeCards = value;
                    RaisePropertyChanged();
                }
            }
        }
        public List<Card> FinishedCards
        {
            get => finishedCards;
            set
            {
                if (finishedCards != value)
                {
                    finishedCards = value;
                    RaisePropertyChanged();
                }
            }
        }

        public PopUpViewModel CurrentNewTaskVM;

        public MainViewModel()
        {
            CardList = new CardList();
            SaveClass = new SaveClass();
            SaveClass.Load();
            ReloadLists();



            NewTaskCommand = new DelegateCommand(
                o =>
                {
                    PopUpWindow newTask = new();
                    CurrentNewTaskVM = (PopUpViewModel)newTask.DataContext;
                    CurrentNewTaskVM.PopUpSave += (s , ev) =>
                    {
                       Card card = cardList.CreateCardReturn();
                        card.ID = CurrentNewTaskVM.ID;
                        card.title = CurrentNewTaskVM.title;
                        card.description = CurrentNewTaskVM.description;
                        card.date = CurrentNewTaskVM.date;
                        card.priority = Enum.Parse<Priority>((CurrentNewTaskVM.priority.Split())[1]);
                        card.category = CurrentNewTaskVM.category;
                        card.isDone = CurrentNewTaskVM.isDone;

                        SaveClass.Save();
                    };
                    newTask.ShowDialog();
                },
                o =>
                {
                    return true;
                });
            LoadListCommand = new DelegateCommand(
                o =>
                {
                    saveClass?.Load();
                    ReloadLists();

                },
                o =>
                {
                    return true;
                });
            SaveListCommand = new DelegateCommand(
                o =>
                {
                    saveClass?.Save();
                    ReloadLists();
                },
                o =>
                {
                    return true;
                });
            QuitCommand = new DelegateCommand(
                o =>
                {
                    Environment.Exit(0);
                },
                o =>
                {
                    return true;
                });

        }



        public void ReloadLists()
        {
            ActiveCards = CardList.GetActiveCards();
            FinishedCards = CardList.GetFinishedCards();
        }
    }
}
