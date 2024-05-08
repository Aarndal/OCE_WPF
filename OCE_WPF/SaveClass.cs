using System.IO;

namespace OCE_WPF
{
    internal class SaveClass
    {
        private static string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        private static string folderPath = Path.Combine(appDataPath, "ToDoManager3000");
        private static string filePath = Path.Combine(folderPath, "CardData.txt");


        public void Save()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            StreamWriter sw = new StreamWriter(filePath);

            foreach (Card card in CardList.TaskCards)
            {
                sw.WriteLine(ConvertCardToString(card));
            }

            sw.Close();
        }

        public void Load()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            StreamReader sr = new StreamReader(filePath);

            string savedCardData = sr.ReadLine();

            CardList.TaskCards.Clear();
            while (!(savedCardData == "" || savedCardData == null))
            {
                CardList.TaskCards.Add(ConvertStringToCard(savedCardData));
                savedCardData = sr.ReadLine();
            }
            sr.Close();
        }
        public string ConvertCardToString(Card _input)
        {
            string cardID = _input.ID.ToString();
            string cardTitle = _input.title.Trim().Replace(" ","_");
            string cardDescription = _input.description.Trim().Replace(" ", "_");
            string cardDate = _input.date;
            string cardPriority = _input.priority.ToString();
            string cardCategory = _input.category;
            string cardStatus = _input.isDone.ToString();

            string result = cardID + " " + cardTitle + " " + cardDescription + " " + cardDate + " " + cardPriority + " " + cardCategory + " " + cardStatus;
            return result;
        }
        public Card ConvertStringToCard(string _input)
        {
            string[] rawCardData = new string[8];
            rawCardData = _input.Split(" ");
            Card result = new Card();

            int temp;
            int.TryParse(rawCardData[0], out temp);
            result.ID = temp;

            result.title = rawCardData[1].Replace("_", " ");

            result.description = rawCardData[2].Replace("_", " ");

            result.date = rawCardData[3];

            if(rawCardData.Count() < 8)
            {
                result.priority = Enum.Parse<Priority>(rawCardData[4]);

                result.category = rawCardData[5];
                if (result.category != "Category")
                {
                    Card.CategoryList.Add(result.category);
                }

                result.isDone = bool.Parse(rawCardData[6]);
            }
            else
            {
                result.priority = Enum.Parse<Priority>(rawCardData[6]);

                result.category = rawCardData[7];
                if (result.category != "Category")
                {
                    Card.CategoryList.Add(result.category);
                }

                result.isDone = bool.Parse(rawCardData[8]);
            }


            return result;
        }
    }
}
