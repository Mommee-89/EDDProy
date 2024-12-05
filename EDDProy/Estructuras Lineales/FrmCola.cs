using EDDemo.Estructuras_Lineales.Clases;
using EDDemo.Estructuras_No_Lineales;
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
    public partial class FrmCola : Form
    {
        private Colas cola;
        public FrmCola()
        {
            InitializeComponent();
            cola = new Colas();
        }

        private void MostrarCola()
        {
            lstCola.Items.Clear();
            NodoBinario actual = cola.primero;
            while (actual != null)
            {
                lstCola.Items.Add(actual.Dato);
                actual = actual.Der;
            }
        }

        private void lstCola_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnqueue_Click_1(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);
                NodoBinario nodo = new NodoBinario(valor);
                cola.Enqueue(nodo);
                MostrarCola();
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDequeue_Click_1(object sender, EventArgs e)
        {
            try
            {
                NodoBinario nodo = cola.Dequeue();

                if (nodo != null)
                {
                    MessageBox.Show($"Elemento desencolado: {nodo.Dato}", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MostrarCola();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(txtValor.Text);

                if (cola.Buscar(valor))
                {
                    MessageBox.Show($"El valor {valor} se encuentra en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"El valor {valor} no se encuentra en la cola.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtValor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
    
