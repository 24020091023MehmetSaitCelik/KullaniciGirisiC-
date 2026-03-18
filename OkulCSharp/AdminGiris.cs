using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OkulCSharp
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = DBConnection.Baglan();
                string sql = "SELECT * FROM Yoneticiler WHERE KullaniciAdi=@kullanici AND Sifre=@sifre";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kullanici", txtKullanici.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Admin girişi başarılı!");
                    new AdminPanel().Show();
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