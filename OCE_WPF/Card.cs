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
        public int Id;
        public string title { get; set; }
        public string description { get; set; }
        public Tuple<int, int, int> date { get; set; }
        public Priority priority { get; set; }
        public List<string> category { get; set; }
        public bool isDone { get; set; }

        public Card()
        {
            title = "Title";
            description = "Description";
            date = Tuple.Create(0, 0, 0);
            priority = Priority.MoreImportant;
            category = new List<string>();
            category.Add("Hamburger");
            category.Add("Cheeseburger");
            category.Add("Other");
            isDone = false;
        }

    }
}
