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
    public partial class MyBooks : Form
    {
        public MyBooks()
        {
            InitializeComponent();
        }

        private void MyBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            try
            {
                con.Open();
                string query =
                "SELECT " +
                "t.TransactionID, " +
                "b.BookTitle, " +
                "t.IssueDate, " +
                "t.DueDate, " +
                "t.ReturnDate, " +
                "t.FineAmount, " +
                "b.BranchName, " +
                "b.BookTitle, " +

                "t.Status " +
                "FROM Transactions t " +
                "INNER JOIN Books b " +
                "ON t.BookID=b.BookID " +
                "WHERE t.StudentID=@sid " +
                "ORDER BY t.IssueDate DESC";

                MySqlDataAdapter da =
                new MySqlDataAdapter(
                query,
                con);

                da.SelectCommand.Parameters.AddWithValue(
                "@sid",
                StudentSession.StudentID);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvMyBooks.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            
    }
}
