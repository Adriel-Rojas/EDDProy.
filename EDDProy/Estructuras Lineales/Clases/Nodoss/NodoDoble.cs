using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_Lineales.Clases.Nodoss
{
    internal class NodoDoble
    {
        public int Dato; //Valor del nodo
        public NodoDoble Siguiente; //Apuntdor al siguiente nodo
        public NodoDoble Anterior; //Apuntador al nodo anterior

        public NodoDoble(int dato)//Constructor
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}
