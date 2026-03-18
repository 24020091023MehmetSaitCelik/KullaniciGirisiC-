using System;
using System.Windows.Forms;

namespace OkulCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            new OgrenciGiris().Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            new AdminGiris().Show();
            this.Hide();
        }
    }
}