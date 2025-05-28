using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class txtWaterFE : Form
    {
        public txtWaterFE()
        {
            InitializeComponent();
        }

        String ShowerUse;
        String ShowerMin;
        String GPM;
        String Daily;
        String Weekly;
        String Monthly;
        String Annually;



        private void txtBtnDonate_Click(object sender, EventArgs e)
        {
            Form2 donate = new Form2();
            donate.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ShowerUse = txtShowerUse.Text;
            ShowerMin = txtShowerMin.Text;
            GPM = txtGPM.Text;
            Daily = txtDaily.Text;
            Weekly = txtWeekly.Text;
            Monthly = txtMonthly.Text;
            Annually = txtAnnually.Text;

            if (!(String.IsNullOrWhiteSpace(txtShowerUse.Text)) && !(String.IsNullOrWhiteSpace(txtShowerMin.Text)) && !(String.IsNullOrWhiteSpace(txtGPM.Text)))
            {

                Daily = Convert.ToString((Convert.ToDecimal(ShowerMin) * Convert.ToDecimal(GPM)) * Convert.ToDecimal(ShowerUse));
                txtDaily.Text = Daily + " gallons";

                Weekly = Convert.ToString(((Convert.ToDecimal(ShowerMin) * Convert.ToDecimal(GPM)) * Convert.ToDecimal(ShowerUse)) * 7);
                txtWeekly.Text = Weekly + " gallons";

                Monthly = Convert.ToString(((Convert.ToDecimal(ShowerMin) * Convert.ToDecimal(GPM)) * Convert.ToDecimal(ShowerUse)) * 30);
                txtMonthly.Text = Monthly + " gallons";

                Annually = Convert.ToString((((Convert.ToDecimal(ShowerMin) * Convert.ToDecimal(GPM)) * Convert.ToDecimal(ShowerUse)) * 7) * 52);
                txtAnnually.Text = Annually + " gallons";
            }
            else 
            {
                MessageBox.Show("Please enter in required information.", "Error");
            }

           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtShowerUse.SelectedIndex = -1;
            txtGPM.SelectedIndex = -1;
            txtShowerMin.ResetText();
            txtDaily.ResetText();
            txtWeekly.ResetText();
            txtMonthly.ResetText();
            txtAnnually.ResetText();
        }

        private void txtShowerMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hamwells.com/en/reduce-your-carbon-footprint-with-hamwells-shower-systems/");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.conservationmart.com/blog/index.php/measuring-shower-water-usage-helps-save-water/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://worldoceansday.org/take-action/list-your-event/");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 FindEvent = new Form3();
            FindEvent.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.un.org/sustainabledevelopment/water-and-sanitation/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://worldoceansday.org/");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://sustainabledevelopment.un.org/sdg6");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.sdgfund.org/goal-6-clean-water-and-sanitation");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.hamwells.com/en/reduce-your-carbon-footprint-with-hamwells-shower-systems/");
        }
    }
}
