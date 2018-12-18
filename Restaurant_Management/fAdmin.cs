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

        #region Method

        void ResizeColumnDGV(DataGridView data)
        {
            for (int i = 0; i < data.ColumnCount; i++)
            {
                if (i != data.ColumnCount - 1)
                    data.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                else
                    data.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        void loadAccount()
        {
            string query = "select * from dbo.Account";

            Dgv_A.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ResizeColumnDGV(Dgv_A);
        }

        void loadTable()
        {
            string query = "select * from dbo.ResTable";

            Dgv_T.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ResizeColumnDGV(Dgv_T);
        }

        void LoadCategory()
        {
            string query = "select * from dbo.Category";

            Dgv_C.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ResizeColumnDGV(Dgv_C);
        }

        void LoadFood()
        {
            string query = "select * from dbo.food";

            Dgv_M.DataSource = DataProvider.Instance.ExecuteQuery(query);
            ResizeColumnDGV(Dgv_M);
        }

        #endregion

        #region Event

        private void fAdmin_Load(object sender, EventArgs e)
        {
            loadAccount();
            loadTable();
            LoadFood();
            LoadCategory();
        }

        #endregion

        private void Dgv_A_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
