using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma__Propiedades_
{
    internal class clsuma
    {
        // Propiedades, campos, etc.
        private int n1;
        private int n2;

        // Constructor.
        public clsuma()
        {

        }

        // Encapsulamiento de las propiedades.
        public int N1 { get => n1; set => n1 = value; }
        public int N2 { get => n2; set => n2 = value; }

        // Metodos.
        public int Suma()
        {
            return n1 + n2;
        }
    }
}
