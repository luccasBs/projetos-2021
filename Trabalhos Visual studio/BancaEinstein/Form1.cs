using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancaEinstein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timertitulo.Enabled = true;
            Timer_Fruta.Enabled = true;
            Timer_Salgado.Enabled = true;
        }

        private void Timertitulo_Tick(object sender, EventArgs e)
        {
            lbltitulo.ForeColor = lbltitulo.ForeColor == Color.Transparent ? Color.DarkRed : Color.Transparent;
        }

        private void timer_Fruta_Tick(object sender, EventArgs e)
        {
            lblfrutas.ForeColor = lblfrutas.ForeColor == Color.Transparent ? Color.Yellow : Color.Transparent;
        }
        private void timer_Salgado_Tick(object sender, EventArgs e)
        {
            lblsalgados.ForeColor = lblsalgados.ForeColor == Color.Transparent ? Color.MediumPurple : Color.Transparent;
        }
        private void btnadfruta_Click(object sender, EventArgs e)
        {
            Lst_Frutas.Items.Add(txtfruta.Text);
        }

        private void btnremfruta_Click(object sender, EventArgs e)
        {
            Lst_Frutas.Items.RemoveAt(Lst_Frutas.SelectedIndex);
        }

        private void btnadcsalgado_Click(object sender, EventArgs e)
        {
            Lst_Salgados.Items.Add(txtsalgado.Text);
        }

        private void btnremsalgado_Click(object sender, EventArgs e)
        {
            Lst_Salgados.Items.RemoveAt(Lst_Salgados.SelectedIndex);
        }

    }
}
