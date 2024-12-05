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
    public partial class frmListaDoble : Form
    {

        ListaDoble miListaD = new ListaDoble();

        public frmListaDoble()
        {
            InitializeComponent();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            int dato;
            int posicion;
            if (int.TryParse(txtVALOR.Text, out dato) && int.TryParse(txtPOSICION.Text, out posicion))
            {
                miListaD.Insetar(posicion, dato);

                MessageBox.Show($"Se agrego {dato} en la posicion {posicion}.", "Se agrego un Dato", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtVALOR.Clear();
                txtPOSICION.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese el dato y posición valida.", "Dato y posicion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            lstLISTAdoble.Items.Clear();
            NodoDoble actual = miListaD.Inicio;
            while (actual != null)
            {
                lstLISTAdoble.Items.Add(actual.Dato);
                actual = actual.Siguiente;
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(txtPOSICION.Text, out posicion))
            {
                miListaD.Eliminar(posicion);
                txtPOSICION.Text = "";
                txtPOSICION.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una posicion valida...", "Posicion no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVACIAR_Click(object sender, EventArgs e)
        {
            miListaD.Vaciar();
        }
    }
}
