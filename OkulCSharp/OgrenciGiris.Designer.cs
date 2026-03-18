namespace OkulCSharp
{
    partial class OgrenciGiris
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
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblNo
            this.lblNo.Text = "Numara:";
            this.lblNo.Location = new System.Drawing.Point(20, 30);
            this.lblNo.Size = new System.Drawing.Size(70, 25);
            // txtNo
            this.txtNo.Location = new System.Drawing.Point(100, 30);
            this.txtNo.Size = new System.Drawing.Size(150, 25);
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
            // OgrenciGiris
            this.ClientSize = new System.Drawing.Size(300, 180);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnGiris);
            this.Text = "Öğrenci Girişi";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblSifre;
    }
}