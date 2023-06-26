using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validação_do_CPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        string men;

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string val = maskedTextBox.Text;
            if (CPF.isCpf(val))
            {
                men = "CPF válido";
            }

            else
            {
                men = "CPF inválido";
            }

            MessageBox.Show(men, "Validação");
        }
    }
}
