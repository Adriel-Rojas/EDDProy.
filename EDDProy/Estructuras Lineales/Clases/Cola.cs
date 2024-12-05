using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales.Clases
{
    internal class Cola
    {
        private NodoCola Top;
        private NodoCola Ultimo;

        public Cola()
        {
            Inicializar();
        }

        public void Inicializar()
        {
            Top = null;
            Ultimo = null;
        }

        public void Queue(int DATO)
        {
            NodoCola nuevo = new NodoCola(DATO);
            if (Ultimo == null)
            {
                Top = nuevo;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                Ultimo = nuevo;
            }
        }

        public int? DeQueue()
        {
            if (Top == null && Ultimo == null)
            {
                MessageBox.Show("La cola esta vacia", "Cola Vacia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                NodoCola aux = Top;
                Top = aux.Siguiente;
                if (Top == null)
                    Ultimo = null;
                int dato = aux.Dato;
                aux = null;
                return dato;
            }
        }

        public bool Vacio()
        {
            return Top == null && Ultimo == null;
        }

        public bool Buscar(int dato)
        {
            NodoCola actual = Top;
            while (actual != null)
            {
                if (actual.Dato == dato)
                    return true;
                actual = actual.Siguiente;
            }
            return false;
        }

        public void Limpiar()
        {
            while (!Vacio())
            {
                DeQueue();
            }
        }

        public List<int> Recorrer()
        {
            List<int> datos = new List<int>();
            NodoCola aux = Top;
            while (aux != null)
            {
                datos.Add(aux.Dato);
                aux = aux.Siguiente;
            }
            return datos;
        }
    }
}
