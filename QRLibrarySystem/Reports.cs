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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void LoadBranchInventory()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "BookTitle, " +
            "BranchName " +
            "FROM Books";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvBranchInventory.DataSource =
            dt;

            con.Close();
        }
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            LoadMostBorrowed();

            LoadDefaulters();

            LoadDailyTransactions();

            LoadInventory();

            LoadFineReport();

            LoadBranchInventory();
        }

        private void LoadMostBorrowed()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "b.BookTitle, " +
            "COUNT(*) AS BorrowCount " +
            "FROM Transactions t " +
            "INNER JOIN Books b " +
            "ON t.BookID=b.BookID " +
            "GROUP BY b.BookTitle " +
            "ORDER BY BorrowCount DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvMostBorrowed.DataSource =
            dt;

            con.Close();
        }

        private void LoadDefaulters()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "s.StudentName, " +
            "b.BookTitle, " +
            "t.DueDate " +
            "FROM Transactions t " +
            "INNER JOIN Students s " +
            "ON t.StudentID=s.StudentID " +
            "INNER JOIN Books b " +
            "ON t.BookID=b.BookID " +
            "WHERE t.Status='Issued' " +
            "AND t.DueDate < CURDATE()";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvDefaulters.DataSource =
            dt;

            con.Close();
        }

        private void LoadDailyTransactions()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT * " +
            "FROM Transactions " +
            "WHERE IssueDate=CURDATE()";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvTransactions.DataSource =
            dt;

            con.Close();
        }

        private void LoadInventory()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT * " +
            "FROM Books b " +
            "WHERE b.BookID NOT IN " +
            "(" +
            "SELECT BookID " +
            "FROM Transactions " +
            "WHERE Status='Issued'" +
            ")";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvInventory.DataSource =
            dt;

            con.Close();
        }

        private void LoadFineReport()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT " +
            "s.StudentName, " +
            "b.BookTitle, " +
            "t.FineAmount, " +
            "t.ReturnDate " +
            "FROM Transactions t " +
            "INNER JOIN Students s " +
            "ON t.StudentID=s.StudentID " +
            "INNER JOIN Books b " +
            "ON t.BookID=b.BookID " +
            "WHERE t.FineAmount > 0";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvFineReport.DataSource =
            dt;

            con.Close();
        }

        private void dgvMostBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
