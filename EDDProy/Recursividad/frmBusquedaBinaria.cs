using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EDDemo.Recursividad
{
    public partial class frmBusquedaBinaria : Form
    {
        private int[] arregloOrdenado;
        public frmBusquedaBinaria()
        {
            InitializeComponent();
        }

        private void btnCargarArreglo_Click(object sender, EventArgs e)
        {
            try
            {

                arregloOrdenado = txtArreglo.Text
                    .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .OrderBy(x => x)
                    .ToArray();
                lstArreglo.Items.Clear();
                foreach (var item in arregloOrdenado)
                {
                    lstArreglo.Items.Add(item);
                }

                MessageBox.Show("Arreglo cargado y ordenado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el arreglo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                BusquedaBinaria.ResetOperaciones();

                if (arregloOrdenado == null || arregloOrdenado.Length == 0)
                {
                    MessageBox.Show("Cargue un arreglo antes de realizar la búsqueda.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int objetivo = int.Parse(txtBuscar.Text);
                int indice = BusquedaBinaria.Realizar(arregloOrdenado, 0, arregloOrdenado.Length - 1, objetivo);
                if (indice == -1)
                {
                    lblResultado.Text = "Número no encontrado.";
                }
                else
                {
                    lblResultado.Text = $"Número encontrado en el índice {indice}.";
                }

                lblOperaciones.Text = $"Operaciones: {BusquedaBinaria.Operaciones}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtArreglo.Clear();
            txtBuscar.Clear();
            lstArreglo.Items.Clear();
            lblResultado.Text = "Resultado:";
            lblOperaciones.Text = "Operaciones:";
            arregloOrdenado = null;
            txtArreglo.Focus();
        }

        private void txtArreglo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstArreglo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
