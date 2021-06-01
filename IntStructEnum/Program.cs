using System;

namespace IntStructEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            DieselBil bil1 = new DieselBil("Sort", 1000);
            BenzinBil bil2 = new BenzinBil("Hvid", 2222);

            bil1.UdskrivBil();
            bil2.UdskrivBil();

            Bil bil3 = new Bil("Grå", 3333, 4444);
            bil3.PrintBil();
            Bil bil4;
            bil4.farve = "Hest"; bil4.km = 1234; bil4.hk = 4321;
            bil4.PrintBil();

            Bil bil5 = bil3;
            bil5.farve = "Purpur";
            bil5.PrintBil();
            bil3.PrintBil();

            Enumeration.PrintFarve();
        }


        public void PrintBil(Bil bil) // Oprettes her da den ikke kan være i en Struct
        {
            Console.WriteLine($"{bil.farve}, {bil.km}, {bil.hk}");
        }
    }
}
