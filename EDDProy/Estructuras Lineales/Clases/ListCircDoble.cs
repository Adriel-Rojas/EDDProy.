using EDDemo.Estructuras_Lineales.Clases.Nodoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListCircDoble
    {
        public NodoCircDoble Inicio;
        public NodoCircDoble Fin;

        public void insertar(int Posicion, int DATO)
        {
            NodoCircDoble nuevo = new NodoCircDoble(DATO);

            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
            }
            else if (Posicion == 0 || Posicion == 1)
            {
                nuevo.Siguiente = Inicio;
                nuevo.Prev = Fin;
                Inicio.Prev = nuevo;
                Fin.Siguiente = nuevo;
                Inicio = nuevo;
            }
            else
            {
                int pos = 1;
                NodoCircDoble aux = Inicio;
                while (pos < Posicion - 1 && aux.Siguiente != Inicio)
                {
                    aux = aux.Siguiente;
                    pos++;
                }
                nuevo.Siguiente = aux.Siguiente;
                nuevo.Prev = aux;
                if (aux.Siguiente != Inicio)
                    aux.Siguiente.Prev = nuevo;

                aux.Siguiente = nuevo;

                if (nuevo.Siguiente == Inicio)
                    Fin = nuevo;
            }
        }

        public int Eliminar(int Posicion)
        {
            if (Inicio == null && Fin == null)
            {
                MessageBox.Show("La lista esta vacia", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
            NodoCircDoble aux = Inicio;
            int pos = 1;

            while (pos < Posicion && aux.Siguiente != Inicio)
            {
                aux = aux.Siguiente;
                pos++;
            }
            if (aux != null && pos == Posicion)
            {
                if (aux == Inicio)
                {
                    if (Inicio == Fin)
                    {
                        Inicio = null;
                        Fin = null;
                    }
                    else
                    {
                        Inicio = Inicio.Siguiente;
                        Inicio.Prev = Fin;
                        Fin.Siguiente = Inicio;
                    }
                }
                else if (aux == Fin)
                {
                    Fin = Fin.Prev;
                    Fin.Siguiente = Inicio;
                    Inicio.Prev = Fin;
                }
                else
                {
                    aux.Prev.Siguiente = aux.Siguiente;
                    aux.Siguiente.Prev = aux.Prev;
                }
                int dato = aux.Dato;
                aux = null;
                return dato;
            }
            else
            {
                MessageBox.Show("La posicion no fue encontrada", "Posicion no encontrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

        public void Vacio()
        {
            Inicio = null;
            Fin = null;

            MessageBox.Show("La lista se limpio", "Lista vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
