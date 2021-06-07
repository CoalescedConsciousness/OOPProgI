using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{
    public class Customer : Person
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
        public string[] HentBil()
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


    }
}
