using System;
using System.Collections.Generic;
using System.Text;

namespace Bog
{
    public class Bog
    {
        #region Fields
        string titel;
        string author;
        readonly string Isbn; 
        List<Bog> books = new List<Bog>();
        #endregion

        #region Constructor
        public Bog(string titel, string author, string Isbn)
        {
            this.titel = titel;
            this.author = author;
            this.Isbn = Isbn;
        }
        #endregion

        #region Properties
        public List<Bog> Books
        {
            get
            {
                foreach (Bog book in books) ////// HER TIL
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }
            set
            {
                titel = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string ISBN
        {
            get
            {
                return Isbn;
            }
        }

        #endregion
    }

   
}
