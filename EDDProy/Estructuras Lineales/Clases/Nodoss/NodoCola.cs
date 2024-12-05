using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class NodoCola
    {
        public int Dato;
        public NodoCola Siguiente;

        public NodoCola(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
