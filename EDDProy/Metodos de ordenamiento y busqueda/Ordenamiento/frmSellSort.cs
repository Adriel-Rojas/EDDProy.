using EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento
{
    public partial class frmSellSort : Form
    {
        public frmSellSort()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer los valores del TextBox
                string input = txtOrdenar.Text; // Leer los valores del TextBox
                int[] vector = input.Split(',').Select(int.Parse).ToArray();

                SellSort shellSort = new SellSort(vector);
                int[] vectorOrdenado = shellSort.Ordenar(); // Ordenar el vector

                lblResultado.Text = string.Join(", ", vectorOrdenado);//Resultado
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese numeros validos", "Numeros no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
