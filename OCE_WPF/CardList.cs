using System.Collections.ObjectModel;

namespace OCE_WPF
{
    internal class CardList : ObservableCollection<Card>
    {
        public static List<Card> TaskCards { get; set; }

        public CardList()
        {
            TaskCards = new List<Card>();
        }
        public void CreateCard()
        {
            TaskCards.Add(new Card());
        }

        public void DeleteCard(int _id)
        {
            Card cardToDelete = null;
            foreach (Card card in TaskCards)
            {
                if (card.ID == _id)
                {
                    cardToDelete = card;
                }
            }
            if (cardToDelete != null)
            {
                TaskCards.Remove(cardToDelete);
            }
        }

        public List<Card> GetActiveCards()
        {
            List<Card> resultList = new List<Card>();
            foreach (Card card in TaskCards)
            {
                if (!card.isDone)
                {
                    resultList.Add(card);
                }
            }
            resultList.Sort();
            return resultList;
        }
        public List<Card> GetFinishedCards()
        {
            List<Card> resultList = new List<Card>();
            foreach (Card card in TaskCards)
            {
                if (card.isDone)
                {
                    resultList.Add(card);
                }
            }
            return resultList;
        }
    }
}
