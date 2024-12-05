using EDDemo.Algoritmo_Recursivoss.Clases;
using EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmBusquedaBin : Form
    {
        public frmBusquedaBin()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] arregloOrd;
            int buscarVal;

            try
            {
                arregloOrd = txtArreglo.Text.Split(',').Select(n => int.Parse(n.Trim())).OrderBy(n => n).ToArray();// Para que el texto o valores este ordenado
            }
            catch
            {
                txtResultado.Text = "Ingrese una lista válida de números separados por comas.";
                return;
            }

            if (int.TryParse(txtBuscar.Text, out buscarVal))
            {
                BusquedaBin busqueda = new BusquedaBin();// Crear una instancia de la clase

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int indice = busqueda.BusquedaBinaria(arregloOrd, buscarVal, 0, arregloOrd.Length - 1);//Llamar metodo

                stopwatch.Stop();

                if (indice >= 0)
                {
                    txtResultado.Text = $"Valor encontrado en el índice: {indice}";
                }
                else
                {
                    txtResultado.Text = "Valor no encontrado.";
                }

                txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
            }
            else
            {
                txtResultado.Text = "Ingrese un valor válido para buscar.";
            }
        }
    }
}
