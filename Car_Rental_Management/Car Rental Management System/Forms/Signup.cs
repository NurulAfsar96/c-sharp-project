using Car_Rental_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Car_Rental_Management_System.Forms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtPhone.Text == "" || txtAddress.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Requirement must be fillup");
            }
            else
            {
                string name = txtName.Text;
                string email = txtEmail.Text;
                int phone = Convert.ToInt32(txtPhone.Text);
                string address = txtAddress.Text;
                string password = txtPassword.Text;
                int usertype = 2;

                if (!Regex.Match(name, "^[A-Z][a-zA-Z]*$").Success)
                {
                    MessageBox.Show("Please enter a valid name");
                }
                else
                {
                    SignupRepo sr = new SignupRepo();
                    int result = sr.Register(name, email, phone, address, password, usertype);

                    if (result > 0)
                    {
                        MessageBox.Show("Registration complete");
                        Login l = new Login();
                        this.Hide();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Wrong Input!!! Character Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            this.Hide();
            lo.Show();
        }

       /* private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) &&!Char.IsLower(e.KeyChar))
            {
                e.Handled = true;
                DialogResult dia = MessageBox.Show("Wrong Input!!! LowerCase Character Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/
    }
}