namespace LibrarySystem
{
    public class Magazine : LibraryItem
    {
        public int IssueNumber { get; }

        public Magazine(int id, string title, int issueNumber)
            : base(id, title, ItemType.Magazine)
        {
            IssueNumber = issueNumber;
        }

        public override string GetDetails()
        {
            // 使用基类中的IsBorrowed属性
            return $"Magazine: {Title}, Issue #{IssueNumber}, Status: {(IsBorrowed ? "Borrowed" : "Available")}";
        }
    }
}
    