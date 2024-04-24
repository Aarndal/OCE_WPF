namespace OCE_WPF
{

    public enum Priority
    {
        NotImportant,
        ABitImportant,
        MoreImportant,
        KindaImportant,
        JoaSchonWichtig
    }

    internal class Card
    {
        public List<string> categoryList { get; set; }
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public Tuple<int, int, int> date { get; set; }
        public Priority priority { get; set; }
        public string category { get; set; }
        public bool isDone { get; set; }

        public Card()
        {
            title = "Title";
            description = "Description";
            date = Tuple.Create(0, 0, 0);
            priority = Priority.MoreImportant;
            category = "Category";
            isDone = false;
        }

    }
}
