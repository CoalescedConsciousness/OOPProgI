using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarVaskehal
{
    public class RentACar
    {
        List<Car> cars = new List<Car>();
        Queue<Car> qCars = new Queue<Car>();

        public RentACar()
        {
            cars.Add(new Car("12345", "Skoda", "Grøn"));
            cars.Add(new Car("23456", "Toyota", "Rød"));
            cars.Add(new Car("34567", "Ford", "Blå"));
        }

        /// <summary>
        /// Prints all cars in the list
        /// </summary>
        public void UdskrivBil()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c.HentBil());
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
            Console.WriteLine(cars[FindIndex(int.Parse(Console.ReadLine()))].HentBil());
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

        /// <summary>
        /// Note that there is an initializer method in the RentACar class, that points to the actualizing method in the Rent class
        /// Due to the fact that the assignment required us to establish the List in the RentACar class.
        /// </summary>
        /// <see cref="Rent.Udlaan(Car)"/>
        public void Udlaan() 
        {
            Console.WriteLine("Please specify the ID of the car you wish to rent:");
            Rent.Udlaan(cars[FindIndex(int.Parse(Console.ReadLine()))]);
        }

        /// <summary>
        /// Method located in RentACar which passes user input and List to a method located in the Rent class.
        /// The car is marked as Returned (laant == default, leveret != default), and sent to the Queue to be washed.
        /// </summary>
        /// <see cref="Rent.Aflever(Car)"/>
        public void Aflever()
        {
            Console.WriteLine("Please specify the ID of the car you wish to return:");
            int userInput = int.Parse(Console.ReadLine()); // Note that here the input is passed to a variable, in order to also pass the Car to be washed.
            Rent.Aflever(cars[FindIndex(userInput)]);
            SendBilTilVaskByID(userInput);

        }

        /// <summary>
        /// Forwards the Car Object list stored in RentACar to the Rent class. Prints out an overview of rented out cars (laant != default).
        /// </summary>
        /// <see cref="Rent.Overview(List{Car})"/>
        public void Overview()
        {
            Rent.Overview(cars);
        }

    }
}
