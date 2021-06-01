using System;
using System.Collections.Generic;
using System.Text;

namespace Bladkompagniet
{
    public class Person
    {
        public string Adresse { get; set; }
        public string By { get; set; }
        public string Navn { get; set; }
        public int Post { get; set; }

        public Person(string Adresse, string By, string Navn, int Post)
        {
            this.Adresse = Adresse;
            this.By = By;
            this.Navn = Navn;
            this.Post = Post;
        }
    }
}
