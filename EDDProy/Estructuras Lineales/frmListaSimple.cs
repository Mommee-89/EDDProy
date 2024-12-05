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

namespace EDDemo.Estructuras_Lineales
{
    public partial class frmListaSimple : Form
    {
        private ListaS listaS;
        public frmListaSimple()
        {
            InitializeComponent();
            listaS = new ListaS();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaS.Push(" " + dato);
                MessageBox.Show($"Dato {dato} insertado.");
                txtDato.Clear();
            }
            else
            {
                MessageBox.Show("Ingresa un numero valido.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaS.Pop();
            MessageBox.Show("Primer dato eliminado.");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtDato.Text, out int dato))
            {
                listaS.Buscar("dato");
            }
            else
            {
                MessageBox.Show("Ingresa un numero valido.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            lstDatos.Items.Clear();
            var datos = listaS.ObtenerDatos();
            foreach (var d in datos)
            {
                lstDatos.Items.Add(d);
            }

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

