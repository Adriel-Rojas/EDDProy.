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
    public partial class frmCalculoExp : Form
    {
        public frmCalculoExp()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numeroBase, exponente;

            if (int.TryParse(txtBase.Text, out numeroBase) && int.TryParse(txtExponente.Text, out exponente))//Entrada de valores
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                CalculoExp calculadora = new CalculoExp();// Crear una instancia

                long resultado = calculadora.CalcularExponente(numeroBase, exponente);// Calculo

                stopwatch.Stop();

                txtResultado.Text = resultado.ToString();// Resultados
                txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
            }
            else
            {
                txtResultado.Text = "Ingrese números válidos.";
            }
        }
    }
}
