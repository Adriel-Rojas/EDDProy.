using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases
{
    public class BusquedaBinaria
    {
        private int[] vector;

        public BusquedaBinaria()
        {
            vector = new int[10]; // Tamaño fijo de 10 elementos
        }

        // Método para cargar los datos en el arreglo
        public void AgregarElemento(int num)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 0) // Buscar un espacio vacío en el arreglo
                {
                    vector[i] = num;
                    break;
                }
            }
            // Ordenar el arreglo después de cada inserción para garantizar que la búsqueda binaria funcione correctamente
            Array.Sort(vector);
        }

        // Método recursivo de búsqueda binaria
        public int BusquedaRecursiva(int l, int h, int num)
        {
            if (l > h)
            {
                return -1; // Elemento no encontrado
            }

            int m = (l + h) / 2;
            if (vector[m] == num)
            {
                return m; // Elemento encontrado
            }
            else if (vector[m] > num)
            {
                return BusquedaRecursiva(l, m - 1, num); // Buscar en la mitad izquierda
            }
            else
            {
                return BusquedaRecursiva(m + 1, h, num); // Buscar en la mitad derecha
            }
        }

        // Getter para el vector (en caso de ser necesario en el formulario)
        public int[] ObtenerVector()
        {
            return vector;
        }
    }
}
