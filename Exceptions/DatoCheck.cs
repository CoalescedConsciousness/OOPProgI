using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class DatoCheck
    {
        public static void CheckDato(string user)
        {
            DateTime.Parse(user);
        }

        public static void CheckTruth(string user)
        {
            Console.WriteLine(DateTime.Now.AddDays(-1).Date);
            Console.WriteLine(DateTime.Parse(user).Date);
            if (DateTime.Now.AddDays(-1).Date == DateTime.Parse(user).Date)
                Console.WriteLine("Correct");
            else
                Console.WriteLine("Incorrect");
        }
    }
}
