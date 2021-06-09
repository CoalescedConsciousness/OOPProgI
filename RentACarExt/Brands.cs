using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{
    public struct Brands : ICRUD // Primarily an example of a structure that sort of makes sense, as you could view Brands as super-simplistic objects. 
                                 // Note however that this isn't implemented anywhere in the code.
    {
        public string bName { get; set; }



        public Brands(string name)
        {
            bName = name;
        }

        // Note that these CRUD methods are primarily there for backend use, as we do not wish the end-user to be able to add new brands willy-nilly.
        public void Create()
        {
            Console.WriteLine("Brand name:");
            Program.myRentACar.brands.Add(new Brands(Console.ReadLine()));
        }

        public void Delete()
        {
            Console.WriteLine("Brand name to delete:");
            Program.myRentACar.brands.RemoveAt(Program.myRentACar.brands.FindIndex(x => x.bName == Console.ReadLine()));
        }

        public void Update()
        {
            Console.WriteLine("Brand name to alter:");
            int index = Program.myRentACar.brands.FindIndex(x => x.bName == Console.ReadLine());
            Console.WriteLine("Enter new name:");
            Program.myRentACar.brands[index].bName.Replace(bName, Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Brand name: {bName}";
        }
    }
}
