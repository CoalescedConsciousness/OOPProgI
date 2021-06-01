using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            garage.colCar.Add(new Car("Pony", "Black", "2345"));
            garage.colCar.Add(new Car("Cat", "Grey", "3456"));

            garage.AddCar();
            garage.GetCar();
            garage.GetAll();


        }
    }
}
