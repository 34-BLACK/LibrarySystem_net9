namespace LibrarySystem
{
    public class TextBook : LibraryItem
    {
        public string Publisher { get; }

        public TextBook(int id, string title, string publisher)
            : base(id, title, ItemType.TextBook)
        {
            Publisher = publisher;
        }

        public override string GetDetails()
        {
            // 使用基类中的IsBorrowed属性
            return $"TextBook: {Title}, Publisher: {Publisher}, Status: {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}
    