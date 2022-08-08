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
    public partial class UserDashboard : Form
    {
        int uid;
        string name;
        public UserDashboard()
        {
            InitializeComponent();
        }
        public UserDashboard(UserEntity ue)
        {
            InitializeComponent();
            this.uid = ue.UId;
            this.name = ue.Name;
        }
        public UserDashboard(int uid, string name)
        {
            InitializeComponent();
            this.uid = uid;
            this.name = name;
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserRentACar ura = new UserRentACar(uid, name);
            this.Hide();
            ura.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserRentedCars urc = new UserRentedCars(uid, name);
            this.Hide();
            urc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserHistory uh = new UserHistory(uid, name);
            this.Hide();
            uh.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblUserName.Text = name;
        }
    }
}
