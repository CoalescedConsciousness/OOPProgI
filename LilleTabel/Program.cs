using System;

namespace LilleTabel
{
    class Program
    {
        static void Main(string[] args)
        {

            
            BuildTabel(int.Parse(Console.ReadLine()) + 1);


            void BuildTabel(int size)
            {

                int[,] rows = new int[size, size];
                for (int i = 1; i < size; i++)
                {
                    for (int j = 1; j < size; j++)
                    {
                        rows[i, j] = i * j;
                        Console.Write(rows[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
