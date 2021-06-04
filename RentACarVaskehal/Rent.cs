using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarVaskehal
{
    public class Rent
    {

        public static void Udlaan(Car c)
        {
            if (c.laant == default && c.washed == true)
            {
                c.laant = DateTime.Now;
                c.leveret = default;
            }
            else if (c.washed == false)
            {
                Console.WriteLine("The Car still needs to be washed.");
                Console.ReadKey();
            }
            else if (c.laant != default)
            {
                Console.WriteLine("The Car is currently unavailble");
                Console.ReadKey();
            }
        }



        public static void Aflever(Car c)
        {
            if (c.laant != default)
            {
                c.leveret = DateTime.Now;
                c.washed = false;
            }
        }

        // DEPRECATED!
        // Original intention for method was to view dirty cars. All cars are are now automatically added to the washing queue upon return.
        /*public static void Overview(List<Car> cars)
         {
             List<Car> tempCar = new List<Car>();
             Console.WriteLine("These cars need washing:");
             foreach (Car c in cars)
             {
                 if (c.washed == false)
                 {
                     Console.WriteLine(c.HentBil());
                     tempCar.Add(c);
                 }
             }
             Console.WriteLine($"In total: {tempCar.Count} cars need washing");

         }*/

        public static void Overview(List<Car> cars)
        {
            List<Car> tempCar = new List<Car>();
            Console.WriteLine("These cars are currently rented out:");
            foreach (Car c in cars)
            {
                if (c.laant != default)                                                 // All cars "laant" is set to default upon return, thus justifying this simple check
                    Console.WriteLine(c.HentBil() + $" Udlejet d. {c.laant}");
            }
        }
    }
}
