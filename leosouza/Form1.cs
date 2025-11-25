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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ex1while = new Form2();
            this.Hide();
            ex1while.Show();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 ex2while = new Form5();
            this.Hide();
            ex2while.Show();
        }

        private void ex1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 ex1for = new Form4();
            this.Hide();
            ex1for.Show();
        }

        private void ex2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form6 ex2dowhile = new Form6();
            this.Hide();
            ex2dowhile.Show();
        }

        private void ex1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           Form4 ex1for = new Form4();
            this.Hide();
            ex1for.Show();
        }

        private void ex2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form7 ex2for = new Form7();
            this.Hide();
            ex2for.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 ex3 = new Form8();
            this.Hide();
            ex3.Show();
        }
    }
}
