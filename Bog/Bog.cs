using System;
using System.Collections.Generic;
using System.Text;

namespace Bog
{
    public class Bog
    {
        #region Fields
        string titel;
        string author;
        readonly string Isbn; 
        List<Bog> books = new List<Bog>();
        #endregion

        #region Constructor
        public Bog(string titel, string author, string Isbn)
        {
            this.titel = titel;
            this.author = author;
            this.Isbn = Isbn;
        }
        #endregion

        #region Properties
        public List<Bog> Books
        {
            get
            {
                return books;
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string ISBN
        {
            get
            {
                return Isbn;
            }
        }

        #endregion

        public void GetBook()
        {
            Console.WriteLine("Titel:\t\t\tAuthor:\t\t\tISBN:");
            Console.WriteLine($"{titel}\t\t{author}\t\t{Isbn}");
        }

        public static void GetBooks(List<Bog> arrBooks)
        {
            Console.WriteLine("Titel:\t\t\t\tAuthor:\t\t\tISBN:");
            foreach (Bog book in arrBooks)
            {
                Console.WriteLine($"{book.titel}\t\t\t\t{book.author}\t\t{book.Isbn}");
            }
        }
    }



   
}
