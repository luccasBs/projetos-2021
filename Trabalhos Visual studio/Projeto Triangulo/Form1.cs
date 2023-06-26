using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double lado1 = Convert.ToDouble(txtLado1.Text);
            double lado2 = Convert.ToDouble(txtLado2.Text);
            double lado3 = Convert.ToDouble(txtLado3.Text);
            Triangulo triangulo = new Triangulo(lado1, lado2, lado3);
            MessageBox.Show(triangulo.resultado());
            txtLado1.Text = "0";
            txtLado2.Text = "0";
            txtLado3.Text = "0";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLado1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
