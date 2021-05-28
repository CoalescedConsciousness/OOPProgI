using System;
using System.Collections.Generic;

namespace Bog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bog> books = new List<Bog>();

            books.Add(new Bog("Jordhavet", "Ursula K LeQuin", "123"));
            books.Add(new Bog("From Bach To Bacteria And Back", "Daniel Dennett", "234"));


            #region Lektion 1.1
            Console.WriteLine("\n\n######## LEKTION 1.1:");
            books[0].GetBook();
            Console.WriteLine("----");
            Bog.GetBooks(books);
            #endregion

            #region Lektion 1.2
            Console.WriteLine("\n\n######## LEKTION 1.2:");
            Bog book1 = new Bog("Learn Python the Hard Way", "Zed Shaw", "345");
            book1.GetBook();
            book1.Titel = "Learn C# the Hard Way";
            book1.GetBook();
            books[0].Author = "Ursula K. LeQuin";
            books[0].GetBook();
            #endregion

            #region Lektion 2.1
            Bog book2 = new Bog { Titel = "Zalt", Author = "Jon Bing", Isbn = "345" };
            Console.WriteLine("\n\n\n######## LEKTION 2.1:");
            book2.GetBook();

            Bog book3 = new Bog("Azur") { Author = "Jon Bing", Isbn = "456" };
            book3.GetBook();
            #endregion

            #region Lektion 2.x
            Blad mag1 = new Blad { magName = "Journal of Consciousness Studies", issue = 1, pCount = 129 };
            mag1.GetMag();
            #endregion

            #region 3.1
            Console.WriteLine("\n\n######## LEKTION 3.1:");
            Bog book4 = new Bog { Titel = "Tanz", Author = "Jon Bing", Isbn = "567", InStore = 4 };
            Boghandler.Sælg(book4);
            #endregion


            #region Menu
            bool done = false;

            do
            {
                Console.WriteLine("\n\n\n[a] Add new book");
                Console.WriteLine("[u] Update storage for a book");
                Console.WriteLine("[g] List all books");
                Console.WriteLine("[q] Quit (the program, not your job. Dumb-dumb)");

                switch (Console.ReadLine())
                {
                    case "a":
                        Bog.AddBook();
                        break;
                    case "u":
                        Bog.UpdateStorage(books);
                        break;
                    case "g":
                        Bog.GetBooks(books);
                        break;
                    case "q":
                        done = true;
                        break;
                }
            } while (done == false);
            #endregion
        }
    }
}
