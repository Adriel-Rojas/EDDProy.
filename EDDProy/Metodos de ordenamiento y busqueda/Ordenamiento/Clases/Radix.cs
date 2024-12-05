using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento.Clases
{
    internal class Radix
    {
        private int[] arreglo;

        public Radix(int[] arreglo)
        {
            this.arreglo = arreglo;
        }

        public int[] Ordenar()
        {
            RadixSortAlgorithm(arreglo);
            return arreglo;
        }

        private void RadixSortAlgorithm(int[] arreglo)
        {
            int max = ObtenerMaximo(arreglo);

            for (int exp = 1; max / exp > 0; exp *= 10)//Conteo para cada valor
            {
                ContarYOrdenar(arreglo, exp);
            }
        }

        private int ObtenerMaximo(int[] arreglo)
        {
            int max = arreglo[0];
            foreach (var item in arreglo)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }

        private void ContarYOrdenar(int[] arreglo, int exp)
        {
            int n = arreglo.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Contar las ocurrencias de los dígitos
            for (int i = 0; i < n; i++)
                count[(arreglo[i] / exp) % 10]++;

            // Cambiar count para que contenga la posición real de este dígito en output
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Arreglo ordenado
            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(arreglo[i] / exp) % 10] - 1] = arreglo[i];
                count[(arreglo[i] / exp) % 10]--;
            }

            // Copiar los valores ordenados en el vector original
            for (int i = 0; i < n; i++)
                arreglo[i] = output[i];
        }
    }
}
