using EDDemo.Estructuras_Lineales.Clases.Nodoss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaDoble
    {
        public NodoDoble Inicio;
        public NodoDoble Fin;

        public ListaDoble()
        {

            Inicio = null;
            Fin = null;
        }


        public void Insetar(int Posicion, int DATO)
        {


            NodoDoble nuevo = new NodoDoble(DATO);


            if (Inicio == null && Fin == null)
            {
                Inicio = nuevo;
                Fin = nuevo;
                return;
            }

            if (Posicion == 0 || Posicion == 1)
            {
                nuevo.Siguiente = Inicio;
                if (Inicio != null)
                {
                    Inicio.Anterior = nuevo;
                }
                Inicio = nuevo;
                return;
            }


            int Pos = 1;
            NodoDoble Aux = Inicio;
            NodoDoble previo = null;


            while (Pos < Posicion && Aux != null)
            {
                previo = Aux;
                Aux = Aux.Siguiente;
                Pos++;
            }

            if (Aux != null)
            {
                nuevo.Siguiente = Aux;
                nuevo.Anterior = previo;
                previo.Siguiente = nuevo;
                Aux.Anterior = nuevo;
            }

            else
            {
                Fin.Siguiente = nuevo;
                nuevo.Anterior = Fin;
                Fin = nuevo;
            }

        }

        public int Eliminar(int posicion)
        {
            if (Inicio == null && Fin == null)
            {
                MessageBox.Show("La lista esta vacia", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;//No se pudo eliminar nada
            }

            else
            {
                int pos = 1;
                NodoDoble Aux = Inicio;
                NodoDoble Previo = null;

                while (pos < posicion && Aux != null)
                {
                    if (Aux.Siguiente != null)
                    {
                        Previo = Aux;
                        Aux = Aux.Siguiente;
                    }
                    else
                    {
                        Aux = null;
                    }
                    pos++;
                }

                if (Aux != null)
                {
                    int valorEliminado = Aux.Dato;
                    if (Aux == Fin)
                    {
                        Fin = Previo;

                        if (Previo != null)
                        {
                            Previo.Siguiente = null;
                        }
                        else
                        {
                            Inicio = Fin = null;
                        }
                    }
                    else
                    {
                        if (Previo != null)
                        {
                            Previo.Siguiente = Aux.Siguiente;
                        }
                        else
                        {
                            Inicio = Aux.Siguiente;
                        }
                    }

                    MessageBox.Show($"El valor {valorEliminado} fue eliminado", "Dato Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return valorEliminado;
                }

                else
                {
                    MessageBox.Show("El valor no fue encontrado...", "Dato No Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
        }

        public void Vaciar()
        {
            Inicio = null;
            Fin = null;

            MessageBox.Show("La lista se limpio", "Lista vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
