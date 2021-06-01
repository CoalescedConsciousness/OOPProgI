using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Collections
{
    public class Garage
    {
        public List<Car> colCar = new List<Car>();

        public void AddCar()
        {
            Console.WriteLine("Car Brand:");
            string carBrand = Console.ReadLine();
            Console.WriteLine("Car Color:");
            string carColor = Console.ReadLine();
            Console.WriteLine("Registration Number");
            string carId = Console.ReadLine();

            colCar.Add(new Car(carBrand, carColor, carId));
        }

        public void GetCar()
        {
            Console.WriteLine("Registration Number");
            string getId = Console.ReadLine();
            int indexNo = colCar.FindIndex(x => x.carID == getId);

            Console.WriteLine($"Registration: {colCar[indexNo].carID}\t\tBrand: {colCar[indexNo].carBrand}\t\tColor: {colCar[indexNo].carColor}");
        }

        public void GetAll()
        {
            foreach (Car x in colCar)
            {
                Console.WriteLine($"[{colCar.IndexOf(x)+1}]: Registration: {x.carID}\t\tBrand: {x.carBrand}\t\tColor: {x.carColor}");
            }
        }

        public void RemoveCar()
        {
            Console.WriteLine("Registration Number");
            string getId = Console.ReadLine();
            int indexNo = colCar.FindIndex(x => x.carID == getId);

            colCar.RemoveAt(indexNo);
            Console.WriteLine("Car Removed");
        }
    }
}
