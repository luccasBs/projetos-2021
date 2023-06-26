using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SnackMachine
{
    public partial class Form2 : Form
    {
        double valor = 0; 
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMMS_Click(object sender, EventArgs e)
        {
            valor = valor = 3.5;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btncoca_Click(object sender, EventArgs e)
        {
            valor = valor = 5.00;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnTwix_Click(object sender, EventArgs e)
        {
            valor = valor = 3.80;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnoreo_Click(object sender, EventArgs e)
        {
            valor = valor = 4.0;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnskittles_Click(object sender, EventArgs e)
        {
            valor = valor = 6.50;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnHersheys_Click(object sender, EventArgs e)
        {
            valor = valor = 4.50;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnfritos_Click(object sender, EventArgs e)
        {
            valor = valor = 2.0;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnlays_Click(object sender, EventArgs e)
        {
            valor = valor = 7.50;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btndoritos_Click(object sender, EventArgs e)
        {
            valor = valor = 7.00;
            if (valor > 0)
            {
                textValor.Text = (Convert.ToString(valor) + "Retire seu troco");
            }
            else { textValor.Text = "Obrigado"; }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int prov = Convert.ToInt32(textValor.Text);
            if (prov == 2 || prov == 5 || prov == 10 || prov == 20)
            {
                valor = valor + prov;
                if (valor >= 2)
                {
                    btnMMS.Enabled = true;
                }
                if (valor >= 3.5)
                {
                    btncoca.Enabled = true;
                }
                if (valor >= 7.5)
                {
                    btnTwix.Enabled = true;
                }
                if (valor >= 2)
                {
                    btnoreo.Enabled = true;
                }
                if (valor >= 2)
                {
                    btnskittles.Enabled = true;
                }
                if (valor >= 2)
                {
                    btnHersheys.Enabled = true;
                }
                if (valor >= 2)
                {
                    btnfritos.Enabled = true;
                }
                if (valor >= 2)
                {
                    btnlays.Enabled = true;
                }
                if (valor >= 2)
                {
                    btndoritos.Enabled = true;
                }
                textValor.Text = (Convert.ToString(valor) + " -----  Escolha o Produto");
            }
            else
            {
                textValor.Text = "Valor Inválido";
            }
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            textValor.Text = "Insira o valor";
            valor = 0;
            btnfritos.Enabled = false;
            btnMMS.Enabled = false;
            btnTwix.Enabled = false;
            btnoreo.Enabled = false;
            btnHersheys.Enabled = false;
            btncoca.Enabled = false;
            btnskittles.Enabled = false;
            btndoritos.Enabled = false;
            btnlays.Enabled = false;
        }
    }
}
