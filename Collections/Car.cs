using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Car
    {
        public string carBrand { get; }
        public string carColor { get; set; }
        public string carID { get; }

        public Car(string brand, string color, string ID)
        {
            carBrand = brand;
            carColor = color;
            carID = ID;
        }
    }
}
