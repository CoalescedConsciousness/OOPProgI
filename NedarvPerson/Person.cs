using System;
using System.Collections.Generic;
using System.Text;

namespace NedarvPerson
{
    abstract class Person
    {
        public string navn;
        public string alder;

        public Person(string navn, string alder)
        {
            this.navn = navn;
            this.alder = alder;
        }

        public abstract void PrintPerson();
    }
}
