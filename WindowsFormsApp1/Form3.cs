﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi", "Welcome");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi", "Welcome", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("You've Pressed OK.");
            }
            else
            {
                MessageBox.Show("You've Pressed Cancel.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("You've Pressed OK.");
            }
            else
            {
                MessageBox.Show("You've Pressed Cancel.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi", "Welcome", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                MessageBox.Show("You've Pressed OK.");
            }
            else
            {
                MessageBox.Show("You've Pressed Cancel.");
            }
        }
    }
}
