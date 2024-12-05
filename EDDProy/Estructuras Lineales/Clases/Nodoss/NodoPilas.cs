using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class NodoPilas
    {
        public int Dato;
        public NodoPilas Siguiente;

        public NodoPilas(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
