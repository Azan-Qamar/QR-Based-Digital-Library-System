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
    public partial class ScanQR : Form
    {
        FilterInfoCollection cameras;
        VideoCaptureDevice camera;
        public ScanQR()
        {
            InitializeComponent();
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
        private void Camera_NewFrame(
          object sender,
          NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image =
            (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
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

        private void btnScan_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void ScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (camera != null &&
            camera.IsRunning)
            {
                camera.SignalToStop();
            }
        }

        private void btnIssueBook_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection con =
            db.GetConnection();

            con.Open();
            string countQuery =
            "SELECT COUNT(*) " +
            "FROM Transactions " +
            "WHERE StudentID=@sid " +
            "AND Status='Issued'";

            MySqlCommand countCmd =
            new MySqlCommand(countQuery, con);

            countCmd.Parameters.AddWithValue(
            "@sid",
            StudentSession.StudentID);

            int count =
            Convert.ToInt32(
            countCmd.ExecuteScalar());
            if (count >= 3)
            {
                MessageBox.Show(
                "Maximum 3 books allowed");

                con.Close();

                return;
            }
                string bookQuery =
                "SELECT BookID " +
                "FROM Books " +
                "WHERE BookCode=@code";

            MySqlCommand bookCmd =
            new MySqlCommand(bookQuery, con);

            bookCmd.Parameters.AddWithValue(
            "@code",
            txtQRResult.Text);

            object bookResult =
            bookCmd.ExecuteScalar();
            if (bookResult == null)
            {
                MessageBox.Show(
                "Book Not Found");

                con.Close();

                return;
            }
            int bookID =
            Convert.ToInt32(bookResult);
            string checkBook =
            "SELECT COUNT(*) " +
            "FROM Transactions " +
            "WHERE BookID=@bid " +
            "AND Status='Issued'";

            MySqlCommand checkCmd =
            new MySqlCommand(checkBook, con);

            checkCmd.Parameters.AddWithValue(
            "@bid",
            bookID);

            int bookCount =
            Convert.ToInt32(
            checkCmd.ExecuteScalar());
            if (bookCount > 0)
            {
                MessageBox.Show(
                "Book Already Issued");

                con.Close();

                return;
            }
            string trxID =
            "TRX" +
            DateTime.Now.Ticks.ToString();

            DateTime issueDate =
            DateTime.Now;

            DateTime dueDate =
            issueDate.AddDays(14);

            string issueQuery =
            "INSERT INTO Transactions " +
            "(TransactionID," +
            "StudentID," +
            "BookID," +
            "IssueDate," +
            "DueDate," +
            "Status) " +
            "VALUES " +
            "(@trx,@sid,@bid,@issue,@due,'Issued')";

            MySqlCommand issueCmd =
            new MySqlCommand(issueQuery, con);

            issueCmd.Parameters.AddWithValue(
            "@trx",
            trxID);

            issueCmd.Parameters.AddWithValue(
            "@sid",
            StudentSession.StudentID);

            issueCmd.Parameters.AddWithValue(
            "@bid",
            bookID);

            issueCmd.Parameters.AddWithValue(
            "@issue",
            issueDate);

            issueCmd.Parameters.AddWithValue(
            "@due",
            dueDate);

          

            issueCmd.ExecuteNonQuery();

            LoggingHelper.LogAction(
            StudentSession.StudentID,
            "BOOK ISSUE",
            "Issued Book QR: " +
            txtQRResult.Text);

            MessageBox.Show(
            "Book Issued Successfully\n\n" +
            "Transaction ID: " +
            "Transaction ID: " + trxID +
            "\nDue Date: " +
            dueDate.ToShortDateString());

            con.Close();
        }
    }
}
