using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento.Clases
{
    internal class QuickSort
    {
        private int[] vector;

        public QuickSort(int[] vector)
        {
            this.vector = vector;
        }

        public int[] Ordenar()
        {
            Quicksort(vector, 0, vector.Length - 1);
            return vector;
        }

        private void Quicksort(int[] vector, int primero, int ultimo)// Metodo
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = vector[central];
            i = primero;
            j = ultimo;
            do
            {
                while (vector[i] < pivote) i++;
                while (vector[j] > pivote) j--;
                if (i <= j)
                {
                    int temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
                Quicksort(vector, primero, j);
            if (i < ultimo)
                Quicksort(vector, i, ultimo);
        }
    }
}
