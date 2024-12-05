using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class FactorialNum
    {
        public long CalcularFactorial(int n)
        {
            if (n == 0 || n == 1) // Caso base, n es igual a 0 o n es igual retorna
                return 1;

            return n * CalcularFactorial(n - 1); // Llamada recursiva
        }
    }
}
