using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarVaskehal
{
    public class Car
    {
        public string regNr, mærke, farve;
        public int id;
        public DateTime laant, leveret;
        static int idCounter = 0;
        public bool washed = true;

        public int ID { get; set; }
        public DateTime Laant { get; set; }
        public DateTime Leveret { get; set; }

        // Constructor
        public Car(string regNr, string mærke, string farve)
        {
            this.regNr = regNr;
            this.mærke = mærke;
            this.farve = farve;
            this.id = idCounter++;
        }

        /// <summary>
        /// Method for fetching the various fields of a Car object
        /// </summary>
        /// <returns></returns>
        public string HentBil()
        {
            return $"ID: [{id}], Registreringsnummer: {regNr}, Mærke: {mærke}, Farve: {farve}";
        }


    }
}
