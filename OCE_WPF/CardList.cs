using System.Collections.ObjectModel;

namespace OCE_WPF
{
    internal class CardList : ObservableCollection<Card>
    {
        public static List<Card> taskCards { get; set; }

        public CardList()
        {
            taskCards = new List<Card>();
        }
        public void CreateCard()
        {
            taskCards.Add(new Card());
        }

        public void DeleteCard(int _id)
        {
            Card cardToDelete = null;
            foreach (Card card in taskCards)
            {
                if (card.ID == _id)
                {
                    cardToDelete = card;
                }
            }
            if (cardToDelete != null)
            {
                taskCards.Remove(cardToDelete);
            }
        }

        public List<Card> GetActiveCards()
        {
            List<Card> resultList = new List<Card>();
            foreach (Card card in taskCards)
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
            foreach (Card card in taskCards)
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
