using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmColas : Form
    {
        Cola miCola = new Cola();

        public frmColas()
        {
            InitializeComponent();
        }

        private void btnPUSH_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDATO.Text, out int DATO))
            {
                miCola.Queue(DATO);
                lblCOLA.Text = DATO.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Se agrego incorrectamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDATO.Clear();
            txtDATO.Focus();
        }

        private void btnQueue_Click(object sender, EventArgs e)
        {
            int? valor = miCola.DeQueue();
            if (valor != null)
            {
                lblCOLA.Text = valor.ToString();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDATO.Text, out int dato))
            {
                if (miCola.Buscar(dato))
                {
                    lblCOLA.Text = $"El valor {dato} se encuentra en la cola";
                }
                else
                {
                    lblCOLA.Text = $"El valor {dato} no se encuentra en la cola";
                }
            }
            else
            {
                lblCOLA.Text = "Ingrese un numero valido";
            }
        }

        private void btnVACIAR_Click(object sender, EventArgs e)
        {
            if (miCola.Vacio())
            {
                lblCOLA.Text = "La cola esta vacia";
            }
            else
            {
                lblCOLA.Text = "La cola no esta vacia";
            }
        }

        private void btnINICIALIZAR_Click(object sender, EventArgs e)
        {
            miCola.Inicializar();
            lblCOLA.Text = "La cola se inicializo";
        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            miCola.Limpiar();
            lblCOLA.Text = "La cola se limpio";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> datos = miCola.Recorrer();
            if (datos.Count == 0)
            {
                MessageBox.Show("La cola esta vacia", "Cola vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblCOLA.Text = string.Join(", ", datos);
            }
        }
    }
}
