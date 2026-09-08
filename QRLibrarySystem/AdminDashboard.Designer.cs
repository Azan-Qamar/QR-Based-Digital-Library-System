namespace QRLibrarySystem
{
    partial class AdminDashboard
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
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.lblOverdueBooks = new System.Windows.Forms.Label();
            this.lblBorrowers = new System.Windows.Forms.Label();
            this.lblFineCollection = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabAnalytics = new System.Windows.Forms.TabControl();
            this.tabStudents = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabTiming = new System.Windows.Forms.TabPage();
            this.tabDepartment = new System.Windows.Forms.TabPage();
            this.dgvActiveStudents = new System.Windows.Forms.DataGridView();
            this.dgvPopularBooks = new System.Windows.Forms.DataGridView();
            this.dgvPeakHours = new System.Windows.Forms.DataGridView();
            this.dgvDepartmentStats = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.btnArchiveManager = new System.Windows.Forms.Button();
            this.btnBackupGuide = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabAnalytics.SuspendLayout();
            this.tabStudents.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabTiming.SuspendLayout();
            this.tabDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeakHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentStats)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIssuedBooks
            // 
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBooks.Location = new System.Drawing.Point(83, 52);
            this.lblIssuedBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(312, 40);
            this.lblIssuedBooks.TabIndex = 0;
            this.lblIssuedBooks.Text = "Total Issued Books : 0";
            this.lblIssuedBooks.Click += new System.EventHandler(this.lblIssuedBooks_Click);
            // 
            // lblOverdueBooks
            // 
            this.lblOverdueBooks.AutoSize = true;
            this.lblOverdueBooks.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdueBooks.Location = new System.Drawing.Point(103, 43);
            this.lblOverdueBooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverdueBooks.Name = "lblOverdueBooks";
            this.lblOverdueBooks.Size = new System.Drawing.Size(268, 40);
            this.lblOverdueBooks.TabIndex = 1;
            this.lblOverdueBooks.Text = "Overdue Books : 0";
            // 
            // lblBorrowers
            // 
            this.lblBorrowers.AutoSize = true;
            this.lblBorrowers.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrowers.Location = new System.Drawing.Point(97, 53);
            this.lblBorrowers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowers.Name = "lblBorrowers";
            this.lblBorrowers.Size = new System.Drawing.Size(294, 40);
            this.lblBorrowers.TabIndex = 2;
            this.lblBorrowers.Text = "Active Borrowers : 0";
            // 
            // lblFineCollection
            // 
            this.lblFineCollection.AutoSize = true;
            this.lblFineCollection.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineCollection.Location = new System.Drawing.Point(102, 43);
            this.lblFineCollection.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFineCollection.Name = "lblFineCollection";
            this.lblFineCollection.Size = new System.Drawing.Size(300, 40);
            this.lblFineCollection.TabIndex = 3;
            this.lblFineCollection.Text = "Fine Collection : Rs.0";
            this.lblFineCollection.Click += new System.EventHandler(this.lblFineCollection_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(73, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(666, 65);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Library Analytics Dashboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblIssuedBooks);
            this.panel1.Location = new System.Drawing.Point(52, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 123);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.lblOverdueBooks);
            this.panel2.Location = new System.Drawing.Point(703, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 123);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.HotPink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.lblBorrowers);
            this.panel3.Location = new System.Drawing.Point(703, 281);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 122);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.lblFineCollection);
            this.panel4.Location = new System.Drawing.Point(52, 281);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(459, 122);
            this.panel4.TabIndex = 8;
            // 
            // tabAnalytics
            // 
            this.tabAnalytics.Controls.Add(this.tabStudents);
            this.tabAnalytics.Controls.Add(this.tabBooks);
            this.tabAnalytics.Controls.Add(this.tabTiming);
            this.tabAnalytics.Controls.Add(this.tabDepartment);
            this.tabAnalytics.Controls.Add(this.tabPage1);
            this.tabAnalytics.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAnalytics.Location = new System.Drawing.Point(48, 478);
            this.tabAnalytics.Name = "tabAnalytics";
            this.tabAnalytics.SelectedIndex = 0;
            this.tabAnalytics.Size = new System.Drawing.Size(746, 369);
            this.tabAnalytics.TabIndex = 10;
            // 
            // tabStudents
            // 
            this.tabStudents.Controls.Add(this.dgvActiveStudents);
            this.tabStudents.Location = new System.Drawing.Point(4, 29);
            this.tabStudents.Name = "tabStudents";
            this.tabStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudents.Size = new System.Drawing.Size(738, 336);
            this.tabStudents.TabIndex = 0;
            this.tabStudents.Text = "Active Students";
            this.tabStudents.UseVisualStyleBackColor = true;
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.dgvPopularBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 29);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(738, 336);
            this.tabBooks.TabIndex = 1;
            this.tabBooks.Text = "Popular Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // tabTiming
            // 
            this.tabTiming.Controls.Add(this.dgvPeakHours);
            this.tabTiming.Location = new System.Drawing.Point(4, 29);
            this.tabTiming.Name = "tabTiming";
            this.tabTiming.Padding = new System.Windows.Forms.Padding(3);
            this.tabTiming.Size = new System.Drawing.Size(738, 336);
            this.tabTiming.TabIndex = 2;
            this.tabTiming.Text = "Peak Hours";
            this.tabTiming.UseVisualStyleBackColor = true;
            // 
            // tabDepartment
            // 
            this.tabDepartment.Controls.Add(this.dgvDepartmentStats);
            this.tabDepartment.Location = new System.Drawing.Point(4, 29);
            this.tabDepartment.Name = "tabDepartment";
            this.tabDepartment.Padding = new System.Windows.Forms.Padding(3);
            this.tabDepartment.Size = new System.Drawing.Size(738, 336);
            this.tabDepartment.TabIndex = 3;
            this.tabDepartment.Text = "Department Status";
            this.tabDepartment.UseVisualStyleBackColor = true;
            // 
            // dgvActiveStudents
            // 
            this.dgvActiveStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActiveStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvActiveStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActiveStudents.GridColor = System.Drawing.Color.LightGray;
            this.dgvActiveStudents.Location = new System.Drawing.Point(7, 6);
            this.dgvActiveStudents.Name = "dgvActiveStudents";
            this.dgvActiveStudents.ReadOnly = true;
            this.dgvActiveStudents.Size = new System.Drawing.Size(695, 310);
            this.dgvActiveStudents.TabIndex = 0;
            // 
            // dgvPopularBooks
            // 
            this.dgvPopularBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPopularBooks.BackgroundColor = System.Drawing.Color.White;
            this.dgvPopularBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopularBooks.GridColor = System.Drawing.Color.LightGray;
            this.dgvPopularBooks.Location = new System.Drawing.Point(7, 6);
            this.dgvPopularBooks.Name = "dgvPopularBooks";
            this.dgvPopularBooks.ReadOnly = true;
            this.dgvPopularBooks.Size = new System.Drawing.Size(700, 321);
            this.dgvPopularBooks.TabIndex = 0;
            // 
            // dgvPeakHours
            // 
            this.dgvPeakHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPeakHours.BackgroundColor = System.Drawing.Color.White;
            this.dgvPeakHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeakHours.GridColor = System.Drawing.Color.LightGray;
            this.dgvPeakHours.Location = new System.Drawing.Point(7, 6);
            this.dgvPeakHours.Name = "dgvPeakHours";
            this.dgvPeakHours.ReadOnly = true;
            this.dgvPeakHours.Size = new System.Drawing.Size(685, 321);
            this.dgvPeakHours.TabIndex = 0;
            // 
            // dgvDepartmentStats
            // 
            this.dgvDepartmentStats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartmentStats.BackgroundColor = System.Drawing.Color.White;
            this.dgvDepartmentStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentStats.GridColor = System.Drawing.Color.LightGray;
            this.dgvDepartmentStats.Location = new System.Drawing.Point(6, 6);
            this.dgvDepartmentStats.Name = "dgvDepartmentStats";
            this.dgvDepartmentStats.ReadOnly = true;
            this.dgvDepartmentStats.Size = new System.Drawing.Size(675, 321);
            this.dgvDepartmentStats.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvLogs);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 336);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Activity Logs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvLogs
            // 
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.GridColor = System.Drawing.Color.LightGray;
            this.dgvLogs.Location = new System.Drawing.Point(7, 6);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.Size = new System.Drawing.Size(674, 321);
            this.dgvLogs.TabIndex = 0;
            // 
            // btnArchiveManager
            // 
            this.btnArchiveManager.BackColor = System.Drawing.Color.SlateBlue;
            this.btnArchiveManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchiveManager.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchiveManager.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnArchiveManager.Location = new System.Drawing.Point(496, 422);
            this.btnArchiveManager.Name = "btnArchiveManager";
            this.btnArchiveManager.Size = new System.Drawing.Size(187, 41);
            this.btnArchiveManager.TabIndex = 18;
            this.btnArchiveManager.Text = "Archive Manager";
            this.btnArchiveManager.UseVisualStyleBackColor = false;
            this.btnArchiveManager.Click += new System.EventHandler(this.btnArchiveManager_Click);
            // 
            // btnBackupGuide
            // 
            this.btnBackupGuide.BackColor = System.Drawing.Color.Violet;
            this.btnBackupGuide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupGuide.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupGuide.ForeColor = System.Drawing.Color.White;
            this.btnBackupGuide.Location = new System.Drawing.Point(808, 422);
            this.btnBackupGuide.Name = "btnBackupGuide";
            this.btnBackupGuide.Size = new System.Drawing.Size(186, 41);
            this.btnBackupGuide.TabIndex = 19;
            this.btnBackupGuide.Text = "Backup Guide";
            this.btnBackupGuide.UseVisualStyleBackColor = false;
            this.btnBackupGuide.Click += new System.EventHandler(this.btnBackupGuide_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::QRLibrarySystem.Properties.Resources.images__2_1;
            this.pictureBox5.Location = new System.Drawing.Point(760, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(112, 90);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::QRLibrarySystem.Properties.Resources.make_money;
            this.pictureBox3.Location = new System.Drawing.Point(3, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(82, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::QRLibrarySystem.Properties.Resources.png_clipart_person_logo_people_travel_text_rectangle_thumbnail;
            this.pictureBox4.Location = new System.Drawing.Point(12, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QRLibrarySystem.Properties.Resources._641328;
            this.pictureBox2.Location = new System.Drawing.Point(17, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QRLibrarySystem.Properties.Resources.books;
            this.pictureBox1.Location = new System.Drawing.Point(3, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(59, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 30);
            this.label1.TabIndex = 20;
            this.label1.Text = "System Activity Logs";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackupGuide);
            this.Controls.Add(this.btnArchiveManager);
            this.Controls.Add(this.tabAnalytics);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabAnalytics.ResumeLayout(false);
            this.tabStudents.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabTiming.ResumeLayout(false);
            this.tabDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActiveStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopularBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeakHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentStats)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.Label lblOverdueBooks;
        private System.Windows.Forms.Label lblBorrowers;
        private System.Windows.Forms.Label lblFineCollection;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabControl tabAnalytics;
        private System.Windows.Forms.TabPage tabStudents;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabTiming;
        private System.Windows.Forms.TabPage tabDepartment;
        private System.Windows.Forms.DataGridView dgvActiveStudents;
        private System.Windows.Forms.DataGridView dgvPopularBooks;
        private System.Windows.Forms.DataGridView dgvPeakHours;
        private System.Windows.Forms.DataGridView dgvDepartmentStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Button btnArchiveManager;
        private System.Windows.Forms.Button btnBackupGuide;
        private System.Windows.Forms.Label label1;
    }
}