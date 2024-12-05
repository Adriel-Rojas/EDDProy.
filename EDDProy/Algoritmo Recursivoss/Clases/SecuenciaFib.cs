using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class SecuenciaFib
    {
        public long SecuenciaFibo(int n)
        {
            if (n == 0) // Caso base, F(0) = 0
                return 0;

            if (n == 1) // Caso base, F(1) = 1
                return 1;

            return SecuenciaFibo(n - 1) + SecuenciaFibo(n - 2);//Caso recursivo
        }
    }
}
