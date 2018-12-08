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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin Admin = new fAdmin();
            Admin.ShowDialog();
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile Profile = new fProfile();
            Profile.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
