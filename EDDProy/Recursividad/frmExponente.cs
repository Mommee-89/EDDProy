using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Recursividad
{
    public partial class frmExponente : Form
    {
        public frmExponente()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Exponente.ResetOperaciones();
                BigInteger baseNum = BigInteger.Parse(txtBase.Text);
                BigInteger exponente = BigInteger.Parse(txtExponente.Text);
                var resultado = Exponente.Calcular(baseNum, exponente);
                lblResultado.Text = $"Resultado: {resultado}";
                lblOperaciones.Text = $"Operaciones: {Exponente.Operaciones}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
