using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_GenericsStructures
{
    internal class MyLibrary
    {
        private Dictionary<string, Book> books;
        public MyLibrary()
        {
            books = new Dictionary<string, Book>();
        }
        public bool AddBook(Book book)
        {
            if (book == null)
                return false;
            return books.TryAdd(book.Title, book);
        }
        public bool RemoveBook(string title)
        {
            return books.Remove(title);
        }
        public void Clear()
        {
            books = new Dictionary<string, Book>();
        }
        public int Count()
        {
            return books.Count;
        }
        public bool HaveThisBook(string title)
        {
            return books.ContainsKey(title);
        }
        public Book GetBook(string title)
        {
            if (HaveThisBook(title))
                return books[title];
            else
                return null;
        }
        public Book GetBookByAuthor(string author)
        {
            Book autBook = null;
            foreach (Book book in books.Values)
            {
                if(book.Author == author)
                {
                    autBook = book;
                    return autBook;
                }
            }            
            return autBook;
        }
        //public List<string> GetAuthors()
        //{
        //    List<string> List1 = new List<string>();
        //    return List1;
        //}
        //public List<Book> GetBooksSortedByAuthorName()
        //{
        //    List<Book> List1 = new List<Book>();
        //    return List1;
        //}
        //public List<Book> GetBooksTitleSorted()
        //{
        //    List<Book> List1 = new List<Book>();
        //    return List1;
        //}

        public override string ToString()
        {
            string text = "";
            foreach (var keyValuePair in books)
            {
                text += keyValuePair.Key + " : " + keyValuePair.Value + "\n";
            }
            return text;
        }

    }
}
