using System;
using System.Collections.Generic;

namespace TwoDShape
{
    class Program
    {
        static void Main(string[] args)
        {
            /// BEMÆRK!: Del 2.2 krævede at man omstrukturerede TwoDShapes til at indeholde abstrakte metoder (og dermed være en abstrakt klasse), hvor jeg har udkommenteret
            /// kode, der ellers ville have forsøgt at oprette et objekt af klassen, hvilket ikke længere kan lade sig gøre.
            #region 1.1
            Console.WriteLine("\n\n---- DEL 1.1 ----");
/*            TwoDShape shape1 = new TwoDShape(5, 10);*/
            Triangle triangle1 = new Triangle(4, 8, "Isosceles");
/*            shape1.GetMeasurements();*/
            triangle1.GetMeasurements();
            triangle1.Style();
            Console.WriteLine(triangle1.Area());
            #endregion

            #region 1.2
            Console.WriteLine("\n\n---- DEL 1.2 ----");
            Console.WriteLine("(Denne del er tom da koden skulle udkommenteres som led i Del 2.2)");
/*            TwoDShape shape2 = new TwoDShape(4);
            TwoDShape shape3 = new TwoDShape(-5, 6);
            TwoDShape shape0 = new TwoDShape();
            shape2.GetMeasurements();
            shape3.GetMeasurements();
            shape0.GetMeasurements();*/
            #endregion

            #region 1.3
            Console.WriteLine("\n\n---- DEL 1.3 ----");
            Triangle triangle2 = new Triangle(7);
            Triangle triangle3 = new Triangle();
            triangle2.GetMeasurements();
            triangle2.Style();
            Console.WriteLine(triangle2.Area());
            triangle3.GetMeasurements();
            triangle3.Style();
            Console.WriteLine(triangle3.Area());
            #endregion

            #region 1.4
            Console.WriteLine("\n\n---- DEL 1.4 ----");
            ColorTriangle triangleC = new ColorTriangle("Grøn");
            triangleC.GetMeasurements();
            Console.WriteLine(triangleC.Area());
            triangleC.Style();
            triangleC.DisplayColor();
            #endregion

            #region 2.1
            Console.WriteLine("\n\n\n\n##### DEL 2 ######");
            Rectangle rect1 = new Rectangle(5, 2);
            Console.WriteLine(rect1.Area());
            Console.WriteLine(rect1.IsSquare());
            #endregion

            #region 2.3
            List<Rectangle> listRect = new List<Rectangle>();
            List<Triangle> listTri = new List<Triangle>();

            listRect.Add(new Rectangle(5, 4));
            listRect.Add(new Rectangle(2,2));
            listTri.Add(new Triangle());
            listTri.Add(new Triangle(6));
            listTri.Add(new Triangle(3, 3, "Equilateral"));

            foreach (Rectangle rect in listRect)
                rect.GetObjects();
            foreach (Triangle tri in listTri)
                tri.GetObjects();

            #endregion
        }
    }
}
