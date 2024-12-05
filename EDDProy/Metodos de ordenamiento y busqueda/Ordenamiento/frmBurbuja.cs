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
    public partial class frmBurbuja : Form
    {
        private Burbuja burbuja;
        public frmBurbuja()
        {
            InitializeComponent();
            burbuja = new Burbuja();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {

            string[] elementosStr = txtOrdenar.Text.Split(',');// Valores ingresados en el txbox

            int[] elementos = new int[elementosStr.Length];// Los numeros son enteros?
            for (int i = 0; i < elementosStr.Length; i++)
            {
                if (!int.TryParse(elementosStr[i], out elementos[i]))
                {
                    MessageBox.Show("Ingrese numeros validos","Numeros no validos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }
            burbuja.Cargar(elementos);// Cargar el vector en la clase Burbuja

            burbuja.OrdBurbuja(elementos.Length);// Se ejecuta el metodo burbuja

            lblResultado.Text="";// Resultadoes en el lbl
            int[] vectorOrdenado = burbuja.ObtenerVector();
            foreach (var item in vectorOrdenado)
            {
                lblResultado.Text += item + ", ";
            }
        }

    }
}
