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
    public partial class frmHanoi : Form
    {
        public frmHanoi()
        {
            InitializeComponent();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                lstMovimientos.Items.Clear();
                Hanoi.ResetOperaciones();
                int discos = int.Parse(txtDiscos.Text);
                if (discos <= 0)
                {
                    MessageBox.Show("El número de discos debe ser mayor que 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Hanoi.Resolver(discos, 'A', 'C', 'B', movimiento =>
                {
                    lstMovimientos.Items.Add(movimiento);
                });

                lblOperaciones.Text = $"Operaciones: {Hanoi.Operaciones}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al resolver las torres: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtDiscos.Clear();
            lstMovimientos.Items.Clear();
            lblOperaciones.Text = "Operaciones:";
            txtDiscos.Focus();
        }
    }
}
