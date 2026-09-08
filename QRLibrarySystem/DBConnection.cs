using MySql.Data.MySqlClient;
using System.Configuration;

namespace QRLibrarySystem
{
    class DBConnection
    {
        public MySqlConnection GetConnection()
        {
            string connectionString =
            ConfigurationManager.ConnectionStrings["QRLibraryConnection"].ConnectionString;


        MySqlConnection con = new MySqlConnection(connectionString);

            return con;
        }
    }


}
