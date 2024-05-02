namespace OCE_WPF
{
    class ViewModel : BaseViewModel
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

        public ViewModel()
        {
            CardList = new CardList();
            SaveClass = new SaveClass();
            SaveClass.Load();
            ActiveCards = CardList.GetActiveCards();
            FinishedCards = CardList.GetFinishedCards();

            NewTaskCommand = new DelegateCommand(
                o =>
                {
                    Pop myPop = new Pop();
                    myPop.Show();
                    taskWindowOpen = true;
                },
                o =>
                {
                    return true;
                });

        }
    }
}
