namespace OkulCSharp
{
    partial class AdminGiris
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblKullanici
            this.lblKullanici.Text = "Kullanıcı:";
            this.lblKullanici.Location = new System.Drawing.Point(20, 30);
            this.lblKullanici.Size = new System.Drawing.Size(70, 25);
            // txtKullanici
            this.txtKullanici.Location = new System.Drawing.Point(100, 30);
            this.txtKullanici.Size = new System.Drawing.Size(150, 25);
            // lblSifre
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.Location = new System.Drawing.Point(20, 70);
            this.lblSifre.Size = new System.Drawing.Size(70, 25);
            // txtSifre
            this.txtSifre.Location = new System.Drawing.Point(100, 70);
            this.txtSifre.Size = new System.Drawing.Size(150, 25);
            this.txtSifre.PasswordChar = '*';
            // btnGiris
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.Location = new System.Drawing.Point(100, 110);
            this.btnGiris.Size = new System.Drawing.Size(100, 30);
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // AdminGiris
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnGiris);
            this.Text = "Yönetici Girişi";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblSifre;
    }
}