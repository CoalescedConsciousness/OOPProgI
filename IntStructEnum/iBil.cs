using System;
using System.Collections.Generic;
using System.Text;

namespace IntStructEnum
{
    interface iBil
    {
        string Farve { get; set; }
        int KM { get; }

        void UdskrivBil();
    }
}
