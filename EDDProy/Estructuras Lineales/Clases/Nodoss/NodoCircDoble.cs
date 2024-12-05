using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases.Nodoss
{
    internal class NodoCircDoble
    {
        public int Dato;
        public NodoCircDoble Siguiente;
        public NodoCircDoble Prev;

        public NodoCircDoble(int dato)
        {
            Dato = dato;
            Siguiente = this;
            Prev = this;
        }
    }
}
