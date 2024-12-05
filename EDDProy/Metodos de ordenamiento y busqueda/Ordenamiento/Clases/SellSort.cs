using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento.Clases
{
    internal class SellSort
    {
        private int[] vector;

        public SellSort(int[] vector)
        {
            this.vector = vector;
        }

        // Método para ordenar usando Shell Sort
        public int[] Ordenar()
        {
            Shell(vector);
            return vector;
        }

        private void Shell(int[] vector)
        {
            int salto = vector.Length / 2;
            while (salto > 0)
            {
                bool intercambio = true;
                while (intercambio)
                {
                    intercambio = false;
                    for (int i = salto; i < vector.Length; i++)
                    {
                        if (vector[i - salto] > vector[i])
                        {
                            // Intercambiar
                            int temp = vector[i];
                            vector[i] = vector[i - salto];
                            vector[i - salto] = temp;
                            intercambio = true;
                        }
                    }
                }
                salto /= 2;
            }
        }
    }
}
