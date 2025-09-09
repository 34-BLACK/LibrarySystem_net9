namespace LibrarySystem
{
    public class Novel : LibraryItem
    {
        public string Author { get; }

        public Novel(int id, string title, string author)
            : base(id, title, ItemType.Novel)
        {
            Author = author;
        }

        public override string GetDetails()
        {
            // 使用基类中的IsBorrowed属性
            return $"Novel: {Title}, Author: {Author}, Status: {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}
    