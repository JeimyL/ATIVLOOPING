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
    public partial class Form8 : Form
    {
        double areatotal = 0.0, larg = 0.0, comp = 0.0, area = 0.0;

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmmenu frmmenu = new frmmenu();
            frmmenu.Show();
        }

        private void txtlimpar_Click(object sender, EventArgs e)
        {
            txtcomp.Clear();
            txtlarg.Clear();
            txtarea.Clear();
            txtlarg.Focus();
            areatotal = 0.0;
        }

        DialogResult resultado = DialogResult.Yes;
        public Form8()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            comp = Convert.ToDouble(txtcomp.Text);
            larg = Convert.ToDouble(txtlarg.Text);
            area = comp * larg;
            areatotal += area;
            txtarea.Text = area.ToString();

            resultado = MessageBox.Show("Deseja adicionar mais um cômodo?", "Continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                txtcomp.Clear();
                txtlarg.Clear();
                txtarea.Clear();
                txtlarg.Focus();
            }
            else if (resultado == DialogResult.No)
            {
                txtareat.Text = areatotal.ToString();
            }

        }
    }
}
