using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class LibraryManager
    {
        private List<LibraryItem> catalog = new List<LibraryItem>();
        private List<Member> members = new List<Member>();

        public void AddItem(LibraryItem item) => catalog.Add(item);
        public void RegisterMember(Member member) => members.Add(member);

        public void ShowCatalog()
        {
            Console.WriteLine("\nLibrary Catalog:");
            foreach (var item in catalog)
            {
                Console.WriteLine(item.GetDetails());
            }
        }

        public LibraryItem? FindItemById(int id) => catalog.Find(i => i.Id == id);
        public Member? FindMemberByName(string name) => members.Find(m => m.Name == name);
        
        public void ShowMemberBorrowedItems(string memberName)
        {
            var member = FindMemberByName(memberName);
            if (member == null)
            {
                Console.WriteLine($"Member {memberName} not found.");
                return;
            }
            
            var borrowedItems = member.GetBorrowedItems();
            Console.WriteLine($"\nItems borrowed by {memberName}:");
            if (borrowedItems.Count == 0)
            {
                Console.WriteLine("No items borrowed.");
                return;
            }
            
            foreach (var item in borrowedItems)
            {
                Console.WriteLine(item.GetDetails());
            }
        }
    }
}
