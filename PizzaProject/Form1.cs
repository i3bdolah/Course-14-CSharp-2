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

        List<string> CheckboxesList = new List<string> {};

        //private string ArrayToString(string[] CheckboxesArr)
        //{
        //    string str = "";

        //  for (int i = 0; i < CheckboxesArr.Length; i++)
        //    {
        //        str += ", " + CheckboxesArr[i];
        //    }
        //  return str;
        //}

        //private string[] ShiftArrayElement(string[] CheckboxesArr, string Element)
        //{
        //    string[] NewArr = new string[CheckboxesArr.Length - 1];

        //    for (int i = 0;i < NewArr.Length;i++)
        //    {
        //        int j = 0;
        //        j++;

        //        if (CheckboxesArr[j] == Element)
        //        {
        //            j++;
        //        }
                
        //        NewArr[i] = CheckboxesArr[j];
        //    }
        //    return NewArr;
        //}

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
            //MessageBox.Show(TotalPrice.ToString());
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

        }

        private void GbSummary_Enter(object sender, EventArgs e)
        {

        }

        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbSmall.Tag.ToString());

            if (RbSmall.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                LblSize.Text = RbSmall.Text;
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
            }
        }

        private void RbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbMedium.Tag.ToString());

            if (RbMedium.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                LblSize.Text = RbMedium.Text;
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
            }
        }

        private void RbLarge_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbLarge.Tag.ToString());

            if (RbLarge.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                LblSize.Text = RbLarge.Text;
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
            }
        }

        private void RbThin_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbThin.Tag.ToString());

            if (RbThin.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                LblCrust.Text = RbThin.Text;
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
            }
        }

        private void RbThick_CheckedChanged(object sender, EventArgs e)
        {
            Byte MyTagValue = Byte.Parse(RbThick.Tag.ToString());

            if (RbThick.Checked)
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) + MyTagValue).ToString();
                LblCrust.Text = RbThick.Text;
            }
            else
            {
                LblTotal.Text = (Convert.ToByte(LblTotal.Text) - MyTagValue).ToString();
            }
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
