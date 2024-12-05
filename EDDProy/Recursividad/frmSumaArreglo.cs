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
    public partial class frmSumaArreglo : Form
    {
        private List<int> elementos;
        public frmSumaArreglo()
        {
            InitializeComponent();
            elementos = new List<int>();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                SumaArreglo.ResetOperaciones();
                int[] arreglo = elementos.ToArray();
                int resultado = SumaArreglo.Calcular(arreglo, arreglo.Length);
                lblResultado.Text = $"Suma: {resultado}";
                lblOperaciones.Text = $"Operaciones: {SumaArreglo.Operaciones}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int elemento = int.Parse(txtElemento.Text);
                elementos.Add(elemento);
                lstElementos.Items.Add(elemento);
                txtElemento.Clear();
                txtElemento.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            elementos.Clear();
            lstElementos.Items.Clear();
            txtElemento.Clear();
            lblResultado.Text = "Suma: ";
            lblOperaciones.Text = "Operaciones: ";
            txtElemento.Focus();
        }
    }
}
