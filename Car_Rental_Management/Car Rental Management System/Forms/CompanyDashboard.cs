using Car_Rental_Management_System.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental_Management_System.Forms
{
    public partial class CompanyDashboard : Form
    {
        int uid;
        string name;
        public CompanyDashboard()
        {
            InitializeComponent();
        }
        public CompanyDashboard(UserEntity ue)
        {
            InitializeComponent();
            this.uid = ue.UId;
            this.name = ue.Name;
        }
        public CompanyDashboard(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CompanyAddANewCar cnc = new CompanyAddANewCar(uid, name);
            this.Hide();
            cnc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CompanyCars cc = new CompanyCars(uid, name);
            this.Hide();
            cc.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyOnRent cor = new CompanyOnRent(uid, name);
            this.Hide();
            cor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CompanyRenters cr = new CompanyRenters(uid, name);
            this.Hide();
            cr.Show();
        }

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CompanyDashboard_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = name;
        }
    }
}
