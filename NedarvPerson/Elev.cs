using System;
using System.Collections.Generic;
using System.Text;

namespace NedarvPerson
{
    class Elev : Person
    {
        public int elevNr;

        public Elev(int elevNr, string navn, string alder) : base(navn, alder)
        {
            this.elevNr = elevNr;
        }

        public override void PrintPerson()
        {
            Console.WriteLine($"{navn}, {alder}, {elevNr}");
        }

    }
}
