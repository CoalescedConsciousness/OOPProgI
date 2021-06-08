using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{
    public class Customer : Person, ICRUD
    {
        public double debt;
        public Car rent;
        public int id;
        static int idCounter = 0;

        /// <summary>
        /// *C*RUD for Customer classes.
        /// </summary>
        /// <param name="debt"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="height"></param>
        public Customer(string name, int age, int height) : base(name, age, height)
        {
            this.debt = 0;
            this.id = idCounter++;
        }

        /// <summary>
        /// Method for fetching the various fields of a Customer object
        /// </summary>
        /// <returns></returns>
        public string[] GetCustomer()
        {
            string[] result = new string[] { id.ToString(), name, age.ToString(), height.ToString(), debt.ToString() };
            return result;
        }

        /// <summary>
        /// Override for Car objects: "ID: id, Navn: name, Alder: age, Højde: height, Skyld: debt (in kr)"
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"ID: [{id}], Navn: {name}, Alder: {age}, Højde: {height}, Skylder: {debt:C2}";
        }

        /// <summary>
        /// Interface supplied *C*RUD method, primarily for backend use, as there is already a frontend method for this.
        /// </summary>
        /// <see cref="RentACar.AddCust"/>
        public void Create() // To get this to work, we had to make the cust List public and static.
                             // The crucial flaw here is that all data is stored within RentACar, thus making it that much harder to access
        {
            Console.WriteLine("Full name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Age:");
            int pAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            int pHeight = int.Parse(Console.ReadLine());

            RentACar.cust.Add(new Customer(fName, pAge, pHeight));
        }

        /// <summary>
        /// Interface supplied CR*U*D method, primarily for backend use, as there is already a frontend method for this.
        /// </summary>
        /// <see cref="RentACar.UpdCust"/>
        public void Update()
        {
            Program.myRentACar.UpdCust();
        }

        /// <summary>
        /// Interface supplied CRU*D* method, primarily for backend use, as there is already a frontend method for this.
        /// </summary>
        /// <see cref="RentACar.RmCust"/>
        public void Delete()
        {
            Console.WriteLine("Please supply the ID of the customer you wish to delete");
            RentACar.RmCust(int.Parse(Console.ReadLine()));
        }

    }
}
