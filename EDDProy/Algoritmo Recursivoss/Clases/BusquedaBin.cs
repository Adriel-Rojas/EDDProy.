using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class BusquedaBin
    {
        public int BusquedaBinaria(int[] arreglo, int objetivo, int izquierda, int derecha)
        {
            if (izquierda > derecha) // Caso base, no encontrado
                return -1;

            int medio = izquierda + (derecha - izquierda) / 2;

            if (arreglo[medio] == objetivo) // Caso base, encontrado
                return medio;

            if (arreglo[medio] > objetivo) // Buscar en la mitad izquierda
                return BusquedaBinaria(arreglo, objetivo, izquierda, medio - 1);

            return BusquedaBinaria(arreglo, objetivo, medio + 1, derecha);// Buscar en la mitad derecha
        }
    }
}
