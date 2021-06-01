using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public delegate void MyDelegate(int p, int q);

class Program
{
    static void Main()
    {
        MyDelegate arithMethod = new MyDelegate(Max);
        arithMethod(3, 7);
    }

    static void Max(int c, int d)
    {
        if (c > d)
            Console.WriteLine($"Det største af tallene er: {c}");
        else
            Console.WriteLine($"Det største af tallene er: {d}");
    }
}
