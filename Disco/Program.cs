using System;
using System.Timers;

public delegate void Dance();
namespace Disco
{
    class Program
    {
        static void Main(string[] args)
        {
            bool partytime = true;
            Timer party = new Timer();
            party.Enabled = true;

            while (partytime == true)
            { 
                party.Interval = 5000;
                if (party.Interval == 5000)
                {
                    Dance step = new Dance(Green);
                    Console.WriteLine("");
                    step();
                    party.Interval = 10000;
                   
                }
                if (party.Interval == 10000)
                {
                    Dance step = new Dance(Blue);
                    Console.WriteLine("");
                    step();
                    party.Interval = 15000;
                }
                if (party.Interval == 15000)
                {
                    Dance step = new Dance(Red);
                    Console.WriteLine("");
                    step();
                    party.Interval = 5000;
                }
            }

        }

        private static void Party_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Test");
        }

        public static void Green()
        {
            Console.BackgroundColor = ConsoleColor.Green;
        }
        public static void Blue()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
        }
        public static void Red()
        {
            Console.BackgroundColor = ConsoleColor.Red;
        }
    }
}
