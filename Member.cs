using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Member
    {
        public string Name { get; }
        private List<LibraryItem> borrowedItems;

        public Member(string name)
        {
            Name = name;
            borrowedItems = new List<LibraryItem>();
        }

        public string BorrowItem(LibraryItem item)
        {
            if (item == null)
                return "Item cannot be null.";
                
            if (item.IsBorrowed)
                return $"{item.Title} is already borrowed.";
                
            if (borrowedItems.Count >= 3)
                return "You cannot borrow more than 3 items.";

            borrowedItems.Add(item);
            item.IsBorrowed = true;  // 标记为已借出
            return $"{item.Title} has been borrowed by {Name}.";
        }

        public string ReturnItem(LibraryItem item)
        {
            if (item == null)
                return "Item cannot be null.";
                
            if (borrowedItems.Remove(item))
            {
                item.IsBorrowed = false;  // 标记为可借
                return $"{item.Title} has been returned successfully.";
            }
            else
            {
                return $"{item.Title} was not in borrowed list.";
            }
        }

        public List<LibraryItem> GetBorrowedItems() => borrowedItems;
    }
}
    