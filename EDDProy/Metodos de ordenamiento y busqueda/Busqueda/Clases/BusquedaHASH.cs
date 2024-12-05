using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases
{
    public class BusquedaHASH
    {
        private const int TAMANIO = 100;
        private int[] claves;
        private string[] valores;

        public BusquedaHASH()
        {
            claves = new int[TAMANIO];
            valores = new string[TAMANIO];
            for (int i = 0; i < TAMANIO; i++)
            {
                claves[i] = -1;
            }
        }

        private int FuncionHash(int clave)
        {
            return clave % TAMANIO;
        }

        public void Insertar(int clave, string valor)
        {
            int indice = FuncionHash(clave);
            InsertarRecursivo(clave, valor, indice);
        }

        private void InsertarRecursivo(int clave, string valor, int indice)
        {
            if (claves[indice] == -1) // Espacio vacío encontrado
            {
                claves[indice] = clave;
                valores[indice] = valor;
                return;
            }

            // Resolver colisión (lineal)
            indice = (indice + 1) % TAMANIO;
            InsertarRecursivo(clave, valor, indice);
        }

        public string Buscar(int clave)
        {
            int indice = FuncionHash(clave);
            return BuscarRecursivo(clave, indice, indice);
        }

        private string BuscarRecursivo(int clave, int indice, int inicio)
        {
            if (claves[indice] == -1)
                return null;

            if (claves[indice] == clave)
                return valores[indice];

            indice = (indice + 1) % TAMANIO;

            if (indice == inicio)
                return null;

            return BuscarRecursivo(clave, indice, inicio);
        }
    }
}
