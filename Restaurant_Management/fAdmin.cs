using Restaurant_Management.DAO;
using Restaurant_Management.Data_Transfer_Object___DTO;
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

        #region Method

        void loadAccount()
        {
            string query = "select * from dbo.Account";

            Dgv_A.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void loadTable()
        {
            string query = "select * from dbo.ResTable";

            Dgv_T.DataSource = DataProvider.Instance.ExecuteQuery(query);
        }

        void LoadFood()
        {
            string query = "select * from dbo.Food";

            Dgv_M.DataSource = DataProvider.Instance.ExecuteQuery(query);

            List<Food> foods = new List<Food>();
            foods.

        }

        #endregion

        #region Event

        private void fAdmin_Load(object sender, EventArgs e)
        {
            loadAccount();
            loadTable();
            LoadFood();
        }

        #endregion

        private void Dgv_A_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
