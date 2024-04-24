using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCE_WPF
{
    internal class CardList : ObservableCollection<Card>
    {
        public List<Card> taskCards { get; set; }
        public CardList() 
        { 
            taskCards = new List<Card>();
        }   
        public void CreateCard()
        {
            taskCards.Add(new Card());
        }

        public List<Card> GetActiveCards()
        {
            List<Card> resultList = new List<Card>();
            foreach(Card card in taskCards)
            {
                if(!card.isDone)
                {
                    resultList.Add(card);
                }
            }
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
