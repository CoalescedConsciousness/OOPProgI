using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

delegate int MyDelegate(int p, int q);

class Program
{
    static void Main()
    {
        MyDelegate arithMethod = Max;

        Console.WriteLine("Det største af tallene er: {0}", arithMethod(3, 7));
    }

    static int Max(int c, int d)
    {
        if (c > d)
            return c;
        else
            return d;
    }
}
