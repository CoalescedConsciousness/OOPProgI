using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            string user;

            Console.WriteLine("The day before today was the:");
            user = Console.ReadLine();

            try
            {
                DatoCheck.CheckDato(user);
            }
            catch (FormatException)
            {
                Console.WriteLine("Input value invalid. Please use the format [dd-mm-yyyy].");
            }
            finally
            {
                DatoCheck.CheckTruth(user);
            }
        }

    }
}
