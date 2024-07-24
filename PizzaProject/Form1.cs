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

        Byte GetSizeTotal()
        {
            if (RbSmall.Checked)
            {
                return Convert.ToByte(RbSmall.Tag);
            }
            if (RbMedium.Checked)
            {
                return Convert.ToByte(RbMedium.Tag);
            }
            if (RbLarge.Checked)
            {
                return Convert.ToByte(RbLarge.Tag);
            }

            return Convert.ToByte(0); // To Please the compiler
        }

        Byte GetCrustTotal()
        {
            if (RbThin.Checked)
            {
                return Convert.ToByte(RbThin.Tag);
            }
            if (RbThick.Checked)
            {
                return Convert.ToByte(RbThick.Tag);
            }

            return Convert.ToByte(0); // To Please the compiler
        }

        Byte GetToppingsTotal()
        {
            Byte sum = 0;

            if (CbExtraCheese.Checked)
            {
                sum += Convert.ToByte(CbExtraCheese.Tag);
            }
            if (CbMushrooms.Checked)
            {
                sum += Convert.ToByte(CbMushrooms.Tag);

            }
            if (CbTomatoes.Checked)
            {
                sum += Convert.ToByte(CbTomatoes.Tag);

            }
            if (CbOnions.Checked)
            {
                sum += Convert.ToByte(CbOnions.Tag);

            }
            if (CbOlives.Checked)
            {
                sum += Convert.ToByte(CbOlives.Tag);

            }
            if (CbGreenPeppers.Checked)
            {
                sum += Convert.ToByte(CbGreenPeppers.Tag);

            }

            return sum;
        }

        void UpdateTotalPrice()
        {
            LblTotal.Text = (GetSizeTotal() + GetCrustTotal() + GetToppingsTotal()).ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (RbSmall.Checked)
            {
                LblSize.Text = RbSmall.Text;
                return;
            }
            if (RbMedium.Checked)
            {
                LblSize.Text = RbMedium.Text;
                return;
            }
            if (RbLarge.Checked)
            {
                LblSize.Text = RbLarge.Text;
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (RbThin.Checked)
            {
                LblCrust.Text = RbThin.Text;
                return;
            }
            if (RbThick.Checked)
            {
                LblCrust.Text = RbThick.Text;
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            List<string> CheckboxesList = new List<string> { };

            if (CbExtraCheese.Checked)
            {
                CheckboxesList.Add(CbExtraCheese.Text);
            }
            if (CbMushrooms.Checked)
            {
                CheckboxesList.Add(CbMushrooms.Text);
            }
            if (CbTomatoes.Checked)
            {
                CheckboxesList.Add(CbTomatoes.Text);
            }
            if (CbOlives.Checked)
            {
                CheckboxesList.Add(CbOlives.Text);
            }
            if (CbOnions.Checked)
            {
                CheckboxesList.Add(CbOnions.Text);
            }
            if (CbGreenPeppers.Checked)
            {
                CheckboxesList.Add(CbGreenPeppers.Text);
            }

            if (CheckboxesList.Count() == 0)
            {
                LblToppings.Text = "No Toppings.";
            }
            else
            {
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                GbSize.Enabled = false;
                GbCrust.Enabled = false;
                GbToppings.Enabled = false;
                GbWhereToEat.Enabled = false;
                //btnSubmit.Enabled = false;

                MessageBox.Show("Order Placed Successfully.");
            }
            else
            {
                MessageBox.Show("Order Incomplete.");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            RbSmall.Checked = false;
            RbMedium.Checked = false;
            RbLarge.Checked = false;
            RbThin.Checked = false;
            RbThick.Checked = false;
            CbExtraCheese.Checked = false;
            CbMushrooms.Checked = false;
            CbTomatoes.Checked = false;
            CbOnions.Checked = false;
            CbOlives.Checked = false;
            CbGreenPeppers.Checked = false;
            RbTakeIn.Checked = false;
            RbTakeAway.Checked = false;

            LblSize.Text = " ";
            LblCrust.Text = " ";
            LblToppings.Text = " ";
            LblWhereToEat.Text = " ";

            GbSize.Enabled = true;
            GbCrust.Enabled = true;
            GbToppings.Enabled = true;
            GbWhereToEat.Enabled = true;
            btnSubmit.Enabled = true;

        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void RbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void RbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void CbExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void CbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void RbTakeIn_CheckedChanged(object sender, EventArgs e)
        {
            LblWhereToEat.Text = RbTakeIn.Text;
        }

        private void RbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            LblWhereToEat.Text = RbTakeAway.Text;
        }
    }
}
