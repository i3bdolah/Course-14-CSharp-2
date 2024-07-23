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

        //int TotalPrice = 0;

        List<string> CheckboxesList = new List<string> { };

        Byte GetSizeTotal()
        {
            if (RbSmall.Checked)
            {
                return Convert.ToByte(RbSmall.Tag);
            }
            else if (RbMedium.Checked)
            {
                return Convert.ToByte(RbMedium.Tag);
            }
            else
            {
                return Convert.ToByte(RbLarge.Tag);
            }
        }

        Byte GetCrustTotal()
        {
            if (RbThin.Checked)
            {
                return Convert.ToByte(RbThin.Tag);
            }
            else
            {
                return Convert.ToByte(RbThick.Tag);
            }
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
            }
            else if (RbMedium.Checked)
            {
                LblSize.Text = RbMedium.Text;
            }
            else
            {
                LblSize.Text = RbLarge.Text;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (RbThin.Checked)
            {
                LblCrust.Text = RbThin.Text;
            }
            else
            {
                LblCrust.Text = RbThick.Text;
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
            Byte MyTagValue = Byte.Parse(CbExtraCheese.Tag.ToString());

            if (CbExtraCheese.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbExtraCheese.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbExtraCheese.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void CbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbMushrooms.Tag.ToString());

            if (CbMushrooms.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbMushrooms.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbMushrooms.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void CbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbTomatoes.Tag.ToString());

            if (CbTomatoes.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbTomatoes.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbTomatoes.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void CbOnions_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbOnions.Tag.ToString());

            if (CbOnions.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbOnions.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbOnions.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void CbOlives_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbOlives.Tag.ToString());

            if (CbOlives.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbOlives.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbOlives.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void CbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(CbGreenPeppers.Tag.ToString());

            if (CbGreenPeppers.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                CheckboxesList.Add(CbGreenPeppers.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
                CheckboxesList.Remove(CbGreenPeppers.Text);
                LblToppings.Text = String.Join(", ", CheckboxesList);
            }
        }

        private void GbSize_EnabledChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Enable Changed");
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
