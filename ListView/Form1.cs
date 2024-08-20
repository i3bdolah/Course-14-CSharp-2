using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int CurrentValidID = 1;

        private void btnFillRandom_Click(object sender, EventArgs e)
        {
            bool IsMale = true;
            for (int i = 1; i <= 10; i++)
            {
                ListViewItem item = new ListViewItem();

                item.Text = CurrentValidID.ToString();
                item.ImageIndex = Convert.ToInt32(IsMale);
                item.SubItems.Add("Person");
                listView1.Items.Add(item);

                IsMale = !IsMale;
                CurrentValidID++;
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void rbTile_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || string.IsNullOrEmpty(tbName.Text)) return;

            ListViewItem item = new ListViewItem(tbID.Text.Trim());
            if (rbMale.Checked)
                item.ImageIndex = 0;
            else
                item.ImageIndex = 1;

            item.SubItems.Add(tbName.Text.Trim());

            listView1.Items.Add(item);

            rbMale.Checked = false;
            rbFemale.Checked = false;

            tbID.Clear();
            tbName.Clear();

            tbID.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items[0].Remove();
            }
        }
    }
}
