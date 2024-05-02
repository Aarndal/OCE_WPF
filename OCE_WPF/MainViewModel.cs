namespace OCE_WPF
{
    class MainViewModel : BaseViewModel
    {
        private CardList cardList;
        private SaveClass saveClass;
        private List<Card> activeCards;
        private List<Card> finishedCards;

        public static bool taskWindowOpen;

        public DelegateCommand NewTaskCommand { get; set; }

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

        public MainViewModel()
        {
            CardList = new CardList();
            SaveClass = new SaveClass();
            SaveClass.Load();
            ActiveCards = CardList.GetActiveCards();
            FinishedCards = CardList.GetFinishedCards();

            NewTaskCommand = new DelegateCommand(
                o =>
                {
                    PopUpWindow newTask = new ();
                    newTask.ShowDialog();
                },
                o =>
                {
                    return true;
                });

        }
    }
}
