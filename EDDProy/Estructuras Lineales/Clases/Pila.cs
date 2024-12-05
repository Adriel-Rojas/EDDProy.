using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Pila
    {
        private NodoPilas Top;

        public Pila()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            Top = null;
        }

        public void Push(int DATO)
        {
            NodoPilas nuevo = new NodoPilas(DATO);
            if (Top == null)
            {
                Top = nuevo;
            }
            else
            {
                NodoPilas aux = Top;
                Top = nuevo;
                Top.Siguiente = aux;
            }
        }

        public int? Pop()
        {
            if (Top == null)
            {
                MessageBox.Show("La pila esta vacia", "Pila Vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return -1;
            }
            else
            {
                NodoPilas aux = Top;
                Top = Top.Siguiente;
                int dato = aux.Dato;
                aux = null;
                return dato;
            }
        }

        public bool Vacio()
        {
            return Top == null;
        }

        public bool Buscar(int dato)
        {
            NodoPilas aux = Top;
            while (aux != null)
            {
                if (aux.Dato == dato)
                {
                    return true;//Enscontrado
                }
                aux = aux.Siguiente;
            }
            return false;//No encontrado
        }

        public void Limpiar()
        {
            while (Top != null)
            {
                Pop();
            }
        }

        public List<int> Recorrer()
        {
            List<int> elementos = new List<int>();
            NodoPilas aux = Top;
            while (aux != null)
            {
                elementos.Add(aux.Dato);
                aux = aux.Siguiente;
            }
            return elementos;
        }
    }
}
