using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    class ColorTriangle : Triangle
    {
        string color;

        public ColorTriangle(string color) : base()
        {
            this.color = color;
        }

        public void DisplayColor()
        {
            Console.WriteLine("Farve: " + color);
        }
    }
}
