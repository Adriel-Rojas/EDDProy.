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
    public partial class frmListCircSimple : Form
    {

        ListCircSimple miListaCirc = new ListCircSimple();

        public frmListCircSimple()
        {
            InitializeComponent();
        }

        private void btnAGREGAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtVALOR.Text, out int DATO))
            {
                if (int.TryParse(txtPOSICION.Text, out int posicion))
                    miListaCirc.Insertar(posicion, DATO);
                lblLISTAcirc.Text = DATO.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Se agrego incorrectamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtVALOR.Clear();
            txtPOSICION.Clear();
            txtVALOR.Focus();
        }

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            lstLISTAcirc.Items.Clear();
            if (miListaCirc.Inicio == null)
            {
                lstLISTAcirc.Items.Add("La lista es vacia");
                return;
            }
            NodoListCircSimple actual = miListaCirc.Inicio;
            do
            {
                lstLISTAcirc.Items.Add(actual.Dato);
                actual = actual.Siguiente;
            }
            while (actual != miListaCirc.Inicio);
        }

        private void btnVACIAR_Click(object sender, EventArgs e)
        {
            miListaCirc.Vaciar();
            lblLISTAcirc.Text = "La lista se vacio";
            lstLISTAcirc.Items.Clear();
        }

        private void btnQUITAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPOSICION.Text, out int posicion))
            {
                int eliminado = miListaCirc.Eliminar(posicion);
                if (eliminado != 1)
                {
                    lblLISTAcirc.Text = "Valor eliminado: " + eliminado.ToString();
                    btnMOSTRAR_Click(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una posicion valida", "Posicion invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
