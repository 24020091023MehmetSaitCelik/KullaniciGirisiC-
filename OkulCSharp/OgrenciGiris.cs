using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OkulCSharp
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DBConnection.Baglan();
                string sql = "SELECT * FROM Ogrenciler WHERE Numara=@numara AND Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@numara", txtNo.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş başarılı!");
                    new OgrenciPanel().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş!");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}