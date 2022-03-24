using System;

namespace HW_GenericsStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book(title: "The Lord of the Rings", content: "Bla bla bla", author: "J.R.R.Tolkien", category: "Fantasy");
            Book b2 = new Book(title: "The Lord of the Rings2", content: "Bla bla bla", author: "J.R.R.Tolkien", category: "Fantasy");
            Book b3 = new Book(title: "The Lord of the Rings2", content: "Bla bla bla", author: "J.R.R.Tolkien", category: "Fantasy");
            Console.WriteLine(b1);
            MyLibrary library = new MyLibrary();
            library.AddBook(b1);
            library.AddBook(b2);
            Console.WriteLine(library);
            library.AddBook(b3);
            Console.WriteLine(library);
            library.RemoveBook("The Lord of the Rings2");
            Console.WriteLine(library);
            library.RemoveBook("The Lord of the");
            Console.WriteLine(library);
            library.AddBook(b3);
            library.Clear();
            Console.WriteLine(library);
            library.AddBook(b1);
            library.AddBook(b2);
            if (library.HaveThisBook("The Lord of"))
                Console.WriteLine("Error");
            else if (library.HaveThisBook("The Lord of the Rings"))
                Console.WriteLine("Success");
            else
                Console.WriteLine("Error");
            Console.WriteLine(library.GetBook("The Lord of the Rings2"));
            Console.WriteLine(library.GetBooksByAuthor("J.R.R.sTolkien"));

        }
    }
}