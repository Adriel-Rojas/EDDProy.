using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class CalculoExp
    {
        public long CalcularExponente(int baseNumero, int exponente)
        {
            if (exponente == 0) // Caso base, exponente es 0, retorna
                return 1;

            return baseNumero * CalcularExponente(baseNumero, exponente - 1); // Llamada recursiva
        }
    }
}
