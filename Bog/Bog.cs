using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Bog
{
    public class Bog
    {
        // Lektion 1.2: Omstruktureret til auto-properties.
        #region Fields
        public string Titel { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public int AntalSider { get; }
        public int InStore { get; set; } = 0;
        public List<Bog> Books { get; set; } = new List<Bog>();
        #endregion

        #region Lektion 1.1
        #region Constructor
        public Bog(string titel, string author, string Isbn)
        {
            this.Titel = titel;
            this.Author = author;
            this.Isbn = Isbn;
        }
        #endregion

        #region Properties // Kommenteret ud pga. Lektion 1.2
        /* public List<Bog> Books
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
         }*/

        #endregion

        #region Methods for fetching data
        public void GetBook()
        {
            Console.WriteLine("Titel:\t\t\tAuthor:\t\t\tISBN:\t\tCopies:");
            Console.WriteLine($"{Titel}\t\t{Author}\t\t{Isbn}\t\t{InStore}");
        }

        public static void GetBooks(List<Bog> arrBooks)
        {
            Console.WriteLine("Titel:\t\t\t\tAuthor:\t\t\tISBN:\t\t\tCopies:");
            foreach (Bog book in arrBooks)
            {
                Console.WriteLine($"{book.Titel}\t\t\t\t{book.Author}\t\t{book.Isbn}\t\t{book.InStore}");
            }
        }
        #endregion
        #endregion

        #region Lektion 2.1
        // Tilføjer en constructor uden argument, da man ellers ikke kan bruge object initializing.
        public Bog() { }

        public Bog(string titel)
        {
            this.Titel = titel;
        }
        #endregion

        #region Andet (selvstændigt)
        #region AddBook method
        /// <summary>
        /// Adds a new book object according to the input values (string titel, string author, string isbn, int copies)
        /// </summary>
        static public void AddBook()
        {
            Console.WriteLine("Titel of the book:");
            string titel = Console.ReadLine();
            Console.WriteLine("Author of the book:");
            string author = Console.ReadLine();
            Console.WriteLine("ISBN of the book:");
            string isbn = Console.ReadLine();
            Console.WriteLine("Number of copies of the book on hand:");
            int beholdning = int.Parse(Console.ReadLine());

            new Bog { Titel = titel, Author = author, Isbn = isbn, InStore = beholdning };


        }
        #endregion
        #region UpdateStorage method
        static public void UpdateStorage(List<Bog> books)
        {
            Console.WriteLine("Please Specify which book (titel) you want to update storage for:");
            string bookName = Console.ReadLine();
            Console.WriteLine("Please write the amount received:");
            int bookAmount = int.Parse(Console.ReadLine());
            try
            {
                books.Find(x => x.Titel == bookName).InStore += bookAmount; // Finds a book matching the given name and overwrites the InStore value with the supplied integer value.
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("!! Book doesn't exists");
            }
            #endregion
            #endregion
        }


    }

}
