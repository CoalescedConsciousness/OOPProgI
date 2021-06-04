using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    class Car
    {
        public string regNr, mærke, farve;
        public int id;

        static int idCounter = 0;

        public int ID { get; set; }

        // Constructor
        public Car(string regNr, string mærke, string farve)
        {
            this.regNr = regNr;
            this.mærke = mærke;
            this.farve = farve;
            this.id = idCounter++;
        }

        public string HentBil()
        {
            return $"ID: [{id}], Registreringsnummer: {regNr}, Mærke: {mærke}, Farve: {farve}";
        }


    }
}
