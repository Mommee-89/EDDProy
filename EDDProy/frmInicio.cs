using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;
using EDDemo.Metodos_de_Busqueda_y_Ordenamiento;
using EDDemo.Estructuras_Lineales;
using EDDemo.Recursividad;

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

        private void busquedaYOrdenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMetodos metodos = new FormMetodos();
            metodos.MdiParent = this;
            metodos.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
         FrmCola frmCola = new FrmCola();   
            frmCola.MdiParent = this;
            frmCola.Show();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaSimple frmListaSimple = new frmListaSimple();
             frmListaSimple.MdiParent = this;
            frmListaSimple.Show();
        }

        private void listaCircularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaCircular frmListaCircular = new frmListaCircular();
            frmListaCircular.MdiParent = this;
            frmListaCircular.Show();
        }

        private void busquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaBinaria frmBusqueda = new frmBusquedaBinaria();  
            frmBusqueda.MdiParent = this;   
            frmBusqueda.Show();
        }

        private void exponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExponente frmExponente = new frmExponente();
            frmExponente.MdiParent = this;  
            frmExponente.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial frmFactorial = new frmFactorial(); 
            frmFactorial.MdiParent = this;
            frmFactorial.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci frmFib = new frmFibonacci();
            frmFib.MdiParent = this;
            frmFib.Show();
        }

        private void hanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHanoi frmHanoi = new frmHanoi();
            frmHanoi.MdiParent = this;
            frmHanoi.Show();
        }

        private void sumaDeArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumaArreglo frm = new frmSumaArreglo();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
