using Restaurant_Management.DAO;
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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void fAdmin_Load(object sender, EventArgs e)
        {
            loadAccount();
        }

        void loadAccount()
        {
            string query = "select * from dbo.Account";

            Dgv_A.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
