using System.IO;

namespace OCE_WPF
{
    internal class SaveClass
    {
        public void Save()
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\pasca\\Test.txt");

            foreach(Card card in CardList.taskCards)
            {
                sw.WriteLine(ConvertCardToString(card));
            }

            sw.Close();
        }
        
        public void Load()
        {
        }
        public string ConvertCardToString(Card _input)
        {
            string cardID = _input.ID.ToString();
            string cardTitle = _input.title;
            string cardDescription = _input.description;
            string cardDate = _input.date.ToString();
            string cardPriority = _input.priority.ToString();
            string cardCategory = _input.category;
            string cardStatus = _input.isDone.ToString();

            string result = cardID + " " + cardTitle + " " + cardDescription + " " + cardDate + " " + cardPriority + " " + cardCategory + " " + cardStatus;
            return result; 
        }
        public Card ConvertStringToCard(string _input)
        {
            string[] input = _input.Split(" ");
            Card result = new Card();

            int temp;
            int.TryParse(input[0], out temp);
            result.ID = temp;
            

            return result;
        }
    }
}
