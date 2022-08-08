using Car_Rental_Management_System.Entities;
using Car_Rental_Management_System.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental_Management_System.Forms
{
    public partial class CompanyAddANewCar : Form
    {
        int uid;
        string name;
        public CompanyAddANewCar()
        {
            InitializeComponent();
        }
        public CompanyAddANewCar(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
        }
        void CmbBrand()
        {
            cmbBrand.Items.Clear();
            cmbBrand.Items.Add("Audi");
            cmbBrand.Items.Add("Toyota");
            cmbBrand.Items.Add("Honda");
            cmbBrand.Items.Add("BMW");
            cmbBrand.Items.Add("Hyundai");
        }
        void CmbAvailable()
        {
            cmbAvailable.Items.Clear();
            cmbAvailable.Items.Add("Yes");
            cmbAvailable.Items.Add("No");
        }
        private void CompanyAddANewCar_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = name;
            CmbBrand();
            CmbAvailable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(txtModel.Text == "" || txtRegNo.Text =="" || txtRent.Text ==""|| cmbBrand.SelectedItem.ToString() == ""||cmbAvailable.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Missing Information.");
            }
            else
            {
                string brand = cmbBrand.SelectedItem.ToString();
                string model = txtModel.Text;
                string regno = txtRegNo.Text;
                int rent =  Convert.ToInt32(txtRent.Text);
                string available = cmbAvailable.SelectedItem.ToString();

                CarRepo cr = new CarRepo();
                int result = cr.AddNewCar(brand, model, regno,rent,available);
                if (result > 0)
                {
                    MessageBox.Show("Data Inserted");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
        void Clear()
        {
            CmbBrand();
            txtModel.Text = "";
            txtRegNo.Text = "";
            txtRent.Text = "";
            CmbAvailable();
        }
        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            CompanyDashboard cd = new CompanyDashboard(uid, name);
            this.Hide();
            cd.Show();
        }
    }
}
