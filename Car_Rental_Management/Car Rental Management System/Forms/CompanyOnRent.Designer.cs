
namespace Car_Rental_Management_System.Forms
{
    partial class CompanyOnRent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExitApplication = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMakeAvailable = new System.Windows.Forms.Button();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Brand1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegNo1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnDate1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnStatuse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel1.Controls.Add(this.lblExitApplication);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 53);
            this.panel1.TabIndex = 13;
            // 
            // lblExitApplication
            // 
            this.lblExitApplication.AutoSize = true;
            this.lblExitApplication.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExitApplication.ForeColor = System.Drawing.Color.Red;
            this.lblExitApplication.Location = new System.Drawing.Point(573, 7);
            this.lblExitApplication.Name = "lblExitApplication";
            this.lblExitApplication.Size = new System.Drawing.Size(33, 37);
            this.lblExitApplication.TabIndex = 3;
            this.lblExitApplication.Text = "X";
            this.lblExitApplication.Click += new System.EventHandler(this.lblExitApplication_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblCompanyName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompanyName.ForeColor = System.Drawing.Color.Aqua;
            this.lblCompanyName.Location = new System.Drawing.Point(282, 29);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(83, 23);
            this.lblCompanyName.TabIndex = 2;
            this.lblCompanyName.Text = "Company";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(205, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome,  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(149, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Rental Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 360);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 15);
            this.panel2.TabIndex = 14;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(205, 322);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(111, 33);
            this.btnDashboard.TabIndex = 34;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(332, 322);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 33);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMakeAvailable
            // 
            this.btnMakeAvailable.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnMakeAvailable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMakeAvailable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMakeAvailable.ForeColor = System.Drawing.Color.White;
            this.btnMakeAvailable.Location = new System.Drawing.Point(475, 280);
            this.btnMakeAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMakeAvailable.Name = "btnMakeAvailable";
            this.btnMakeAvailable.Size = new System.Drawing.Size(112, 30);
            this.btnMakeAvailable.TabIndex = 36;
            this.btnMakeAvailable.Text = "Make Available";
            this.btnMakeAvailable.UseVisualStyleBackColor = false;
            this.btnMakeAvailable.Click += new System.EventHandler(this.btnMakeAvailable_Click);
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            // 
            // RegNo
            // 
            this.RegNo.DataPropertyName = "RegNo";
            this.RegNo.HeaderText = "RegNo";
            this.RegNo.Name = "RegNo";
            // 
            // RentDate
            // 
            this.RentDate.DataPropertyName = "RentDate";
            this.RentDate.HeaderText = "RentDate";
            this.RentDate.Name = "RentDate";
            // 
            // ReturnDate
            // 
            this.ReturnDate.DataPropertyName = "ReturnDate";
            this.ReturnDate.HeaderText = "ReturnDate";
            this.ReturnDate.Name = "ReturnDate";
            // 
            // Rent
            // 
            this.Rent.DataPropertyName = "RentFee";
            this.Rent.HeaderText = "Rent";
            this.Rent.Name = "Rent";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brand1,
            this.Model1,
            this.RegNo1,
            this.RentDate1,
            this.ReturnDate1,
            this.RentFee,
            this.ReturnStatuse});
            this.dataGridView1.Location = new System.Drawing.Point(26, 97);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(561, 172);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // Brand1
            // 
            this.Brand1.DataPropertyName = "Brand";
            this.Brand1.HeaderText = "Brand";
            this.Brand1.Name = "Brand1";
            this.Brand1.Width = 90;
            // 
            // Model1
            // 
            this.Model1.DataPropertyName = "Model";
            this.Model1.HeaderText = "Model";
            this.Model1.Name = "Model1";
            // 
            // RegNo1
            // 
            this.RegNo1.DataPropertyName = "RegNo";
            this.RegNo1.HeaderText = "RegNo";
            this.RegNo1.Name = "RegNo1";
            this.RegNo1.Width = 105;
            // 
            // RentDate1
            // 
            this.RentDate1.DataPropertyName = "RentDate";
            this.RentDate1.HeaderText = "RentDate";
            this.RentDate1.Name = "RentDate1";
            this.RentDate1.Width = 88;
            // 
            // ReturnDate1
            // 
            this.ReturnDate1.DataPropertyName = "ReturnDate";
            this.ReturnDate1.HeaderText = "ReturnDate";
            this.ReturnDate1.Name = "ReturnDate1";
            this.ReturnDate1.Width = 88;
            // 
            // RentFee
            // 
            this.RentFee.DataPropertyName = "RentFee";
            this.RentFee.HeaderText = "RentFee";
            this.RentFee.Name = "RentFee";
            this.RentFee.Width = 70;
            // 
            // ReturnStatuse
            // 
            this.ReturnStatuse.DataPropertyName = "ReturnStatuse";
            this.ReturnStatuse.HeaderText = "ReturnStatus";
            this.ReturnStatuse.Name = "ReturnStatuse";
            this.ReturnStatuse.Width = 99;
            // 
            // CompanyOnRent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 375);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMakeAvailable);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompanyOnRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompanyOnRent";
            this.Load += new System.EventHandler(this.CompanyOnRent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblExitApplication;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMakeAvailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegNo1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnStatuse;
    }
}