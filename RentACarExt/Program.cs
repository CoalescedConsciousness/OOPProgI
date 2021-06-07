using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarExt
{ 
    class Program
    {
        static void Main(string[] args)
        {
            // TestRun1(); 
            CarMenu();
        }

        #region Menu section
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
                                // ---- Overview(s): ----                         //
                                // [l]: List available cars                       //
                                // [o]: List of rented out cars                   //
                                // [s]: List a specific car by ID                 //
                                // [m]: List all cars and customers               //
                                //                                                //
                                // ---- Administrative tools:  ----               //
                                // [a]: Add a new car to the list                 //
                                // [d]: Delete a car from the list                //
                                // [v]: Add a new customer to the list            //
                                // [b]: Update info of and existing customer      //
                                // [n]: Delete a customer from the list           //
                                //                                                //
                                // ---- Car Wash: ----                            //
                                // [w]: Send a car to be washed                   //
                                // [h]: View queue of cars to be washed           //
                                // [f]: Finish washing a car                      //
                                //                                                //
                                // ---- Renting: ----                             //
                                // [u]: Rent out a car                            //
                                // [r]: Return a car                              //
                                // [x]: Extend rent of car                        //
                                // [q]: Exit                                      //
                                //                                                //
                                // [½]: Load Test Data                            //
                                //                                                //
                                ////////////////////////////////////////////////////");

                // Switch case to allow user navigation
                switch (Console.ReadLine())
                {
                    case "l":
                        Console.Clear();
                        myRentACar.UdskrivBil();
                        Cont();
                        break;
                    case "o":
                        Console.Clear();
                        myRentACar.Overview();
                        Cont();
                        break;
                    case "s":
                        Console.Clear();
                        myRentACar.UdskrivBilByID();
                        Cont();
                        break;
                    case "m":
                        Console.Clear();
                        myRentACar.AllOverview();
                        Cont();
                        break;
                    case "a":
                        Console.Clear();
                        myRentACar.OpretNyBil(); // Note that this method is specifically added to avoid cluttering up the code for the menu, it calls the overloaded (original) method.
                        break;
                    case "d":
                        Console.Clear();
                        myRentACar.SletBil(); // Again, custom method to clear clutter from here, points to original overloaded method of the same name.
                        break;
                    case "v":
                        Console.Clear();
                        myRentACar.AddCust();
                        Cont();
                        break;
                    case "b":
                        break;
                    case "n":
                        break;
                    case "w":
                        Console.Clear();
                        myRentACar.SendBilTilVask();
                        break;
                    case "h":
                        Console.Clear();
                        myRentACar.VaskehalQueue();
                        Cont();
                        break;
                    case "f":
                        Console.Clear();
                        myRentACar.CarWashed();
                        Cont();
                        break;
                    case "u":
                        Console.Clear();
                        myRentACar.Udlaan();
                        Cont();
                        break;
                    case "r":
                        Console.Clear();
                        myRentACar.Aflever();
                        Cont();
                        break;
                    case "x":
                        Console.Clear();
                        myRentACar.Extend();
                        Cont();
                        break;
                    case "q":
                        qMenu = true;
                        break;
                    case "½":
                        LoadTestData();
                        Cont();
                        break;
                }
            } while (qMenu == false);
            #endregion

            #region Fluff method to save menu space code-wise
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
            #endregion

            #region Test-data
            void LoadTestData()
            {
                myRentACar.TestData();
                Console.WriteLine("Test data loaded...");
            }
            #endregion
        }

        #region Test-run
        /// <summary>
        /// Method for testing the methods of the classes involved.
        /// </summary>
        static void TestRun1()
        {
            RentACar myRentACar = new RentACar();
            Console.WriteLine("------- Opretter et RentACar objekt (som er en liste af Car objekter -------");
            myRentACar.UdskrivBil();

            Console.WriteLine("\n\n\n------- Finder og udskriver et bestemt Car objekt (1) i RentACar list-objektet ------");
            myRentACar.UdskrivBilByID();

            Console.WriteLine("\n\n\n------- Opretter (og tilføjer) et nyt Car objekt til RentACar listen via en metode ------");
            myRentACar.OpretNyBil("45678", "KIA", "Gul");
            myRentACar.UdskrivBilByID();

            Console.WriteLine("\n\n\n------- Fjerner et af objekterne (2) fra listen, via en metode til at finde indeks nummeret på Car objektet i RentACar listen ------");
            myRentACar.SletBilByID(2);
            myRentACar.UdskrivBil();
        }
        #endregion
    }
}
