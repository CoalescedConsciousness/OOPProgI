using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarExt
{
    public delegate void RentListMethod(List<Car> cars, List<Customer> cust);     // Example of delegates to allow for using various methods that uses the same parameter types.
    public delegate void RentObjMethod(Car c, Customer cu);                       // See Overview() and AllOverview() as well as Udlaan() and Aflever() for useage.
    public class RentACar : Rent
    {
        List<Car> cars = new List<Car>();
        public static List<Customer> cust = new List<Customer>();             // List that stores all Customer objects
        Queue<Car> qCars = new Queue<Car>();                    // Queue (FIFO) for use in Car-wash routines.
        public List<Brands> brands;

        RentListMethod lDel;
        RentObjMethod oDel;

        public RentACar()
        {
            brands = new List<Brands>()
            {
                new Brands("Skoda"),
                new Brands("Toyota"),
                new Brands("Ford"),
            };

            cars.Add(new Car("12345", brands[0].bName, "Grøn"));
            cars.Add(new Car("23456", brands[1].bName, "Rød"));
            cars.Add(new Car("34567", brands[2].bName, "Blå"));
            cust.Add(new Customer("Karsten Askefis", 34, 182));
            cust.Add(new Customer("Aben Per", 5, 68));
        }

        #region Customer functionality:
        /// <summary>
        /// *C*RUD: Creates a new Customer object and adds it to the cust List.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        public void AddCust(string name, int age, int height)
        {
            cust.Add(new Customer(name, age, height));
        }
        public void AddCust()
        {
            Console.WriteLine("Customers full name:");
            string cName = Console.ReadLine();
            try
            {
                Console.WriteLine("Customer age:");
                int cAge = int.Parse(Console.ReadLine());
                Console.WriteLine("Customer height (in cm):");
                int cHeight = int.Parse(Console.ReadLine());
                AddCust(cName, cAge, cHeight);
                Console.WriteLine("Customer added.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Age and Height must be integral numbers");
            }
        }

        /// <summary>
        /// CRU*D*: Deletes a Customer object from the cust List.
        /// </summary>
        public void RmCust()
        {
            Console.WriteLine("Please specify the ID of the customer you wish to remove from the list:");
            int id = int.Parse(Console.ReadLine());
            cust.RemoveAt(id);
        }

        public static void RmCust(int i)
        {
            cust.RemoveAt(i);
        }
    
        /// <summary>
        /// CR*U*D: Updates a Customer object in the cust List.
        /// </summary>
        public void UpdCust()
        {
            Console.WriteLine("Specify the Customer ID you wish to customize:");
            int custID = int.Parse(Console.ReadLine());
            Customer target = cust[custID];
            Console.WriteLine("Which property do you wish to modify?: name, age, height, or debt?");

            switch (Console.ReadLine())
            {
                case "name":
                    Console.WriteLine("Please supply the new name:");
                    target.name = Console.ReadLine();
                    break;
                case "age":
                    Console.WriteLine("Please specify the correct age:");
                    target.age = int.Parse(Console.ReadLine());
                    break;
                case "height":
                    Console.WriteLine("New height (in cm)");
                    target.height = int.Parse(Console.ReadLine());
                    break;
                case "debt":
                    Console.WriteLine("Amount:");
                    double uInput = double.Parse(Console.ReadLine());
                    if (uInput >= 0)
                        target.debt += uInput;
                    if (uInput <= 0)
                        target.debt -= Math.Abs(uInput);
                    break;
            }
            Console.WriteLine("Done..");

        }

        #endregion


        #region Car functionality:
        /// <summary>
        /// Prints all cars in the list
        /// </summary>
        public void UdskrivBil()
        {
            foreach (Car c in cars)
            {
                if (c.laant == default)
                    Console.WriteLine(c.ToString());
            }
        }

        /// <summary>
        /// Prints a specific car based on input request inside the method.
        /// </summary>
        /// <seealso cref="FindIndex(int)"/>
        /// <seealso cref="Car.HentBil"/>
        public void UdskrivBilByID()
        {
            Console.Write("Please specify the ID of the car you wish to see: ");
            Console.WriteLine(cars[FindIndex(int.Parse(Console.ReadLine()))].ToString());
        }

        /// <summary>
        /// Locates a specific Car object in the RentACar list of Car objects, i.e. translates the human-"readable" Car ID to a computer-redable index number
        /// </summary>
        /// <param name="carId"></param>
        /// <returns></returns>
        private int FindIndex(int carId)
        {
            int counter = 0;
            foreach (Car c in cars)
            {
                if (c.id != carId)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

        /// <summary>
        /// Locates specific customer in the RentACar list of Customer objects, via the objects ID.
        /// </summary>
        /// <param name="custId"></param>
        /// <returns></returns>
        private int FindCustomerIndex(int custId)
        {
            int counter = 0;
            foreach (Customer c in cust)
            {
                if (c.id != custId)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }

        /// <summary>
        /// Creates a new Car object based on the arguments, and automatically adds it to the unified List
        /// </summary>
        /// <param name="regNr"></param>
        /// <param name="mærke"></param>
        /// <param name="farve"></param>
        public void OpretNyBil(string regNr, string mærke, string farve)
        {
            cars.Add(new Car(regNr, mærke, farve));
        }

        /// <summary>
        /// Creates a new Car object based on user input, and automatically adds it to the unified List
        /// </summary>
        public void OpretNyBil()
        {
            Console.Write("Please provide the registration number of the car: ");
            string regNr = Console.ReadLine();

            Console.Write("Please specify the brand of car: ");
            string mærke = Console.ReadLine();

            Console.Write("What color is this magnificent beast!?");
            string farve = Console.ReadLine();

            OpretNyBil(regNr, mærke, farve);
        }

        /// <summary>
        /// Removes a specified Car based on its ID 
        /// </summary>
        /// <param name="id"></param>
        public void SletBilByID(int id)
        {
            cars.RemoveAt(FindIndex(id));
        }

        /// <summary>
        /// Removes a specified Car based on it's ID, given as input by the user.
        /// </summary>
        public void SletBil()
        {
            Console.Write("Please specify the ID of the car you wish to remove from the list: ");
            cars.RemoveAt(FindIndex(int.Parse(Console.ReadLine()))); 
            /* This is a bit over-nested, but in broad terms:
            - RemoveAt needs the index of the item in the list
            - FindIndex finds the index of an item (i.e. Car), based on that items assigned ID.
            - int.Parse takes the input from the user, a string, and converts its to an int value, which is the accepted argument type of the FindIndex parameter.
             */
        }

        /// <summary>
        /// Adds a Car object, based on the ID - passed as an argument - to the Queue of cars to be washed
        /// </summary>
        /// <param name="id"></param>
        public void SendBilTilVaskByID(int id)
        {
            qCars.Enqueue(cars[FindIndex(id)]);
        }

        /// <summary>
        /// Adds a Car object, based on the ID based on input given by the user, to the Queue of cars to be washed
        /// </summary>
        public void SendBilTilVask()
        {
            Console.Write("Please specify which car needs washing: ");
            SendBilTilVaskByID(int.Parse(Console.ReadLine()));
        }

        /// <summary>
        /// Lists all Car objects currently in the Queue to be washed.
        /// </summary>
        public void VaskehalQueue()
        {
            Console.WriteLine($"There are currently {qCars.Count} cars in the queue.");
            foreach (Car c in qCars)
            {
                Console.WriteLine(c.HentBil());
            }

        }

        /// <summary>
        /// "Washes" the Car object at the start of the Queue ([0]) by setting the objects boolean "washed" field to true, and removing it from the queue.
        /// </summary>
        public void CarWashed()
        {
            qCars.Peek().washed = true;
            qCars.Dequeue();
        }

        #endregion

        #region Shared (Rent (Car, Customer)) functionality:
        /// <summary>
        /// Note that there is an initializer method in the RentACar class, that points to the actualizing method in the Rent class
        /// Due to the fact that the assignment required us to establish the List in the RentACar class.
        /// </summary>
        /// <see cref="Rent.Udlaan(Car, Customer)"/>
        public void Udlaan() 
        {
            

            try
            {
                oDel = Rent.Udlaan;
                Console.WriteLine("Please specify the ID of the car you wish to rent:");
                int car = int.Parse(Console.ReadLine());
                Console.WriteLine("And the ID of the customer who wishes to rent the car:");
                int cu = int.Parse(Console.ReadLine());
                oDel(cars[FindIndex(car)], cust[FindCustomerIndex(cu)]);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No such Car or Customer");
            }
            catch (TypeInitializationException e)
            {
                Console.WriteLine($"Delegate method is empty... {e.Message}");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Delegate Method problems, captain!");
            }
        }

        /// <summary>
        /// Method located in RentACar which passes user input and List to a method located in the Rent class.
        /// The car is marked as Returned (laant == default, leveret != default), and sent to the Queue to be washed.
        /// </summary>
        /// <see cref="Rent.Aflever(Car, Customer)"/>
        public void Aflever()
        {
            oDel = Rent.Aflever;

            try
            {
                Console.WriteLine("Please specify the ID of the car you wish to return:");
                int userCar = int.Parse(Console.ReadLine()); // Note that here the input is passed to a variable, in order to also pass the Car to be washed.
                Console.WriteLine("Please specify the Customer ID:");
                int userCust = int.Parse(Console.ReadLine());
                oDel(cars[FindIndex(userCar)], cust[FindCustomerIndex(userCust)]);
                SendBilTilVaskByID(userCar);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("No such Car or Customer");
            }

        }

        /// <summary>
        /// Forwards the Car Object list stored in RentACar to the Rent class. Prints out an overview of rented out cars (laant != default).
        /// </summary>
        /// <see cref="Rent.RentedOverview(List{Car}, List{Customer})"/>
        public void Overview()
        {
            lDel = Rent.RentedOverview;
            lDel(cars, cust);
        }

        public void Extend()
        {
            Rent.Extend(cars);
        }

        public void TestData()
        {
            Udlaan(cars[1], cust[0]);
            cars[1].laant.AddMonths(-2);
            cars[1].deadline.AddMonths(-1);
        }

        public void AllOverview()
        {
            lDel = Rent.AllOverview;
            lDel(cars, cust);
        }
        #endregion
    }
}
