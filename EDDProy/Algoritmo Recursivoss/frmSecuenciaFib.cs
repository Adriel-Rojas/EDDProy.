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
    public partial class frmSecuenciaFib : Form
    {
        public frmSecuenciaFib()
        {
            InitializeComponent();
        }

        private long Fibonacci(int n)
        {
            if (n == 0)//Caso base, si el numero ingresado es 0 el resultado sera 0
            {
                return 0;// Retorna
            }
            else if (n == 1)//Caso base, si el numero ingresado es 1 el resultado sera 1
            {
                return 1;// Retorna
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);//Caso recursivo
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int indice;

            if (int.TryParse(txtIndice.Text, out indice) && indice >= 0)
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                SecuenciaFib calculadora = new SecuenciaFib();

                long resultado = calculadora.SecuenciaFibo(indice);

                stopwatch.Stop();

                txtResultado.Text = $"Índice {indice}: Secuencia {resultado}";
                txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
            }
            else
            {
                txtResultado.Text = "Ingrese un número válido no negativo.";
            }
        }
    }
}
