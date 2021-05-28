using System;

namespace ConsoleApp1
{
    class Program
    {
        delegate void TestDel(string str);

        static void Main()
        {
            TestDel myTest = Met1;
            myTest += Met2;
            myTest += Met3;
            myTest -= Met1;

            myTest("Test");
        }
        static void Met1(string name)
        { Console.WriteLine(name); }
        static void Met2(string name)
        { Console.WriteLine(name.ToUpper()); }
        static void Met3(string name)
        { Console.WriteLine(name.ToLower()); }
    }
}
