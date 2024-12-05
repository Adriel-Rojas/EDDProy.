using EDDemo.Estructuras_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using EDDemo.Clases;

namespace EDDemo
{
    public partial class frmPilas : Form
    {
        Pila miPila = new Pila();

        public frmPilas()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
                     
        }

        private void btnPUSH_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtDATO.Text, out int DATO))
            {
                miPila.Push(DATO);
                lblPILA.Text = DATO.ToString();
            }
            else
            {
                MessageBox.Show("Ingrese un numero valido", "Se agrego incorrectamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtDATO.Clear();
            txtDATO.Focus();
        }

        private void btnPOP_Click(object sender, EventArgs e)
        {
            int? valor = miPila.Pop();
            if (valor != null)
            {
                lblPILA.Text = valor.ToString();
            }
        }

        private void btnBUSCAR_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDATO.Text, out int dato))
            {
                if (miPila.Buscar(dato))
                {
                    lblPILA.Text = $"El valor {dato} se encuentra en la pila";
                    //MessageBox.Show($"El valor {dato} se encuentra en la pila.","Valor encontrado");
                }
                else
                {
                    lblPILA.Text = $"El valor {dato} no se encuentra en la pila";
                    //MessageBox.Show($"El valor {dato} no se encontro en la pila", "Valor no encontrado");
                }
            }
            else
            {
                lblPILA.Text = "Ingrese un numero valido";
                //MessageBox.Show("Ingrese un numero valido", "Numero no valido");
            }
        }

        private void btnVACIAR_Click(object sender, EventArgs e)
        {
            if (miPila.Vacio())
            {
                lblPILA.Text = "La pila esta vacia";
                //MessageBox.Show("La pila esta vacia","Pila vacia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                lblPILA.Text = "La pila no esta vacia";
                //MessageBox.Show("La pila no esta vacia","Pila no vacia",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnLIMPIAR_Click(object sender, EventArgs e)
        {
            miPila.Limpiar();
            lblPILA.Text = "La pila se limpio";
        }

        private void btnINICIALIZAR_Click(object sender, EventArgs e)
        {
            miPila.Inicializar();
            lblPILA.Text = "La pila se inicializo";
        }

        private void btnRECORRER_Click(object sender, EventArgs e)
        {
            List<int> elementos = miPila.Recorrer();
            if (elementos.Count == 0)
            {
                MessageBox.Show("La pila esta vacia", "Pila vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lblPILA.Text = string.Join(", ", elementos);
            }
        }
    }
}
