using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        String FirstName;
        String LastName;
        String Address;
        String City;
        String State;
        String Zip;
        String Phone;
        String Email;
        String Amount;
        String Card;
        String Expiry1;
        String Expiry2;
        String CVV2;

        private void button1_Click(object sender, EventArgs e)
        {
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            Address = txtAddress.Text;
            City = txtCity.Text;
            State = txtState.Text;
            Zip = txtZip.Text;
            Phone = txtPhone.Text;
            Email = txtEmail.Text;
            Amount = txtAmount.Text;
            Card = txtCard.Text;
            Expiry1 = txtExpiry1.Text;
            Expiry2 = txtExpiry2.Text;
            CVV2 = txtCVV2.Text;

            if (Phone == "") 
            {
                Phone = "Not Given";
            }

            if (Email == "")
            {
                Email = "Not Given";
            }

            if (!(String.IsNullOrWhiteSpace(txtFirstName.Text)) && !(String.IsNullOrWhiteSpace(txtLastName.Text)) && !(String.IsNullOrWhiteSpace(txtAddress.Text)) && !(String.IsNullOrWhiteSpace(txtCity.Text)) && !(String.IsNullOrWhiteSpace(txtState.Text)) && !(String.IsNullOrWhiteSpace(txtZip.Text)) && !(String.IsNullOrWhiteSpace(txtAmount.Text)) && !(String.IsNullOrWhiteSpace(txtCard.Text)) && !(String.IsNullOrWhiteSpace(txtExpiry1.Text)) && !(String.IsNullOrWhiteSpace(txtExpiry2.Text)))
            {
                MessageBox.Show($"First Name: {FirstName}\nLast Name: {LastName}\nAddress: {Address}\nCity: {City}\nState: {State}\nZip: {Zip}\nPhone: {Phone}\nEmail: {Email}\nCard Number: {Card}\nCard expiration date: {Expiry1} {Expiry2}\nCVV2: {CVV2}\n", "Your Information");
                MessageBox.Show($"Hello {FirstName} {LastName},\nThank you for donating ${Amount} to World Oceans Day organization!\nWe appreciate your contribution to protecting our environment!", "Thank you!");
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

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
                e.Handled = true;
        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
