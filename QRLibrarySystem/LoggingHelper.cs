using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace QRLibrarySystem
{
    public class LoggingHelper
    {
        public static void LogAction(
            int studentId,
            string actionType,
            string description)
        {
            try
            {
                DBConnection db =
                new DBConnection();

                MySqlConnection con =
                db.GetConnection();

                con.Open();

                string query =
                "INSERT INTO ActivityLogs " +
                "(StudentID,ActionType," +
                "ActionDescription,ActionTime) " +
                "VALUES " +
                "(@sid,@type,@desc,NOW())";

                MySqlCommand cmd =
                new MySqlCommand(
                query,
                con);

                cmd.Parameters.AddWithValue(
                "@sid",
                studentId);

                cmd.Parameters.AddWithValue(
                "@type",
                actionType);

                cmd.Parameters.AddWithValue(
                "@desc",
                description);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void LogFailedAttempt(
        string universityId)
        {
            try
            {
                DBConnection db =
                new DBConnection();

                MySqlConnection con =
                db.GetConnection();

                con.Open();

                string query =
                "INSERT INTO ActivityLogs " +
                "(StudentID, ActionType, " +
                "ActionDescription, ActionTime) " +
                "VALUES " +
                "(NULL, 'FAILED ATTEMPT', " +
                "@desc, NOW())";

                MySqlCommand cmd =
                new MySqlCommand(
                query,
                con);

                cmd.Parameters.AddWithValue(
                "@desc",
                universityId);

                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
