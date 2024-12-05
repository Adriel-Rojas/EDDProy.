using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Algoritmo_Recursivoss.Clases
{
    internal class TorreHanoi
    {
        public List<string> TorrHanoi(int n, char origen, char destino, char auxiliar)
        {
            List<string> movimientos = new List<string>();

            if (n == 1)// Caso base, solo hay un disco
            {
                movimientos.Add($"Mover disco 1 de {origen} a {destino}");
                return movimientos;
            }

            movimientos.AddRange(TorrHanoi(n - 1, origen, auxiliar, destino));// Mueve n-1 discos de la torre origen a la torre auxiliar


            movimientos.Add($"Mover disco {n} de {origen} a {destino}");// Mueve el disco n de origen a destino


            movimientos.AddRange(TorrHanoi(n - 1, auxiliar, destino, origen));// Mueve n-1 discos de la torre auxiliar a la torre destino

            return movimientos;
        }
    }
}
