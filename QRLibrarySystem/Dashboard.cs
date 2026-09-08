using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRLibrarySystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text =
            "Welcome " +
            StudentSession.StudentName;

            if (UserSession.Role == "Student")
            {
                btnAdminDashboard.Visible = false;

                btnReports.Visible = false;
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Admin admin =
            new Admin();

            admin.Show();
        }

        private void btnScanQR_Click(object sender, EventArgs e)
        {
            ScanQR scanQR = new ScanQR();
            scanQR.Show();
        }

        private void btnMyBooks_Click(object sender, EventArgs e)
        {
            MyBooks books =
            new MyBooks();

            books.Show();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook rb =
            new ReturnBook();

            rb.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login =
            new Form1();

            login.Show();

            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard ad =
            new AdminDashboard();

            ad.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports r =
            new Reports();

            r.Show();
        }

        private void btnRecommendations_Click(object sender, EventArgs e)
        {
            Recommendations r =
            new Recommendations();

            r.Show();
        }

        private void btnArchiveManager_Click(object sender, EventArgs e)
        {
            ArchiveManager archive =
            new ArchiveManager();

            archive.Show();
        }
    }
}
