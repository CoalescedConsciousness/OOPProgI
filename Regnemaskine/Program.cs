using System;

delegate int Udregn(int x, int y);
namespace Regnemaskine
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int talEt = 5;
            int talTo = 3;

            Console.WriteLine("Angiv udregningsmetode:");
            Console.WriteLine("[1] Adder");
            Console.WriteLine("[2] Subtrakter");

            switch (Console.ReadLine())
            { 
                case "1":
                    {
                        Udregn addEt = new Udregn(Add);

                        int result = addEt(talEt, talTo);
                        Console.WriteLine(result);
                        break;
                    }
                case "2":
                    {
                        Udregn subEt = new Udregn(Sub);
                        Console.WriteLine(subEt(talEt, talTo));
                        break;
                    }
                default:
                    Console.WriteLine("Ugyldigt Valg");
                    break;
            }
            

            

            static int Add(int x, int y)
            {
                return x + y;
            }

            static int Sub(int x, int y)
            {
                return x - y;
            }

        }
        
    }
    
}
