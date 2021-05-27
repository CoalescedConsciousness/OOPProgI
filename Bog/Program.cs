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

            books[0].GetBook();
            Console.WriteLine("----");
            Bog.GetBooks(books);

        }
    }
}
