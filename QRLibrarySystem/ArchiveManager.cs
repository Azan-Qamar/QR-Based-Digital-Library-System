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
    public partial class ArchiveManager : Form
    {
        public ArchiveManager()
        {
            InitializeComponent();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string insertQuery =
            "INSERT INTO ArchivedTransactions " +
            "(TransactionID,StudentID,BookID," +
            "IssueDate,DueDate,ReturnDate," +
            "FineAmount,Status,ArchivedOn) " +
            "SELECT " +
            "TransactionID,StudentID,BookID," +
            "IssueDate,DueDate,ReturnDate," +
            "FineAmount,Status,NOW() " +
            "FROM Transactions " +
            "WHERE Status='Returned'";

            MySqlCommand insertCmd =
            new MySqlCommand(
            insertQuery,
            con);

            int archived =
            insertCmd.ExecuteNonQuery();

            string deleteQuery =
            "DELETE FROM Transactions " +
            "WHERE Status='Returned'";

            MySqlCommand deleteCmd =
            new MySqlCommand(
            deleteQuery,
            con);

            deleteCmd.ExecuteNonQuery();

            MessageBox.Show(
            archived +
            " records archived");

            con.Close();

            LoadArchiveData();
        }

        private void LoadArchiveData()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string query =
            "SELECT * " +
            "FROM ArchivedTransactions " +
            "ORDER BY ArchivedOn DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvArchive.DataSource =
            dt;

            con.Close();
        }

        private void ArchiveManager_Load(object sender, EventArgs e)
        {
            LoadArchiveData();
        }
    }
}
