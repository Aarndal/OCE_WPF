namespace OCE_WPF
{

    public enum Priority
    {
        None,
        Low,
        Medium,
        High,
        VeryHigh
    }

    internal class Card
    {
        public static List<string> CategoryList { get; set; }
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string date { get; set; }
        public Priority priority { get; set; }
        public string category { get; set; }
        public bool isDone { get; set; }

        public Card()
        {
            CategoryList = new List<string>();
            title = "Title";
            description = "Description";
            date = "0/0/0";
            priority = Priority.None;
            category = "Category";
            isDone = false;
        }

    }
}
