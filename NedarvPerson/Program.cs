using System;
using System.Collections.Generic;

namespace NedarvPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> listPerson = new List<Person>();

/*            Person personTest = new Person("Anders", "21");*/ // Person. Kan ikke længere istantieres da klassen er gjort abstract
            Elev elevTest = new Elev(1, "Kasper", "22"); // Elev -> Person -> Elev.

            
            elevTest.PrintPerson();
            listPerson.Add(elevTest);
            listPerson.Add(new Elev(3, "Jesper", "33"));
/*            listPerson.Add(new Person("Jonathan", "26"));*/ // Kan ikke længere istantieres da klassen er gjort abstract

            PrintList(listPerson);

            listPerson.Add(new Results(13, 4, "Kim", "35")); // Jeg ved ikke lige lavede alder til en streng - tanketorsk, formentlig.
            PrintList(listPerson);
        }

        public static void PrintList(List<Person> listPerson)
        {
            Console.WriteLine("Class Roster:");
            foreach (Person person in listPerson)
            {
                person.PrintPerson();
            }
        }
    }
}
