using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases.Nodoss
{
    internal class NodoListCircSimple
    {
        public int Dato;
        public NodoListCircSimple Siguiente;

        public NodoListCircSimple(int dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
