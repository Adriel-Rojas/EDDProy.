using EDDemo.Algoritmo_Recursivoss.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmTorreHanoi : Form
    {
        public frmTorreHanoi()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            int numDiscos;

            if (int.TryParse(txtDiscos.Text, out numDiscos) && numDiscos > 0)//Ver si es valido los numeros ingresados
            {
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                TorreHanoi solver = new TorreHanoi();
                var movimientos = solver.TorrHanoi(numDiscos, 'A', 'C', 'B');

                stopwatch.Stop();

                listResultados.Items.Clear();
                foreach (var movimiento in movimientos) // Mostrar los movimientos en la lista
                {
                    listResultados.Items.Add(movimiento);
                }

                txtTiempo.Text = $"{stopwatch.Elapsed.TotalSeconds:F4} segundos";
            }
            else
            {
                listResultados.Items.Clear();
                listResultados.Items.Add("Ingrese un número válido de discos mayor a 0.");
            }
        }
    }
}
