using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            TestRun1();
        }

        static void TestRun1()
        {
            RentACar myRentACar = new RentACar();
            Console.WriteLine("------- Opretter et RentACar objekt (som er en liste af Car objekter -------");
            myRentACar.UdskrivBil();

            Console.WriteLine("\n\n\n------- Finder og udskriver et bestemt Car objekt i RentACar list-objektet ------");
            myRentACar.UdskrivBil(1);

            Console.WriteLine("\n\n\n------- Opretter (og tilføjer) et nyt Car objekt til RentACar listen via en metode ------");
            myRentACar.OpretNyBil("45678", "KIA", "Gul");
            myRentACar.UdskrivBil(3);

            Console.WriteLine("\n\n\n------- Fjerner et af objekterne fra listen, via en metode til at finde indeks nummeret på Car objektet i RentACar listen ------");
            myRentACar.SletBil(2);
            myRentACar.UdskrivBil();
        }
    }
}
