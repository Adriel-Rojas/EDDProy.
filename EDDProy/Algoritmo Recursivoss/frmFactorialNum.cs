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

namespace EDDemo.Algoritmo_Recursivoss
{
    public partial class frmFactorialNum : Form
    {
        public frmFactorialNum()
        {
            InitializeComponent();
        }

        private long Factorial(int n)
        {
            if (n == 0 || n == 1)//Caso base, si n es igual a 0 o n es igual a 1
            {
                return 1; //Retornara a 1 y termina el programa
            }
            else//Pero si no se cumple lo anterior
            {
                return n * Factorial(n - 1);//Llamada recursiva, n por el resultado del factorial n-1
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;

            if (int.TryParse(txtNumero.Text, out numero) && numero >= 0)
            {
                Stopwatch stopwatch = new Stopwatch(); // Para medir el tiempo de ejecucion
                stopwatch.Start();

                FactorialNum calculadora = new FactorialNum();

                long resultado = calculadora.CalcularFactorial(numero);

                stopwatch.Stop();

                txtResultado.Text = resultado.ToString();
                txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
            }
            else
            {
                txtResultado.Text = "Ingrese un número válido.";
            }
        }
    }
}
