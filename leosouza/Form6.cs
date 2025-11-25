using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leosouza
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int i = 1, c = 0;
            double f;
            do
            {
                c = c + 10;
                f = (c * 1.8) + 32;
                txtf.Text = String.Format(txtf.Text + "\n " + f.ToString());
                i++;
            }
            while (i <= 10);
        }

        private void btnlimp_Click(object sender, EventArgs e)
        {
            txtf.Clear();
        }

        private void btnvolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }
    }
}
