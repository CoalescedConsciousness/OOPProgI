using System;
using System.Collections.Generic;
using System.Text;

namespace TwoDShape
{
    public class Rectangle : TwoDShape
    {
        string style; // Bliver nødt til at oprette variablen her, da tidligere i opgaven skulle style specifikt oprettes i Triangle klassen, som ikke nedarves fra her.
        
        public Rectangle(double height, double width) : base(height, width)
        {
            this.style = "Rectangle";
        }

        public bool IsSquare()
        {
            return (style == "Rectangle") ? true : false;
        }

        public override double Area() 
        {
            return height * width;
        }
        public override void GetObjects()
        {
            Console.WriteLine($"{style}, {Area()}");
        }
    }
}
