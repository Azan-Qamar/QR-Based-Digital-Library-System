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
using QRCoder;

namespace QRLibrarySystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnSaveBook_Click(object sender, EventArgs e)
        {
            DBConnection db = new DBConnection();

            MySqlConnection con = db.GetConnection();

            try
            {
                con.Open();

                string query =
                "INSERT INTO Books(BookCode,BookTitle,Author) " +
                "VALUES(@code,@title,@author)";

                MySqlCommand cmd =
                new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue("@code",
                txtBookCode.Text);

                cmd.Parameters.AddWithValue("@title",
                txtBookTitle.Text);

                cmd.Parameters.AddWithValue("@author",
                txtAuthor.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Book Saved");

                LoadBooks();
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qrGenerator =
            new QRCodeGenerator();

            QRCodeData qrCodeData =
            qrGenerator.CreateQrCode(
            txtBookCode.Text,
            QRCodeGenerator.ECCLevel.Q);

            QRCode qrCode =
            new QRCode(qrCodeData);

            Bitmap qrImage =
            qrCode.GetGraphic(20);

            pictureBoxQR.Image = qrImage;

            string path =
            Application.StartupPath +
            "\\QRImages\\" +
            txtBookCode.Text +
            ".png";

            qrImage.Save(path);

            MessageBox.Show("QR Saved");
        }

        private void Admin_Load(object sender, EventArgs e)
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
                "SELECT BookID, BookCode, BookTitle, Author " +
                "FROM Books";

                MySqlDataAdapter da =
                new MySqlDataAdapter(query, con);

                DataTable dt =
                new DataTable();

                da.Fill(dt);

                dgvBooks.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
