using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            fMain f = new fMain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
