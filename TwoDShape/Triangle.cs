using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    public class Triangle : TwoDShape
    {
        string style { get; set; }

        public Triangle(int width, int height, string style) : base(width, height)
        {
            this.style = style;
        }
        public Triangle() : base()
        {
            this.style = null;
        }
        public Triangle(int xy) : base(xy)
        {
            this.style = "Isosceles";
        }

        public override double Area()
        {
            return 0.5 * width * height;
        }

        public void Style()
        {
            Console.WriteLine($"Triangle Style: {style}");
        }

        public override void GetObjects()
        {
            Console.WriteLine($"{style}, {Area()}");
        }
    }
}
