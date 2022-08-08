using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Car_Rental_Management_System.Forms
{
    public partial class UserHistory : Form
    {
        int uid;
        string name;
        public UserHistory()
        {
            InitializeComponent();
        }
        public UserHistory(int uid, string name)
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard(uid, name);
            this.Hide();
            ud.Show();
        }

        private void lblExitApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UserHistory_Load(object sender, EventArgs e)
        {
            lblUserName.Text = name;
        }
    }
}
