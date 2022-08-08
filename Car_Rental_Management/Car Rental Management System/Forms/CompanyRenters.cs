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
    public partial class CompanyRenters : Form
    {
        int uid;
        string name;
        public CompanyRenters()
        {
            InitializeComponent();
        }
        public CompanyRenters(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
        }

        private void CompanyRenters_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = name;

            UserRepo ur = new UserRepo();
            dataGridViewUsers.DataSource = ur.GetAllUsers();
            dataGridViewUsers.Columns[0].Visible = false;
            dataGridViewUsers.Columns[5].Visible = false;
            dataGridViewUsers.Columns[6].Visible = false;
        }

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
