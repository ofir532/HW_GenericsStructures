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
        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach (Book book in books.Values)
            {
                authors.Add(book.Author);
            }
            return authors;
        }
        public List<Book> GetBooksSortedByAuthorName()
        {
            return books.Values.OrderBy(book => book.Author).ToList();
        }
        public List<Book> GetBooksSortedByTitle()
        {
            return books.Values.OrderBy(book => book.Title).ToList();;
        }

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
