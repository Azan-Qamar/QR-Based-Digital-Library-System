using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using MySql.Data.MySqlClient;

namespace QRLibrarySystem
{
    public partial class ReturnBook : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice camera;

        private void Camera_NewFrame(
          object sender,
          NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image =
            (Bitmap)eventArgs.Frame.Clone();
        }


        public ReturnBook()
        {
            InitializeComponent();
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            DBConnection db =
            new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();

            string bookQuery =
            "SELECT BookID " +
            "FROM Books " +
            "WHERE BookCode=@code";

            MySqlCommand bookCmd =
            new MySqlCommand(bookQuery, con);

            bookCmd.Parameters.AddWithValue(
            "@code",
            txtQRResult.Text);

            object result =
            bookCmd.ExecuteScalar();

            if (result == null)
            {
                MessageBox.Show(
                "Book Not Found");

                con.Close();

                return;
            }

            int bookID =
            Convert.ToInt32(result);

            string checkQuery =
            "SELECT TransactionID, DueDate " +
            "FROM Transactions " +
            "WHERE BookID=@bid " +
            "AND Status='Issued'";

            MySqlCommand checkCmd =
            new MySqlCommand(
            checkQuery,
            con);

            checkCmd.Parameters.AddWithValue(
            "@bid",
            bookID);

            MySqlDataReader reader =
            checkCmd.ExecuteReader();

            if (!reader.Read())
            {
                MessageBox.Show(
                "Book Already Returned");

                reader.Close();
                con.Close();

                return;
            }

            string transactionID =
            reader["TransactionID"].ToString();

            DateTime dueDate =
            Convert.ToDateTime(
            reader["DueDate"]);

            reader.Close();

            DateTime returnDate =
            DateTime.Today;

            int lateDays = 0;

            if (returnDate > dueDate)
            {
                lateDays =
                (returnDate - dueDate).Days;
            }

            decimal fineAmount =
            lateDays * 20;

            string updateQuery =
            "UPDATE Transactions " +
            "SET Status='Returned', " +
            "ReturnDate=@returnDate, " +
            "FineAmount=@fine " +
            "WHERE TransactionID=@trx";

            MySqlCommand updateCmd =
            new MySqlCommand(
            updateQuery,
            con);

            updateCmd.Parameters.AddWithValue(
            "@trx",
            transactionID);

            updateCmd.Parameters.AddWithValue(
            "@returnDate",
            returnDate);

            updateCmd.Parameters.AddWithValue(
            "@fine",
            fineAmount);

            updateCmd.ExecuteNonQuery();

            LoggingHelper.LogAction(
            StudentSession.StudentID,
            "BOOK RETURN",
            txtQRResult.Text);

            if (fineAmount > 0)
            {
                LoggingHelper.LogAction(
                StudentSession.StudentID,
                "FINE PAYMENT",
                "Fine = Rs." + fineAmount);
            }

            MessageBox.Show(
            "Book Returned Successfully\n\n" +
            "Late Days: " +
            lateDays +
            "\nFine: Rs." +
            fineAmount);

            con.Close();
        }

        private void btnStartCamera_Click(object sender, EventArgs e)
        {
            cameras = new FilterInfoCollection(
            FilterCategory.VideoInputDevice);

            if (cameras.Count > 0)
            {
                camera = new VideoCaptureDevice(
                    cameras[0].MonikerString);

                camera.NewFrame += Camera_NewFrame;

                camera.Start();
                timer1.Start();
            }
            else
            {
                MessageBox.Show("No Camera Found");
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (pictureBoxCamera.Image != null)
            {
                BarcodeReader reader =
                new BarcodeReader();

                Result result =
                reader.Decode(
                (Bitmap)pictureBoxCamera.Image);

                if (result != null)
                {
                    txtQRResult.Text =
                    result.Text;

                    timer1.Stop();

                    if (camera.IsRunning)
                    {
                        camera.SignalToStop();
                    }

                    MessageBox.Show(
                    "QR Detected");
                }
            }
        }

        private void ReturnBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera != null &&
            camera.IsRunning)
            {
                camera.SignalToStop();
            }
        }
    }
}
