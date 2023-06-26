using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (Barradeprogresso.Value < 100)
            {
                Barradeprogresso.Value = Barradeprogresso.Value + 2;
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
