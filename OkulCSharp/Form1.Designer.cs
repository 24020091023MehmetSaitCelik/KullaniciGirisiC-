namespace OkulCSharp
{
    partial class Form1
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
            this.btnOgrenci = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblBaslik
            this.lblBaslik.Text = "Hoş Geldiniz";
            this.lblBaslik.Location = new System.Drawing.Point(90, 30);
            this.lblBaslik.Size = new System.Drawing.Size(120, 25);
            // btnOgrenci
            this.btnOgrenci.Text = "Öğrenci Girişi";
            this.btnOgrenci.Location = new System.Drawing.Point(80, 80);
            this.btnOgrenci.Size = new System.Drawing.Size(120, 35);
            this.btnOgrenci.Click += new System.EventHandler(this.btnOgrenci_Click);
            // btnAdmin
            this.btnAdmin.Text = "Yönetici Girişi";
            this.btnAdmin.Location = new System.Drawing.Point(80, 130);
            this.btnAdmin.Size = new System.Drawing.Size(120, 35);
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // Form1
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.btnOgrenci);
            this.Controls.Add(this.btnAdmin);
            this.Text = "Ana Menü";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnOgrenci;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Label lblBaslik;
    }
}