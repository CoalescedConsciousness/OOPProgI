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
            // TestRun1(); 
            CarMenu();
        }

        /// <summary>
        /// Method to initiate a menu-like CLI
        /// </summary>
        static void CarMenu()
        {
            bool qMenu = false;
            RentACar myRentACar = new RentACar();
            do
            {
                Console.Clear();
                Console.WriteLine(@"
                                ////////////////////////////////////////////////////
                                //    Welcome to Rent-a-Car, we'll take you far   //
                                //            (...sorry)                          //
                                //                                                //
                                //                                                //
                                // You have the following options:                //
                                // [l]: List available cars                       //
                                // [s]: List a specific car by ID                 //
                                // [a]: Add a new car to the list                 //
                                // [d]: Delete a car from the list                //
                                // [q]: Exit                                      //
                                //                                                //
                                //                                                //
                                ////////////////////////////////////////////////////");


                switch (Console.ReadLine())
                {
                    case "l":
                        Console.Clear();
                        myRentACar.UdskrivBil();
                        Cont();
                        break;
                    case "s":
                        Console.Clear();
                        Console.Write("Please specify the ID of the car you wish to see: ");
                        myRentACar.UdskrivBil(int.Parse(Console.ReadLine()));
                        break;
                    case "a":
                        Console.Clear();
                        myRentACar.OpretNyBil(); // Note that this method is specifically added to avoid cluttering up the code for the menu, it calls the overloaded (original) method.
                        break;
                    case "d":
                        Console.Clear();
                        myRentACar.SletBil(); // Again, custom method to clear clutter from here, points to original overloaded method of the same name.
                        break;
                    case "q":
                        qMenu = true;
                        break;
                  

                        


                }
            } while (qMenu == false);

            /// <summary>
            /// Method for prompting the user to press a key to continue, if input would otherwise not be necessary.
            /// </summary>
            void Cont()
            {
                Console.WriteLine("\n\n\nPress any key to continue...");
                string response = Console.ReadLine();
                if (response == "a")
                {
                    while (response == "a")
                    {
                        Console.WriteLine("Not that one!! The OTHER one!");
                        response = Console.ReadLine();
                    }
                }
            }

        }

        /// <summary>
        /// Method for testing the methods of the classes involved.
        /// </summary>
        static void TestRun1()
        {
            RentACar myRentACar = new RentACar();
            Console.WriteLine("------- Opretter et RentACar objekt (som er en liste af Car objekter -------");
            myRentACar.UdskrivBil();

            Console.WriteLine("\n\n\n------- Finder og udskriver et bestemt Car objekt (1) i RentACar list-objektet ------");
            myRentACar.UdskrivBil(1);

            Console.WriteLine("\n\n\n------- Opretter (og tilføjer) et nyt Car objekt til RentACar listen via en metode ------");
            myRentACar.OpretNyBil("45678", "KIA", "Gul");
            myRentACar.UdskrivBil(3);

            Console.WriteLine("\n\n\n------- Fjerner et af objekterne (2) fra listen, via en metode til at finde indeks nummeret på Car objektet i RentACar listen ------");
            myRentACar.SletBil(2);
            myRentACar.UdskrivBil();
        }
    }
}
