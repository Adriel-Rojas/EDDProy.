using EDDemo.Algoritmo_Recursivoss.Clases;
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
    public partial class frmSumarArreglo : Form
    {
        public frmSumarArreglo()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] numeros;

            try
            {
                numeros = txtArreglo.Text.Split(',').Select(n => int.Parse(n.Trim())).ToArray();//Convertir texto ingresado a numeros enteros
            }
            catch
            {
                txtResultado.Text = "Ingrese una lista válida de números separados por comas.";
                return;
            }

            Stopwatch stopwatch = new Stopwatch(); // Para medir el tiempo de ejecución
            stopwatch.Start();

            SumarArreglo calculadora = new SumarArreglo();

            int suma = calculadora.SumArreglo(numeros, 0);

            stopwatch.Stop();

            txtResultado.Text = $"Suma: {suma}";
            txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
        }

    }
}
