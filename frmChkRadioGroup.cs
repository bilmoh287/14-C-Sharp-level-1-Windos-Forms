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
    public partial class frmChkRadioGroup : Form
    {
        public frmChkRadioGroup()
        {
            InitializeComponent();

        }

        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;

            }
            else
            {
                lblSize.Text = "Medium";
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";
            if (chkExtraCheese.Checked)
            {
                sToppings += "Extra Cheese";
            }
            if(chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }
            if (chkOnions.Checked)
            {
                sToppings += ", Onions";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if(sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length-1).Trim();
            }
            if(sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblToppings.Text = sToppings;
        }

        void UpdateCrustType()
        {
            UpdateTotalPrice();
            if (rbThik.Checked)
            {
                lblCrustType.Text = "Crust Thick";
            }
            else
            {
                lblCrustType.Text = "Crust Thin";
            }
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();
            if(rbTakeOut.Checked)
            {
                lblWhereToEat.Text = "Take OUt";
            }
            else
            {
                lblWhereToEat.Text = "Eat In";
            }
        }

        float GetSelectedSizePrice()
        {
            if(rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            else if(rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
        }

        float CalculateToppingsPrice()
        {
            float TotalPrice = 0;
            if(chkExtraCheese.Checked)
            {
                TotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }
            if (chkMushrooms.Checked)
            {
                TotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if (chkOnions.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOnions.Tag);
            }
            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                TotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }
            return TotalPrice;
        }

        float GetCrustTypePrice()
        {
            if(rbThik.Checked)
            {
                return Convert.ToSingle(rbThik.Tag);
            }
            else
            {
                return Convert.ToSingle(rbThin.Tag);
            }
        }

        float GetWhereToEatPrice()
        {
            if(rbTakeOut.Checked)
            {
                return Convert.ToSingle(rbTakeOut.Tag);
            }
            else
            {
                return Convert.ToSingle(rbTakeIn.Tag);
            }
        }

        float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + CalculateToppingsPrice() + GetCrustTypePrice() + 
                GetWhereToEatPrice()) * Convert.ToSingle(numericUpDown1.Value);
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        private void gbOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) ==
                DialogResult.OK)
            {
                MessageBox.Show("Ordered Successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbPizzaSize.Enabled = false;
                gbToppings.Enabled = false;
                gbPizzaSize.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbCrust.Enabled = false;
            }
            else
            {

            }
        }

        void ResetFrorm()
        {
            //Reset Groups
            gbToppings.Enabled = true;
            gbPizzaSize.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereToEat.Enabled = true;

            //Piza size default medium
            rbMedium.Checked = true;

            //Enable toppings to false
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnions.Checked = false;
            chkOlives.Checked = false;
            chkGreenPeppers.Checked = false;

            //Default Crust Thin
            rbThin.Checked = true;

            //Default Wehere to eat Eat in
            rbTakeIn.Checked = true;
            UpdateOrderSummary();
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrustType();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }


        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThik_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();

        }

        private void rbTakeIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetFrorm();
        }

        private void frmChkRadioGroup_Load(object sender, EventArgs e)
        {
            gbPizzaSize.BackColor = Color.FromArgb(100, Color.White); // 100 = transparency
            ResetFrorm();
        }

        private void lblCrustType_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gbPizzaSize_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
