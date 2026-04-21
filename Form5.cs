using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private int CalculatePrice()
        {
            int total = 0;


            if (rbSmall.Checked) total += 10;
            else if (rbMedium.Checked) total += 20;
            else if (rbLarge.Checked) total += 30;

            if (cbExtraChees.Checked) total += 5;
            if (cbMushrooms.Checked) total += 5;
            if (cbTomatoes.Checked) total += 5;
            if (cbOnion.Checked) total += 5;
            if (cbOlives.Checked) total += 5;
            if (cbGreenPeppers.Checked) total += 5;


            if (rbThickCrust.Checked) total += 5;

            return total;
        }
        private string GetToppings()
        {
            string toppings = "";

            if (cbExtraChees.Checked) toppings += "Extra Cheese, ";
            if (cbMushrooms.Checked) toppings += "Mushrooms, ";
            if (cbTomatoes.Checked) toppings += "Tomatoes, ";
            if (cbOnion.Checked) toppings += "Onion, ";
            if (cbOlives.Checked) toppings += "Olives, ";
            if (cbGreenPeppers.Checked) toppings += "Green Peppers, ";


            if (toppings.EndsWith(", "))
            {
                toppings = toppings.Substring(0, toppings.Length - 2);
            }

            if (string.IsNullOrEmpty(toppings))
                return "No Toppings";


            return toppings;
        }
        private void UpdateToppings()
        {
            lbToppings.Text = GetToppings();
        }
        private void UpdatePrice()
        {
            int total = CalculatePrice();
            lbRealPriceNum.Text = total.ToString();
        }
        private void FrmOrder_Load(object sender, EventArgs e)
        {
            UpdatePrice();
            UpdateToppings();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            lbSize.Text = rbSmall.Text;

        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            lbSize.Text = rbMedium.Text;
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            lbSize.Text = rbLarge.Text;
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            lbCrust.Text = rbThinCrust.Text;

        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePrice();
            lbCrust.Text = rbThickCrust.Text;
        }

        private void cbExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            cbExtraChees.ForeColor = Color.Green;
            UpdatePrice();
            UpdateToppings();

        }

        private void cbOnion_CheckedChanged(object sender, EventArgs e)
        {
            cbOnion.ForeColor = Color.Green;
            UpdatePrice();
            UpdateToppings();
        }

        private void cbOlives_CheckedChanged(object sender, EventArgs e)
        {
            cbOlives.ForeColor = Color.Green;
            UpdatePrice();
            UpdateToppings();
        }

        private void cbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            cbMushrooms.ForeColor = Color.Green;
            UpdatePrice();
            UpdateToppings();

        }

        private void cbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            cbTomatoes.ForeColor = Color.Green;
            UpdateToppings();
            UpdatePrice();

        }

        private void cbGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            cbGreenPeppers.ForeColor = Color.Green;
            UpdatePrice();
            UpdateToppings();

        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWhrToEat.Text = rbEatIn.Text;
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWhrToEat.Text = rbTakeOut.Text;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            MessageBox.Show("Order Placed Successfully", "Successful", MessageBoxButtons.OK);

            gbCrust.Enabled = false;
            gbSize.Enabled = false;
            gbToppings.Enabled = false;
            gbWhereToEat.Enabled = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;
            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;
            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;

            
            cbExtraChees.Checked = false;
            cbMushrooms.Checked = false;
            cbTomatoes.Checked = false;
            cbOnion.Checked = false;
            cbOlives.Checked = false;
            cbGreenPeppers.Checked = false;

            
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;




            cbExtraChees.ForeColor = Color.Black;
            cbGreenPeppers.ForeColor = Color.Black;
            cbMushrooms.ForeColor = Color.Black;
            cbTomatoes.ForeColor = Color.Black;
            cbOlives.ForeColor = Color.Black;
            cbOnion.ForeColor = Color.Black;    
        }
    }
}