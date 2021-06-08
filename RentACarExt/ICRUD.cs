using System;
using System.Collections.Generic;
using System.Text;

namespace RentACarExt
{
    public interface ICRUD
    {
        void Create();
        string ToString(); // Read
        void Update();
        void Delete();


    }
}
