using PictureBoxExercise.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Text;
            pictureBox1.Image = Resources.Girl;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            //label1.Text = radioButton2.Text;
            label1.Text = ((RadioButton) sender).Text;
            pictureBox1.Image = Resources.Boy;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Text;
            pictureBox1.Image = Resources.Book;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Text;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Abdullah\Desktop\Images\Images\Pen.png");
        }
    }
}
