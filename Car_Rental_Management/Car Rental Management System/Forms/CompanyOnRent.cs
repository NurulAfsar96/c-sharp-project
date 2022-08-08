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
    public partial class CompanyOnRent : Form
    {
        int uid;
        string name;
        string regno="";
        public CompanyOnRent()
        {
            InitializeComponent();
        }
        public CompanyOnRent(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
        }
        private void CompanyOnRent_Load(object sender, EventArgs e)
        {
            lblCompanyName.Text = name;

            RentInfoRepo rip = new RentInfoRepo();
            dataGridView1.DataSource = rip.GetAllRentInfo();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[8].Visible = false;
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

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnMakeAvailable_Click(object sender, EventArgs e)
        {
            if(regno == "")
            {
                MessageBox.Show("Select First");
            }
            else
            {
                CarRepo cr = new CarRepo();
                string availavle = "Yes";
                int result = cr.UpdateAvailable(regno, availavle);
                if(result>0)
                {
                    MessageBox.Show("The Car is now Available");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                regno = row.Cells["RegNo1"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string regno1 = row.Cells["RegNo1"].Value.ToString();

                RentInfoRepo rif = new RentInfoRepo();
                RentInfoEntity result = rif.GetUIdByRegNo(regno1);

                UserRepo ur = new UserRepo();
                UserEntity ue = ur.GeUserByUserId(result.UId);

                string show= "Renter: "+ue.Name+"\n";
                show += "Email: "+ue.Email+"\n";
                show += "Phone: "+ue.Phone+"\n";
                show += "Address: "+ue.Address+"\n";

                MessageBox.Show(show);
            }
        }
    }
}
