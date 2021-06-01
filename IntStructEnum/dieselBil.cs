using System;
using System.Collections.Generic;
using System.Text;

namespace IntStructEnum
{
    class DieselBil : iBil
    {
        public string Farve { get; set; }
        public int KM { get; }

        public DieselBil(string farve, int km)
        {
            Farve = farve;
            KM = km;
        }

        public void UdskrivBil()
        {
            Console.WriteLine("Type: Diesel");
        }
    }
}
