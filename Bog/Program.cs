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
            

            #region Del 1
            books[0].GetBook();
            Console.WriteLine("----");
            Bog.GetBooks(books);
            #endregion

            #region Del 2
            Console.WriteLine("\n\n######## DEL 2:");
            Bog book1 = new Bog("Learn Python the Hard Way", "Zed Shaw", "345");
            book1.GetBook();
            book1.titel = "Learn C# the Hard Way";
            book1.GetBook();
            books[0].author = "Ursula K. LeQuin";
            books[0].GetBook();
            #endregion

        }
    }
}
