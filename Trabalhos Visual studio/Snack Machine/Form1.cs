using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Snack_Machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (barradeprogresso.Value < 100)
            {
                barradeprogresso.Value = barradeprogresso.Value + 2;
            }
            else
            {
                temporizador.Enabled = false;
                this.Visible = false;
                Form2 visivel = new Form2();
                visivel.ShowDialog();

            }

        }
    }
}
