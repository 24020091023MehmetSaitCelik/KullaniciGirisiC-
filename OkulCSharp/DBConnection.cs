using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OkulCSharp
{
    public class DBConnection
    {
        public static SqlConnection Baglan()
        {
            SqlConnection conn = null;
            try
            {
                string connStr = "Server=localhost,1433;Database=OkulDB;User Id=sa;Password=1234;TrustServerCertificate=True;";
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
            return conn;
        }
    }
}