using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class SumarArreglo
    {
        public int SumArreglo(int[] arreglo, int indice)
        {
            if (indice >= arreglo.Length) // Caso base
                return 0;

            return arreglo[indice] + SumArreglo(arreglo, indice + 1);// Caso recursivo
        }
    }
}
