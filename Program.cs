using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager library = new LibraryManager();

            // 添加书籍
            library.AddItem(new Novel(1, "The Old Man and the Sea", "Ernest Hemingway"));
            library.AddItem(new Magazine(2, "Time Magazine", 108));
            library.AddItem(new TextBook(3, "The Pearl", "John Steinbeck"));

            // 创建成员
            Member alice = new Member("Alice");
            Member bob = new Member("Bob");

            library.RegisterMember(alice);
            library.RegisterMember(bob);

            // 显示目录
            library.ShowCatalog();

            // Alice 借书 (使用null-forgiving运算符处理警告)
            var item1 = library.FindItemById(1);
            if (item1 != null) Console.WriteLine(alice.BorrowItem(item1!));

            var item2 = library.FindItemById(2);
            if (item2 != null) Console.WriteLine(alice.BorrowItem(item2!));

            var item3 = library.FindItemById(3);
            if (item3 != null) Console.WriteLine(alice.BorrowItem(item3!));

            // 再借一本 → 超过 3 本限制
            var item4 = new Novel(4, "Moby Dick", "Herman Melville");
            library.AddItem(item4);
            Console.WriteLine(alice.BorrowItem(item4));

            // Alice 还书
            if (item2 != null) Console.WriteLine(alice.ReturnItem(item2!));
            Console.WriteLine(alice.ReturnItem(item4));
        }
    }
}
    