using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases.Nodoss
{
    internal class ListCircSimple
    {
        public NodoListCircSimple Inicio;
        public NodoListCircSimple Fin;

            public ListCircSimple ()
        {
            Inicio = null;
            Fin = null;
        }

        public void Insertar(int posicion, int DATO)
        {
            NodoListCircSimple nuevo = new NodoListCircSimple(DATO);
            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                Fin.Siguiente = Inicio;
                return;
            }


            if (posicion == 0 || posicion == 1)
            {
                nuevo.Siguiente = Inicio;
                Fin.Siguiente = nuevo;
                Inicio = nuevo;
                return;
            }


            int pos = 1;
            NodoListCircSimple Aux = Inicio;
            NodoListCircSimple previo = null;

            while (pos < posicion && Aux.Siguiente != Inicio)
            {
                previo = Aux;
                Aux = Aux.Siguiente;
                pos++;
            }

            nuevo.Siguiente = Aux;
            if (previo != null)
            {
                previo.Siguiente = nuevo;
            }
            if (Aux == Inicio)
            {
                Fin = nuevo;
            }

        }


        public int Eliminar(int posicion)
        {
            if (Inicio == null && Fin == null)
            {
                MessageBox.Show("La lista esta vacia", "Lista vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

            int pos = 1;
            NodoListCircSimple aux = Inicio;
            NodoListCircSimple previo = null;


            while (pos < posicion && aux.Siguiente != Inicio)
            {
                previo = aux;
                aux = aux.Siguiente;
                pos++;
            }

            if (aux != null)
            {
                if (aux == Inicio)
                {
                    Inicio = aux.Siguiente;
                    Fin.Siguiente = Inicio;
                }
                else
                {
                    previo.Siguiente = aux.Siguiente;
                    if (aux == Fin)
                    {
                        Fin = previo;
                    }
                }
                return aux.Dato;
            }
            MessageBox.Show("Posicion no encontrada");
            return 0;
        }



        public void Vaciar()
        {
            Inicio = null;
            Fin = null;

            MessageBox.Show("La lista se limpio", "Lista vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
