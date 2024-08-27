using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add in Client");
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit in Client");
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Read in Client");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete in Client");
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add in User");
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void readToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form2();
            frm.MdiParent = this;

            frm.Show();
        }
    }
}
