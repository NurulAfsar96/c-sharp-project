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
    public partial class CompanyCars : Form
    {
        int uid;
        string name;
        string regno;
        public CompanyCars()
        {
            InitializeComponent();
        }
        public CompanyCars(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
        }
        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                regno = row.Cells["RegNo"].Value.ToString();

                CarRepo cr = new CarRepo();
                CarEntity result = cr.GetCarInfo(regno);

                txtRent.Text = result.Rent.ToString();
                txtAvailable.Text = result.Available;
            }
        }

        private void CompanyCars_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = name;

            CarRepo cr = new CarRepo();
            dataGridView1.DataSource = cr.GetAllCars();
            dataGridView1.Columns[0].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rent = Convert.ToInt32(txtRent.Text);
            string available = txtAvailable.Text;

            CarRepo cr = new CarRepo();
            int result = cr.UpdateRentAndAvailable(regno, rent, available);

            if(result>0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CarRepo cr = new CarRepo();
            int result = cr.DeleteCarInfo(regno);

            if(result > 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Error");
            }
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

        private void txtRent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
