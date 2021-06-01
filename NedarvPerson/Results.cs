using System;
using System.Collections.Generic;
using System.Text;

namespace NedarvPerson
{
    class Results : Elev
    {
        int result;

        public Results(int result, int elevNr, string navn, string alder) : base(elevNr, navn, alder)
        {
            this.result = result;
        }

        public override void PrintPerson()
        {
            Console.WriteLine($"{navn}, {alder}, {elevNr}, {result}");
        }

    }
}
