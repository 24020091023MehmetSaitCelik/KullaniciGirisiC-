namespace OkulCSharp
{
    partial class OgrenciPanel
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
            this.lblBaslik.Text = "Öğrenci Paneli";
            this.lblBaslik.Location = new System.Drawing.Point(100, 50);
            this.lblBaslik.Size = new System.Drawing.Size(100, 25);
            // OgrenciPanel
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblBaslik);
            this.Text = "Öğrenci Paneli";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblBaslik;
    }
}