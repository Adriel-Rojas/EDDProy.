using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento
{
    internal class Burbuja
    {
        private int[] vector;

        public void OrdBurbuja(int n)
        {
            if (n == 1)// Caso base, si el numero es 1 o menor ya esta ordenado
                return;

            for (int i = 0; i < n - 1; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    // Para intercambiar los valores
                    int temp = vector[i];
                    vector[i] = vector[i + 1];
                    vector[i + 1] = temp;
                }
            }

            OrdBurbuja(n - 1);// Llamada recursiva con un tamaño reducido
        }

        // Metodo para cargar los elementos en el vector
        public void Cargar(int[] elementos)
        {
            vector = new int[elementos.Length];
            for (int i = 0; i < elementos.Length; i++)
            {
                vector[i] = elementos[i];
            }
        }

        public int[] ObtenerVector()// Para tener el vector ordenado
        {
            return vector;
        }
    }
}
