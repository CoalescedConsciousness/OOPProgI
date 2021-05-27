using System;
using System.Collections.Generic;
using System.Text;

namespace Bog
{
    class Blad
    {
        public string magName;
        public int issue;
        public int pCount;

        public void GetMag()
        {
            Console.WriteLine("Magazine: \t\tIssue: \t\t Pages:");
            Console.WriteLine($"{magName} \t\t{issue} \t\t{pCount}");
        }

        public void GetMags(List<Blad> mags)
        {
            Console.WriteLine("Magazine: \t\tIssue: \t\t Pages:");
            foreach (Blad item in mags)
                Console.WriteLine($"{item.magName} \t\t{item.issue} \t\t{item.pCount}");
        }
    }
}
