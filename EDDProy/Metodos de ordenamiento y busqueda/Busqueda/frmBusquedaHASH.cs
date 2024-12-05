using EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Metodos_de_ordenamiento_y_busqueda
{
    public partial class frmBusquedaHASH : Form
    {
        private BusquedaHASH BusquedaHASH;


        public frmBusquedaHASH()
        {
            InitializeComponent();
            BusquedaHASH = new BusquedaHASH();
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                string[] lineas = File.ReadAllLines(rutaArchivo);
                foreach (string linea in lineas)
                {
                    string[] partes = linea.Split(',');
                    if (partes.Length == 2)
                    {
                        int clave = int.Parse(partes[0].Trim());
                        string valor = partes[1].Trim();
                        BusquedaHASH.Insertar(clave, valor);
                    }
                }
                MessageBox.Show("Los datos han sido cargados", "Datos cargados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            ltsResultado.Items.Clear();

            if (int.TryParse(txtClave.Text, out int clave) && !string.IsNullOrWhiteSpace(txtValor.Text))
            {
                BusquedaHASH.Insertar(clave, txtValor.Text);
                ltsResultado.Items.Add($"{clave}, {txtValor.Text}");

            }
            else
            {
                MessageBox.Show("Ingresa datos validos", "Datos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtClave.Focus();
            txtValor.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtClaveBuscar.Text, out int clave))
            {
                string resultado = BusquedaHASH.Buscar(clave);
                if (resultado != null)
                {
                    MessageBox.Show($"{clave} encontrada: {resultado}","Clave encontrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Clave {clave} no encontrada.","Clave no encontrada",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Ingresa una clave valida", "Clave invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtClaveBuscar.Focus();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
