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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Fibonacci.ResetOperaciones();
                int n = int.Parse(txtNumero.Text);

                if (n < 0)
                {
                    MessageBox.Show("El número debe ser mayor o igual a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var secuencia = Fibonacci.Calcular(n);
                lstSecuencia.Items.Clear();
                for (int i = 0; i <= n; i++)
                {
                    lstSecuencia.Items.Add($"F({i}) = {secuencia[i]}");
                }
                lblOperaciones.Text = $"Operaciones: {Fibonacci.Operaciones}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
