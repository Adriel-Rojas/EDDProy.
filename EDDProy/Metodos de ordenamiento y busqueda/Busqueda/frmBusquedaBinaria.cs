using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda
{
    public partial class frmBusquedaBinaria : Form
    {

        private BusquedaBinaria BusquedaBinaria;

        public frmBusquedaBinaria()
        {
            InitializeComponent();
            BusquedaBinaria = new BusquedaBinaria();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int clave))
            {
                if (lstResultado.Items.Count < 10)
                {
                    BusquedaBinaria.AgregarElemento(clave);

                    lstResultado.Items.Clear();
                    foreach (var item in BusquedaBinaria.ObtenerVector())
                    {
                        if (item != 0)
                        {
                            lstResultado.Items.Add(item);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ya se han ingresado 10 elementos","Maximo numero de elemntos",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                txtNumero.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un numero valido","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            txtNumero.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtNumero.Text);
                int posicion = BusquedaBinaria.BusquedaRecursiva(0, BusquedaBinaria.ObtenerVector().Length - 1, num);

                if (posicion == -1)
                {
                    MessageBox.Show($"El elemento {num} no esta en el arreglo.", "Elemento no encontrado",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"El elemento {num} esta en la posicion: {posicion + 1}.", "Elemenoto encontrado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingrese un numero valido.", "Numero invalido",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtNumero.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
