using Car_Rental_Management_System.Entities;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPhone.Text == "" || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Phone or Password can not be empty.");
            }
            else
            {
                if (!Regex.Match(txtPhone.Text, @"^[0-9]{11}$").Success)
                {
                    MessageBox.Show("Please enter a valid Phone number");
                }
                else
                {
                    int phone = Convert.ToInt32(txtPhone.Text);
                    string password = txtPassword.Text;

                    UserEntity ue = new UserEntity();
                    ue.Phone = phone;
                    ue.Password = password;

                    LoginRepo lr = new LoginRepo();
                    UserEntity result = lr.LoginValidation(ue);

                    if (result == null)
                    {
                        MessageBox.Show("Invalid phone and password");
                    }
                    else
                    {
                        if (result.UserType == 1)
                        {
                            UserRepo ur = new UserRepo();
                            UserEntity ue1 = ur.GetUIdName(phone);

                            CompanyDashboard ch = new CompanyDashboard(ue1);
                            this.Hide();
                            ch.Show();
                        }
                        else if (result.UserType == 2)
                        {
                            UserRepo ur = new UserRepo();
                            UserEntity ue2 = ur.GetUIdName(phone);

                            UserDashboard uh = new UserDashboard(ue2);
                            this.Hide();
                            uh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid User");
                        }
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup s = new Signup();
            this.Hide();
            s.Show();
        }

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
