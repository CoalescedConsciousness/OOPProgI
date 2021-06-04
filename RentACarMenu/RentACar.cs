using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    public class RentACar
    {
        List<Car> cars = new List<Car>();

        public RentACar()
        {
            cars.Add(new Car("12345", "Skoda", "Grøn"));
            cars.Add(new Car("23456", "Toyota", "Rød"));
            cars.Add(new Car("34567", "Ford", "Blå"));
        }

        public void UdskrivBil()
        {
            foreach (Car c in cars)
            {
                Console.WriteLine(c.HentBil());
            }
        }

        public void UdskrivBil(int carId)
        {
            Console.WriteLine(cars[FindIndex(carId)].HentBil());
        }

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

        public void OpretNyBil(string regNr, string mærke, string farve)
        {
            cars.Add(new Car(regNr, mærke, farve));
        }
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

        public void SletBil(int id)
        {
            cars.RemoveAt(FindIndex(id));
        }

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

    }
}
