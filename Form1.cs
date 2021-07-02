using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Somar_e_Multiplicar
{
    public partial class frmSomaMultiplica : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
              int left,
              int top,
              int right,
              int bottom,
              int width,
              int height
          );
        public frmSomaMultiplica()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, calc, resultado;

            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);

            calc = (n1 + n2);
            resultado = calc * n1;

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtResultado.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
