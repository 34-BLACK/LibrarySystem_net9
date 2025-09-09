using System;

namespace LibrarySystem
{
    public enum ItemType { Novel, Magazine, TextBook }

    public abstract class LibraryItem
    {
        public int Id { get; }
        public string Title { get; }
        public ItemType Type { get; }
        public bool IsBorrowed { get; set; }  // 新增的属性，标记是否被借出

        public LibraryItem(int id, string title, ItemType type)
        {
            Id = id;
            Title = title;
            Type = type;
            IsBorrowed = false;  // 初始化为未借出状态
        }

        public abstract string GetDetails();
    }
}
    