using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections;
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
    public partial class frmListaSimple : Form
    {

        ListaSimple miLista = new ListaSimple();

        public frmListaSimple()
        {
            InitializeComponent();
        }

        void AgregarItem(Nodo unNodo)
        {
            if (unNodo != null)
            {
                lstLISTAsim.Items.Add(unNodo.Numero);
                AgregarItem(unNodo.Siguiente);
            }
        }

        public void Mostrar()
        {
            lstLISTAsim.Items.Clear();
            if (miLista.Inicio != null)
            {
                AgregarItem(miLista.Inicio);
            }
        }

        private void btnAGinicio_Click(object sender, EventArgs e)
        {
            int numero;
            if (txtDATO.Text != "" && int.TryParse(txtDATO.Text, out numero))
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Numero = numero;

                miLista.AGinicio(unNuevoNodo);

                Mostrar();
                txtDATO.Text = "";
                txtDATO.Focus();//Cargar otro nodo
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido...", "Valor no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAGfinal_Click(object sender, EventArgs e)
        {
            int numero;
            if (txtDATO.Text != "" && int.TryParse(txtDATO.Text, out numero))
            {
                Nodo unNuevoNodo = new Nodo();
                unNuevoNodo.Numero = numero;
                miLista.Agfinal(unNuevoNodo);
                Mostrar();
                txtDATO.Text = "";
                txtDATO.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese un valor valido...", "Valor no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicion;
            if (int.TryParse(txtDATO.Text, out posicion))
            {
                miLista.Eliminar(posicion);
                Mostrar();
                txtDATO.Text = "";
                txtDATO.Focus();
            }
            else
            {
                MessageBox.Show("Ingrese una posicion valida...", "Posicion no valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            miLista.Vaciar();
            Mostrar();
        }
    }
}
