using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_Lineales.Clases.Nodoss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmCircDoble : Form
    {

        ListCircDoble miListCircDoble = new ListCircDoble();

        public frmCircDoble()
        {
            InitializeComponent();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVALOR.Text, out int DATO))
            {
                if (int.TryParse(txtPOSICION.Text, out int posicion))
                {
                    miListCircDoble.insertar(posicion, DATO);
                    lblRESULTADO.Text = "Valor insertado: " + DATO.ToString();
                    btnMOSTRAR_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido", "Valor invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtVALOR.Clear();
            txtPOSICION.Clear();
            txtVALOR.Focus();
        }

        private void btnQUITAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPOSICION.Text, out int posicion))
            {
                int eliminado = miListCircDoble.Eliminar(posicion);
                if (eliminado != 1)
                {
                    lblRESULTADO.Text = "Valor eliminado: " + eliminado.ToString();
                    btnMOSTRAR_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una posicion valida", "Posicion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            lstLISTCircDoble.Items.Clear();
            if (miListCircDoble.Inicio == null)
            {
                lstLISTCircDoble.Items.Add("La lista esta vacia");
                return;
            }
            NodoCircDoble actual = miListCircDoble.Inicio;
            do
            {
                lstLISTCircDoble.Items.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            while (actual != miListCircDoble.Inicio);
        }

        private void btnVACIAR_Click(object sender, EventArgs e)
        {
            miListCircDoble.Vacio();
            lblRESULTADO.Text = "La lista se vacio";
            lstLISTCircDoble.Items.Clear();
        }
    }
}
