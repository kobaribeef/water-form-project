using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        String FirstName;
        String LastName;
        String Address;
        String City;
        String State;
        String ZIP;
        String Phone;
        String Email;

        private void button1_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            Address = txtAddress.Text;
            City = txtCity.Text;
            State = txtState.Text;
            ZIP = txtZIP.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;

            if (!(String.IsNullOrWhiteSpace(txtFirstName.Text)) && !(String.IsNullOrWhiteSpace(txtLastName.Text)) && !(String.IsNullOrWhiteSpace(txtAddress.Text)) && !(String.IsNullOrWhiteSpace(txtCity.Text)) && !(String.IsNullOrWhiteSpace(txtState.Text)) && !(String.IsNullOrWhiteSpace(txtZIP.Text)) && !(String.IsNullOrWhiteSpace(txtPhone.Text)) && !(String.IsNullOrWhiteSpace(txtEmail.Text)))
            {
                if (BS.Checked == true)
                {
                    MessageBox.Show($"Thank you {FirstName} {LastName} for protecting our environment with Beach Sweeps!  We look forward to seeing you!\nTo learn more about Beach Sweeps click the help button below otherwise click on OK to finish!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://cleanoceanaction.org/index.php?id=153", "keyword");
                }
                else if (CFOC.Checked == true)
                {
                    MessageBox.Show($"Thank you {FirstName} {LastName} for protecting our environment with Caring for our Coast!  We look forward to seeing you!\nTo learn more about Caring for our Coast click the help button below otherwise click on OK to finish!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "http://www.ncaquariums.com/", "keyword");
                }
                else if (WODTC.Checked == true)
                {
                    MessageBox.Show($"Thank you {FirstName} {LastName} for protecting our environment with World Oceans Day!  We look forward to seeing you!\nTo learn more about World Oceans Day click the help button below otherwise click on OK to finish!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://worldoceansday.org/event/world-oceans-day-tribal-celebration/", "keyword");
                }
                else if (TOF.Checked == true)
                {
                    MessageBox.Show($"Thank you {FirstName} {LastName} for protecting our environment with Tacoma Ocean Fest!  We look forward to seeing you!\nTo learn more about Tacoma Ocean Fest click the help button below otherwise click on OK to finish!", "Thank you", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, 0, "https://tacomaoceanfest.org/", "keyword");
                }
                this.Close();
            }
            else 
            {
                MessageBox.Show("Please enter in required information.", "Error");
            }
         
         }




        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txtZIP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
        }
    }
}
