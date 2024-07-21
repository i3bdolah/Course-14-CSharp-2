using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int TotalPrice = 0;

        private void GbCrust_Enter(object sender, EventArgs e)
        {

        }

        private void GbSize_Enter(object sender, EventArgs e)
        {

        }

        private void GbWhereToEat_Enter(object sender, EventArgs e)
        {

        }

        private void GbToppings_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Must all fields checked
            MessageBox.Show(TotalPrice.ToString());
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Make all fields unchecked
        }

        private void GbSummary_Enter(object sender, EventArgs e)
        {

        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbSmall.Tag.ToString());

            if (RbSmall.Checked)
            {
                TotalPrice =+ MyTagValue;
                lblSize.Text = RbSmall.Text;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }

        }

        private void RbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbMedium.Tag.ToString());

            if (RbMedium.Checked)
            {
                TotalPrice =+ MyTagValue;
                lblSize.Text = RbMedium.Text;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void RbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbLarge.Tag.ToString());

            if (RbLarge.Checked)
            {
                TotalPrice =+ MyTagValue;
                lblSize.Text = RbLarge.Text;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void RbThin_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbThin.Tag.ToString());

            if (RbThin.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void RbThick_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbThick.Tag.ToString());

            if (RbThick.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbExtraCheese.Tag.ToString());

            if (CbExtraCheese.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbMushrooms.Tag.ToString());

            if (CbMushrooms.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbTomatoes.Tag.ToString());

            if (CbTomatoes.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbOnions_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbOnions.Tag.ToString());

            if (CbOnions.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbOlives_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbOlives.Tag.ToString());

            if (CbOlives.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }

        private void CbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbGreenPeppers.Tag.ToString());

            if (CbGreenPeppers.Checked)
            {
                TotalPrice =+ MyTagValue;
            }
            else
            {
                TotalPrice =- MyTagValue;
            }
        }
    }
}
