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
    public partial class UserRentACar : Form
    {
        int uid;
        string name;

        int rent, theRent;
        string model, brand, regno;
        DateTime startingDay;
        DateTime returnDay;
        public UserRentACar()
        {
            InitializeComponent();
        }
        public UserRentACar(int uid, string name)
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
        void CmbBrand()
        {
            cmbBrand.Items.Clear();
            cmbBrand.Items.Add("Toyota");
            cmbBrand.Items.Add("Honda");
            cmbBrand.Items.Add("Audi");
            cmbBrand.Items.Add("Bmw");
            cmbBrand.Items.Add("Tata");
            cmbBrand.Items.Add("Hyundai");
        }
        private void UserRentACar_Load(object sender, EventArgs e)
        {
            lblUserName.Text = name;

            CmbBrand();
            CmdDay();
            btnConfirm.Hide();

            startingDay = DateTime.Today;
            lblStartingDateValue.Text = startingDay.ToString("d");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbBrand.Text == "")
            {
                MessageBox.Show("First Select a Brand");
            }
            else
            {
                string brand = cmbBrand.SelectedItem.ToString();
                string available = "Yes";

                CarRepo cr = new CarRepo();
                dataGridViewCars.DataSource = cr.GetAllAvailableCars(brand, available);
                dataGridViewCars.Columns[0].Visible = false;
                dataGridViewCars.Columns[5].Visible = false;
                CmbBrand();
            }
        }
        void CmdDay()
        {
            cmbDay.Items.Clear();
            cmbDay.Items.Add("1");
            cmbDay.Items.Add("2");
            cmbDay.Items.Add("3");
            cmbDay.Items.Add("4");
            cmbDay.Items.Add("5");
            cmbDay.Items.Add("6");
            cmbDay.Items.Add("7");
        }
        private void dataGridViewCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewCars.Rows[e.RowIndex];
                brand = row.Cells["Brand"].Value.ToString();
                model = row.Cells["Model"].Value.ToString();
                regno = row.Cells["RegNo"].Value.ToString();
                rent = Convert.ToInt32(row.Cells["Rent"].Value.ToString());
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string returnstatuse = "No";
            RentInfoRepo rip = new RentInfoRepo();
            int result = rip.AddNewRentInfo(brand, model, regno, uid, startingDay, returnDay, theRent, returnstatuse);

            if(result>0)
            {
                MessageBox.Show("Data Inserted");
                CarRepo crr = new CarRepo();
                string av = "No";
                crr.UpdateAvailable(regno, av);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            btnConfirm.Show();

            int day = Convert.ToInt32(cmbDay.SelectedItem.ToString());

            returnDay = startingDay.AddDays(day);
            lblReturnDateValue.Text = returnDay.ToString("d");

            theRent = GetTotalRent(day, rent);
            lblTotalRentValue.Text = theRent.ToString();
        }
        int GetTotalRent(int day, int rent)
        {
            int totalRent;
            if (day == 1) { return totalRent = day * rent; }
            else if (day == 2) { return totalRent = day * rent; }
            else if (day == 3) { return totalRent = (day * rent) - ((day * rent) * (10 / 100)); }
            else if (day == 4) { return totalRent = (day * rent) - ((day * rent) * (13 / 100)); }
            else if (day == 5) { return totalRent = (day * rent) - ((day * rent) * (15 / 100)); }
            else if (day == 6) { return totalRent = (day * rent) - ((day * rent) * (18 / 100)); }
            else if (day == 7) { return totalRent = (day * rent) - ((day * rent) * (20 / 100)); }
            else { return 0; }
        }
    }
}