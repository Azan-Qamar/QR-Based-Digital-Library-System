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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection con = db.GetConnection();

            try
            {
                con.Open();

                string query =
                "SELECT * FROM Students " +
                "WHERE UniversityID=@id " +
                "AND Password=@pass " +
                "AND Status='Active'";

                MySqlCommand cmd =
                new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@id",
                txtUniversityID.Text);

                cmd.Parameters.AddWithValue("@pass",
                txtPassword.Text);

                MySqlDataReader dr =
                cmd.ExecuteReader();

                if (dr.Read())
                {
                   
                    StudentSession.StudentID =
                    Convert.ToInt32(dr["StudentID"]);

                    StudentSession.StudentName =
                    dr["StudentName"].ToString();

                    StudentSession.UniversityID =
                    dr["UniversityID"].ToString();

                    UserSession.Role =
                    dr["Role"].ToString();

                    LoggingHelper.LogAction(
                    StudentSession.StudentID,
                    "LOGIN",
                    "Successful Login");

                    Dashboard dashboard =
                    new Dashboard();

                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    LoggingHelper.LogFailedAttempt(
                    txtUniversityID.Text);

                    MessageBox.Show(
                    "Invalid Login");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
