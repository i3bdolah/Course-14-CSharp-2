﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                Thread.Sleep(50);
                progressBar1.Value += progressBar1.Step;

                label1.Text = (((float)progressBar1.Value / (float)progressBar1.Maximum) * 100) + "%";

                progressBar1.Refresh();
                label1.Refresh();
            }

            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            label1.Text = progressBar1.Value + "%";

            button1.Enabled = true;
            button2.Enabled = false;
        }
    }
}
