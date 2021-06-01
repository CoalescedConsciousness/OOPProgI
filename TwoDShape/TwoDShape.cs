using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    public abstract class TwoDShape
    {
        protected double width { get; set; }
        protected double height { get; set; }

        public TwoDShape()
        {
            this.width = 0;
            this.height = 0;
        }

        public TwoDShape(int xy)
        {
            this.width = Math.Abs(xy); // Bruges Math.Abs(olute) til at omregne enhver negativ værdi til et positivt tal (dens absolutte værdi)
            this.height = Math.Abs(xy);
        }

        public TwoDShape(double width, double height)
        {
            this.width = Math.Abs(width);
            this.height = Math.Abs(height);
        }

        public void GetMeasurements()
        {
            Console.WriteLine($"Width: {width} \tHeight: {height}");
        }

        public abstract double Area();
        public abstract void GetObjects();
    }


}
