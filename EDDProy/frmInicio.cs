using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Algoritmo_Recursivoss;
using EDDemo.Estructuras_Lineales;
using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_ordenamiento_y_busqueda;
using EDDemo.Metodos_de_ordenamiento_y_busqueda.Clases;
using EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento;
using EDDemo.Metodos_de_ordenamiento_y_busqueda.Ordenamiento.Clases;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas mPilas = new frmPilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColas mColas = new frmColas();
            mColas.MdiParent = this;
            mColas.Show();
        }

        private void simpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple mListasSimple = new frmListaSimple();
            mListasSimple.MdiParent = this;
            mListasSimple.Show();
        }

        private void factorialDeUnNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorialNum mFactorialNum = new frmFactorialNum();
            mFactorialNum.MdiParent = this;
            mFactorialNum.Show();
        }

        private void calculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculoExp mCalculoExp = new frmCalculoExp();
            mCalculoExp.MdiParent = this;
            mCalculoExp.Show();
        }

        private void sumarLosElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumarArreglo mSumarArreglo = new frmSumarArreglo();
            mSumarArreglo.MdiParent = this;
            mSumarArreglo.Show();
        }

        private void secuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSecuenciaFib frmSecuenciaFib = new frmSecuenciaFib();
            frmSecuenciaFib.MdiParent = this;
            frmSecuenciaFib.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBin mBusquedaBin = new frmBusquedaBin();
            mBusquedaBin.MdiParent = this;
            mBusquedaBin.Show();
        }

        private void algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTorreHanoi mTorreHanoi = new frmTorreHanoi();
            mTorreHanoi.MdiParent = this;
            mTorreHanoi.Show();
        }

        private void doblementeEncadenadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaDoble mListaDoble = new frmListaDoble();
            mListaDoble.MdiParent = this;
            mListaDoble.Show();
        }

        private void circularSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListCircSimple mListCircSimple = new frmListCircSimple();
            mListCircSimple.MdiParent = this;
            mListCircSimple.Show();
        }

        private void circularDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircDoble mListCircDoble = new frmCircDoble();
            mListCircDoble.MdiParent = this;
            mListCircDoble.Show();
        }

        private void hASHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaHASH mBusquedaHASH = new frmBusquedaHASH();
            mBusquedaHASH.MdiParent = this;
            mBusquedaHASH.Show();
        }

        private void binariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria mBusquedaBinaria = new frmBusquedaBinaria();
            mBusquedaBinaria.MdiParent = this;
            mBusquedaBinaria.Show();
        }

        private void burbujaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBurbuja mBurbuja = new frmBurbuja();
            mBurbuja.MdiParent = this;
            mBurbuja.Show();
        }

        private void quickSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuickShort mQuickSort = new frmQuickShort();
            mQuickSort.MdiParent = this;
            mQuickSort.Show();
        }

        private void sellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSellSort mSellSort = new frmSellSort();
            mSellSort.MdiParent = this;
            mSellSort.Show();
        }

        private void radixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRadix mRadix = new frmRadix();
            mRadix.MdiParent = this;
            mRadix.Show();
        }
    }
}
