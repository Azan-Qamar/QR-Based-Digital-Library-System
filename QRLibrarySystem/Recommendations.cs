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
    public partial class Recommendations : Form
    {
        public Recommendations()
        {
            InitializeComponent();
        }
        private void LoadRecommendations()
        {
            string department = "";

            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string deptQuery =
            "SELECT Department " +
            "FROM Students " +
            "WHERE StudentID=@sid";

            MySqlCommand deptCmd =
            new MySqlCommand(
            deptQuery,
            con);

            deptCmd.Parameters.AddWithValue(
            "@sid",
            StudentSession.StudentID);

            object deptResult =
            deptCmd.ExecuteScalar();

            if (deptResult != null)
            {
                department =
                deptResult.ToString();

                lblRecommendation.Text =
                "Recommended for " +
                department +
                " Students";
            }

            string query =
            "SELECT " +
            "b.BookTitle, " +
            "b.Category, " +
            "b.BranchName, " +
            "COUNT(t.BookID) AS Popularity " +
            "FROM Books b " +
            "LEFT JOIN Transactions t " +
            "ON b.BookID=t.BookID " +
            "GROUP BY b.BookID " +
            "ORDER BY Popularity DESC";

            MySqlDataAdapter da =
            new MySqlDataAdapter(
            query,
            con);

            da.SelectCommand.Parameters.AddWithValue(
            "@dept",
            "%" + department + "%");

            DataTable dt =
            new DataTable();

            da.Fill(dt);

            dgvRecommendations.DataSource =
            dt;

            con.Close();
        }
        private void Recommendations_Load(object sender, EventArgs e)
        {
            LoadRecommendations();
        }
    }
}
