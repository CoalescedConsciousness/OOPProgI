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

        public void SletBil(int id)
        {
            cars.RemoveAt(FindIndex(id));
        }

    }
}
