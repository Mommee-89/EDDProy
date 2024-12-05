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
    public partial class frmListaCircular : Form
    {
        private ListaC listaCircular;
        public frmListaCircular()
        {
            InitializeComponent();
            listaCircular = new ListaC();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string dato = txtDato.Text;
                listaCircular.Insertar(dato);
                MessageBox.Show("Dato insertado correctamente.");
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int posicion = (int)nudPosicion.Value;
                string eliminado = listaCircular.Eliminar(posicion);
                if (eliminado != null)
                {
                    MessageBox.Show($"Dato eliminado: {eliminado}");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el dato. Posición inválida.");
                }
                ActualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ActualizarLista();
        }

        private void ActualizarLista()
        {
            lstLista.Items.Clear();
            var elementos = listaCircular.ObtenerDatos();
            foreach (var item in elementos)
            {
                lstLista.Items.Add(item);
            }
        }

        private void nudPosicion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDato_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
