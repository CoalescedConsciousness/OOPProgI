using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RentACarExt
{
    public enum Farve
    {
        Grøn,
        Blå,
        Rød,
        Metalgrøn,
        Metalblå,
        Metalrød,
    }
    public class Car
    {
        public string regNr, mærke;
        public int id, custId;
        public DateTime laant, leveret, deadline;
        static int idCounter = 0;
        public bool washed = true;
        public Farve farve = new Farve();

        public int ID { get; set; }
        public DateTime Laant { get; set; }
        public DateTime Leveret { get; set; }

        // Constructor
        public Car(string regNr, string mærke, string farve)
        {
            this.regNr = regNr;
            this.mærke = mærke;
            this.farve = (Farve)Enum.Parse(typeof(Farve), farve); // Use of enumeration so color-options are, effectively, predetermined.
            this.id = idCounter++;
        }

        // Default Constructor
        public Car() { }

        /// <summary>
        /// Method for fetching the various fields of a Car object
        /// </summary>
        /// <returns></returns>
        public string[] HentBil()
        {
            string[] result = new string[] { id.ToString(), regNr, mærke, farve.ToString() };
            return result;
            
            /*return $"ID: [{id}], Registreringsnummer: {regNr}, Mærke: {mærke}, Farve: {farve}";*/ // Deprecated, moved to override of ToString method for Car objects.
        }

        /// <summary>
        /// Override for Car objects: "ID: [{id}], Registreringsnummer: {regNr}, Mærke: {mærke}, Farve: {farve}"
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"ID: [{id}], Registreringsnummer: {regNr}, Mærke: {mærke}, Farve: {farve}";
        }

    }
}
