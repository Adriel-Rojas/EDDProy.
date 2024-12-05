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
    public partial class frmQuickShort : Form
    {
        public frmQuickShort()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtOrdenar.Text;// Valores ingresados en txtbox
                int[] vector = input.Split(',').Select(int.Parse).ToArray();

                QuickSort quickSort = new QuickSort(vector);
                int[] vectorOrdenado = quickSort.Ordenar();

                lblResultado.Text = string.Join(", ", vectorOrdenado);//Resultado
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese numeros validos", "Numeros no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
