namespace OkulCSharp
{
    partial class AdminPanel
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // lblBaslik
            this.lblBaslik.Text = "Admin Paneli";
            this.lblBaslik.Location = new System.Drawing.Point(100, 50);
            this.lblBaslik.Size = new System.Drawing.Size(100, 25);
            // AdminPanel
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblBaslik);
            this.Text = "Admin Paneli";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblBaslik;
    }
}