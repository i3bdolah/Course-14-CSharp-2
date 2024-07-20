using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CheckBoxForm : Form
    {
        public CheckBoxForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(rbSmall.Text + " : " + rbSmall.Checked.ToString() + "\n" + rbMedium.Text + " : " + rbMedium.Checked.ToString() + "\n" + rbLarge.Text + " : " + rbLarge.Checked.ToString());

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(rbThin.Text + " : " + rbThin.Checked.ToString() + "\n" + rbThick.Text + " : " + rbThick.Checked.ToString());
        }
    }
}
