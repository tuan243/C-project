using Restaurant_Management.DAO;
using Restaurant_Management.DTO;
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
    public partial class fProfile : Form
    {
        public fProfile()
        {
            InitializeComponent();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Txb_OldPass.Clear();
            Txb_NewPass.Clear();
            Txb_Confirm.Clear();
        }

        private void fProfile_Load(object sender, EventArgs e)
        {
            Account account = this.Tag as Account;

            Txb_UserName.Text = account.Username;
            textBox3.Text = account.DisplayName;
            if (account.Type == 1)
                textBox1.Text = "Administrator";
            else
                textBox1.Text = "Staff";
        }

        private void Btn_ChangePass_Click(object sender, EventArgs e)
        {
            Account account = this.Tag as Account;

            if(Txb_OldPass.Text == account.Password)
            {
                if(Txb_NewPass.Text==Txb_Confirm.Text)
                {
                    AccountDAO.Instance.ChangePassword(Txb_UserName.Text, Txb_NewPass.Text);
                    MessageBox.Show("Password Changed.", "Notification", MessageBoxButtons.OK);
                    Txb_OldPass.Clear();
                    Txb_NewPass.Clear();
                    Txb_Confirm.Clear();
                }
                MessageBox.Show("New Password must be confirm.", "Notification", MessageBoxButtons.OK);
            }
            MessageBox.Show("Wrong Old Password.", "Notification", MessageBoxButtons.OK);
        }
    }
}
