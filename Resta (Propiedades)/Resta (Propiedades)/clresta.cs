using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resta__Propiedades_
{
    internal class clresta
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor.
        public clresta()
        {

        }

        // Encapsulamiento de las propiedades.
        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        // Metodos.
        public int Resta()
        {
            return n1 - n2;
        }
    }
}
