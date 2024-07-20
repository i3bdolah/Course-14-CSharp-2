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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
        }

        private void btnShowDialogue_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.ShowDialog();
        }

        private void MsgBox_Click(object sender, EventArgs e)
        {
            Form form1 = new Form3();
            form1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newForm = new CheckBoxForm();
            newForm.ShowDialog();
        }
    }
}
