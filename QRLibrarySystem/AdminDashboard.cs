using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace QRLibrarySystem
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadIssuedBooks();

            LoadOverdueBooks();

            LoadBorrowers();

            LoadFineCollection();

            LoadActiveStudents();

            LoadPopularBooks();

            LoadPeakHours();

            LoadDepartmentStats();

            LoadLogs();
        }

        private void LoadIssuedBooks()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT COUNT(*) " +
            "FROM Transactions " +
            "WHERE Status='Issued'";

            MySqlCommand cmd =
            new MySqlCommand(
            query,
            con);

            int total =
            Convert.ToInt32(
            cmd.ExecuteScalar());

            lblIssuedBooks.Text =
            "Total Issued Books : " +
            total;

            con.Close();
        }

        private void LoadOverdueBooks()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT COUNT(*) " +
            "FROM Transactions " +
            "WHERE Status='Issued' " +
            "AND DueDate < CURDATE()";

            MySqlCommand cmd =
            new MySqlCommand(
            query,
            con);

            int total =
            Convert.ToInt32(
            cmd.ExecuteScalar());

            lblOverdueBooks.Text =
            "Overdue Books : " +
            total;

            con.Close();
        }

        private void LoadBorrowers()
        {
            DBConnection db =
           new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT COUNT(DISTINCT StudentID) " +
            "FROM Transactions " +
            "WHERE Status='Issued'";

            MySqlCommand cmd =
            new MySqlCommand(
            query,
            con);

            int total =
            Convert.ToInt32(
            cmd.ExecuteScalar());

            lblBorrowers.Text =
            "Active Borrowers : " +
            total;

            con.Close();
        }

        private void LoadFineCollection()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT IFNULL(SUM(FineAmount),0) " +
            "FROM Transactions";

            MySqlCommand cmd =
            new MySqlCommand(
            query,
            con);

            decimal total =
            Convert.ToDecimal(
            cmd.ExecuteScalar());

            lblFineCollection.Text =
            "Fine Collection : Rs." +
            total;

            con.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblIssuedBooks_Click(object sender, EventArgs e)
        {

        }

        private void lblFineCollection_Click(object sender, EventArgs e)
        {

        }
        private void LoadActiveStudents()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "s.StudentName, " +
            "COUNT(*) AS TotalBorrowed " +
            "FROM Transactions t " +
            "INNER JOIN Students s " +
            "ON t.StudentID=s.StudentID " +
            "GROUP BY s.StudentID " +
            "ORDER BY TotalBorrowed DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvActiveStudents.DataSource =
            dt;

            con.Close();
        }

        private void LoadPopularBooks()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "b.BookTitle, " +
            "COUNT(*) AS TimesIssued " +
            "FROM Transactions t " +
            "INNER JOIN Books b " +
            "ON t.BookID=b.BookID " +
            "GROUP BY b.BookID " +
            "ORDER BY TimesIssued DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvPopularBooks.DataSource =
            dt;

            con.Close();
        }

        private void LoadPeakHours()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "IssueDate, " +
            "COUNT(*) AS TotalIssues " +
            "FROM Transactions " +
            "GROUP BY IssueDate " +
            "ORDER BY TotalIssues DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvPeakHours.DataSource =
            dt;

            con.Close();
        }

        private void LoadDepartmentStats()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "s.Department, " +
            "COUNT(*) AS TotalIssues " +
            "FROM Transactions t " +
            "INNER JOIN Students s " +
            "ON t.StudentID=s.StudentID " +
            "GROUP BY s.Department";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvDepartmentStats.DataSource =
            dt;

            con.Close();
        }
        private void LoadLogs()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT * " +
            "FROM ActivityLogs " +
            "ORDER BY ActionTime DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvLogs.DataSource =
            dt;

            con.Close();
        }

        private void btnArchiveManager_Click(object sender, EventArgs e)
        {
            ArchiveManager archive =
            new ArchiveManager();

            LoggingHelper.LogAction(
            StudentSession.StudentID,
            "ARCHIVE",
            "Archived Transactions");

            archive.Show();
        }

        private void btnBackupGuide_Click(object sender, EventArgs e)
        {
            BackupGuide guide =
            new BackupGuide();

            guide.Show();
        }
    }
}
