using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                checkedListBox1.Items.Add("Item " + i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string AllItems = "";

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                AllItems += checkedListBox1.CheckedItems[i].ToString();
                AllItems += "\n";
            }

            MessageBox.Show(AllItems);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.Items.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                for (int j = 0; j < checkedListBox1.Items.Count; j++)
                {
                    if (checkedListBox1.CheckedItems[i] == checkedListBox1.Items[j])
                    {
                        checkedListBox1.Items.Remove(checkedListBox1.Items[j]);
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }
    }
}
