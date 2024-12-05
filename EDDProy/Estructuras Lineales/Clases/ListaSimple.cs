using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class ListaSimple
    {
        public Nodo Inicio;
        public Nodo Final;
        public Nodo BuscarFinal(Nodo unNodo)
        {
            if (unNodo.Siguiente == null)
            {
                return unNodo;
            }
            else
            {
                return BuscarFinal(unNodo.Siguiente);
            }
        }

        public void AGinicio(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = Inicio;
                Inicio = unNodo;
                Inicio.Siguiente = aux;

            }
        }
        public void Agfinal(Nodo unNodo)
        {
            if (Inicio == null)
            {
                Inicio = unNodo;
            }
            else
            {
                Nodo aux = BuscarFinal(Inicio);
                aux.Siguiente = unNodo;
            }
        }
        public int Eliminar(int posicion)
        {
            if (Inicio == null && Final == null)
            {
                MessageBox.Show("La lista esta vacia", "Lista Vacia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;//No se pudo eliminar nada
            }
            else
            {
                int pos = 1;
                Nodo Aux = Inicio;
                Nodo Previo = null;

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
                    int valorEliminado = Aux.Numero;
                    if (Aux == Final)
                    {
                        Final = Previo;

                        if (Previo != null)
                        {
                            Previo.Siguiente = null;
                        }
                        else
                        {
                            Inicio = Final = null;
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
            Final = null;

            MessageBox.Show("La lista se limpio", "Lista vaciada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
