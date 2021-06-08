using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{
    // As there is no intention of having any link between Customers and (potentially) Employees, we make the parent class abstract, so it merely acts
    // as a template, without the possibility of instantiation an object of that template class.
    abstract public class Person
    {
        public string name;
        public int age, height;

        public Person(string name, int age, int height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

    
    }
}
