using System;
using System.Collections.Generic;
using System.Text;

namespace IntStructEnum
{
    struct Bil
    {
        public string farve;
        public int km;
        public int hk;

        public Bil(string farve, int km, int hk)
        {
            this.farve = farve;
            this.km = km;
            this.hk = hk;
        }

        public void PrintBil()
        { Console.WriteLine($"{farve}, {km}, {hk}"); }

    }
}
