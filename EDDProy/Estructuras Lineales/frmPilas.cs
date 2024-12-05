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
        private Pilas pila;
        public frmPilas()
        {
            InitializeComponent();
            pila = new Pilas();
        }

        private void MostrarPila()
        {
            lstPila.Items.Clear();
            Nodo actual = pila.ObtenerTop();

            while (actual != null)
            {
                lstPila.Items.Add(actual.Dato);
                actual = actual.sig;
            }
        }

       

        private void BtnPush_Click_1(object sender, EventArgs e)
        {
            int dato;
            if (int.TryParse(txtDato.Text, out dato))
            {
                pila.Push(dato, lstPila);
                txtDato.Clear();
                MessageBox.Show("Dato agregado correctamente.");
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }
        }

        private void BtnPop_Click(object sender, EventArgs e)
        {
            pila.Pop(lstPila);
            MostrarPila();
            MessageBox.Show("Elemento eliminado.");
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            Nodo topNodo = pila.ObtenerTop();
            if (topNodo != null)
            {
                MessageBox.Show("Top de la pila: " + topNodo.Dato);
            }
            else
            {
                MessageBox.Show("La pila está vacía.");
            }
        }

        private void lstPila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
