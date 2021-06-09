using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{

    public class Rent
    {
        static Dictionary<Car, Customer> rentDic = new Dictionary<Car, Customer>(); // Dictionary to keep track of who rented what
 

        static void PrintDic()
        {
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("List of current Rentals:"); Console.ForegroundColor = ConsoleColor.White;
            foreach (KeyValuePair<Car, Customer> x in rentDic)
            {
                Console.WriteLine($"Car: {x.Key.regNr}, Brand: {x.Key.mærke} <<=>> Customer: {x.Value.id}, Name: {x.Value.name}");
            }
        }

        /// <summary>
        /// Method to mark a Car object as rented out *C*RUD
        /// </summary>
        /// <param name="c"></param>
        public static void Udlaan(Car c, Customer cu)
        {
            if (c.laant == default && c.washed == true)
            {
                c.laant = DateTime.Now;
                c.deadline = DateTime.Now.AddMonths(1);
                cu.rent = c;
                cu.debt = 1000;
                c.leveret = default;
                rentDic.Add(c, cu); // add as key/value-pair
                PrintDic();
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


        /// <summary>
        /// Method to mark a Car object as returned. CRU*D*
        /// </summary>
        /// <param name="c"></param>
        public static void Aflever(Car c, Customer cu)
        {
            if (c.laant != default)
            {
                c.leveret = DateTime.Now;
                c.washed = false;
            }
            if (c.deadline < DateTime.Now)
            {
                c.leveret = DateTime.Now;
                c.washed = false;
                double debt = c.leveret.Subtract(c.deadline).Days;
                debt *= 250;
                cu.debt += debt;
                Console.WriteLine($"Late return. You owe {debt:C2}");
                rentDic.Remove(c);
                PrintDic();
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

        /// <summary>
        /// Method for getting a list of all rented out Car objects. C*R*UD
        /// </summary>
        /// <param name="cars"></param>
        public static void RentedOverview(List<Car> cars, List<Customer> cust)
        {
            List<Car> tempCar = new List<Car>();
            Console.WriteLine("These cars are currently rented out:");
            foreach (Car c in cars)
            {
                if (c.laant != default) // All cars "laant" is set to default upon return, thus justifying this simple check
                {
                    Customer renter = cust.Find(cu => cu.rent == c);
                    Console.Write(c.ToString() + $" Udlejet d. {c.laant}, Customer: {renter.name}");
                }
            }
        }

        /// <summary>
        /// Prints out all Car and Customer objects in their respective lists, indiscriminately.
        /// </summary>
        /// <param name="cars"></param>
        /// <param name="cust"></param>
        public static void AllOverview(List<Car> cars, List<Customer> cust)
        {
            foreach (Car c in cars)
                Console.WriteLine(c.ToString());
            foreach (Customer cu in cust)
                Console.WriteLine(cu.ToString());
        }

        /// <summary>
        /// Method for extend the period of a lease.
        /// </summary>
        /// <param name="cars"></param>
        public static void Extend(List<Car> cars)
        {
            try
            {
                Console.WriteLine("Which car would you like to extend the rent of?");
                List<Car> tempCars = cars.FindAll(c => c.laant != default);
                foreach (Car c in tempCars)
                    Console.WriteLine(c.ToString() + ", Udlånt d. " + c.laant + ", Deadline d. " + c.deadline);

                int userInput = int.Parse(Console.ReadLine());
                Car selection = cars.Find(c => c.id == userInput);
                Console.WriteLine(selection.ToString());
                Console.WriteLine("And by how many days do you wish to extend the lease?");
                selection.deadline = selection.deadline.AddDays(int.Parse(Console.ReadLine()));
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("No such ID");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only integral numbers allowed");
            }
            catch (OverflowException)
            {
                Console.WriteLine("That's too long man!");
            }
            catch (Exception) { } // Just in case any unforeseen exceptions occur.

        }

    } 
}
