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
    public partial class UserRentedCars : Form
    {
        int uid;
        string name;
        string regno = "";
        public UserRentedCars()
        {
            InitializeComponent();
        }
        public UserRentedCars(int uid, string name)
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

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard(uid, name);
            this.Hide();
            ud.Show();
        }

        private void UserRentedCars_Load(object sender, EventArgs e)
        {
            lblUserName.Text = name;

            RentInfoRepo ri = new RentInfoRepo();
            dataGridView1.DataSource = ri.GetAllRentInfoByUser(uid);
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                regno = row.Cells["RegNo2"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (regno == "")
            {
                MessageBox.Show("Select First");
            }
            else
            {
                RentInfoRepo cer = new RentInfoRepo();
                string returnStatus = "Yes";
                int result = cer.UpdateReturnStatus(regno, returnStatus);
                if (result > 0)
                {
                    MessageBox.Show("The Car is Returned");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
