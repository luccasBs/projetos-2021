using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exerciciodesplash
{
    public partial class Frmsplash : Form
    {
        public Frmsplash()
        {
            InitializeComponent();
            progressBar1.Maximum = 100;
            tmrsplash.Start();
        }

        private void tmrsplash_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100)
            {
                progressBar1.Value = progressBar1.Value + 2;
                lblcontador.Text = "aguarde..." + progressBar1.Value + "%";
            }
            else
            {
                tmrsplash.Enabled = false;
                this.Visible = false;
            }
        }
    }
}
