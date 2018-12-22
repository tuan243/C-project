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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        #region Method

        BindingSource FoodList = new BindingSource();
        BindingSource CategoryList = new BindingSource();
        BindingSource AccountList = new BindingSource();
        BindingSource TableList = new BindingSource();

        #region Load

        void loadAccount()
        {
            AccountList.DataSource = AccountDAO.Instance.GetAccount();
        }

        void loadTable()
        {
            TableList.DataSource = TableDAO.Instance.LoadTableList();
        }

        void LoadCategory()
        {
            CategoryList.DataSource = CategoryDAO.Instance.GetCategory();
        }

        void LoadFood()
        {
            FoodList.DataSource = FoodDAO.Instance.GetAllListFood();
        }

        void LoadListBillByDate(DateTime from, DateTime to)
        {
            Dgv_I.DataSource = BillDAO.Instance.GetIncome(from, to);
        }

        void LoadDateTimePicker()
        {
            DateTime today = DateTime.Now;
            dTP_From.Value = new DateTime(today.Year, today.Month, 1);
            dTP_To.Value = dTP_From.Value.AddMonths(1).AddDays(-1);
        }

        #endregion

        #region Binding

        void AddFoodBinding()
        {
            Txb_MID.DataBindings.Add(new Binding("Text", Dgv_M.DataSource, "ID", true, DataSourceUpdateMode.Never));
            Txb_MName.DataBindings.Add(new Binding("Text", Dgv_M.DataSource, "Name", true, DataSourceUpdateMode.Never));
            Txb_MSize.DataBindings.Add(new Binding("Text", Dgv_M.DataSource, "Size", true, DataSourceUpdateMode.Never));
            Txb_MPrice.DataBindings.Add(new Binding("Text", Dgv_M.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void AddCategoryBinding()
        {
            Txb_CID.DataBindings.Add(new Binding("Text", Dgv_C.DataSource, "ID", true, DataSourceUpdateMode.Never));
            Txb_CName.DataBindings.Add(new Binding("Text", Dgv_C.DataSource, "Name", true, DataSourceUpdateMode.Never));
        }

        void AddTableBinding()
        {
            Txb_TID.DataBindings.Add(new Binding("Text", Dgv_T.DataSource, "ID", true, DataSourceUpdateMode.Never));
            Txb_TName.DataBindings.Add(new Binding("Text", Dgv_T.DataSource, "Name", true, DataSourceUpdateMode.Never));
            Txb_TSize.DataBindings.Add(new Binding("Text", Dgv_T.DataSource, "Size", true, DataSourceUpdateMode.Never));
            Cbb_TStatus.DataSource = Dgv_T.DataSource;
        }

        void AddAccountBinding()
        {
            Txb_AUsername.DataBindings.Add(new Binding("Text", Dgv_A.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            Txb_AName.DataBindings.Add(new Binding("Text", Dgv_A.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            Cbb_AType.DataSource = Dgv_A.DataSource;
        }

        void LoadCategoryIntoComboBox(ComboBox cbb)
        {
            cbb.DataSource = CategoryDAO.Instance.GetCategory();
            cbb.DisplayMember = "Name";
        }
        void LoadTableStatusIntoComboBox(ComboBox cbb)
        {

            cbb.DataSource = TableDAO.Instance.LoadTableList();
            cbb.DisplayMember = "Status";
        }
        void LoadAccountIntoComboBox(ComboBox cbb)
        {
            cbb.DataSource = AccountDAO.Instance.GetAccount();
            cbb.DisplayMember = "Type";
        }
        #endregion

        #endregion

        #region Event

        private void fAdmin_Load(object sender, EventArgs e)
        {
            //Income
            LoadDateTimePicker();
            LoadListBillByDate(dTP_From.Value, dTP_To.Value);
            //Account
            Dgv_A.DataSource = AccountList;
            loadAccount();
            AddAccountBinding();
            LoadAccountIntoComboBox(Cbb_AType);

            //Table
            Dgv_T.DataSource = TableList;
            loadTable();
            AddTableBinding();
            LoadTableStatusIntoComboBox(Cbb_TStatus);
            //Food
            Dgv_M.DataSource = FoodList;
            LoadFood();
            AddFoodBinding();
            LoadCategoryIntoComboBox(Cbb_MCategory);
            //Category
            Dgv_C.DataSource = CategoryList;
            LoadCategory();
            AddCategoryBinding();
        }

        #region Income

        private void Btn_ViewIncome_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dTP_From.Value, dTP_To.Value);
        }

        #endregion

        #region Food

        private void Txb_MID_TextChanged(object sender, EventArgs e)
        {
            if (Dgv_M.SelectedCells.Count > 0)
            {
                int id = (int)Dgv_M.SelectedCells[0].OwningRow.Cells["Fcategory"].Value;

                Category category = CategoryDAO.Instance.GetCategoryByID(id);
                int i = 0;
                foreach (Category item in Cbb_MCategory.Items)
                {
                    if (item.ID == category.ID)
                    {
                        Cbb_MCategory.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
            }
        }

        private void Btn_MView_Click(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void Btn_MAdd_Click(object sender, EventArgs e)
        {
            string name = Txb_MName.Text;
            string size = Txb_MSize.Text;
            int fcategory = (Cbb_MCategory.SelectedItem as Category).ID;
            float price = float.Parse(Txb_MPrice.Text);

            if (FoodDAO.Instance.InsertFood(name, size, fcategory, price))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_MEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txb_MID.Text);
            string name = Txb_MName.Text;
            string size = Txb_MSize.Text;
            int fcategory = (Cbb_MCategory.SelectedItem as Category).ID;
            float price = float.Parse(Txb_MPrice.Text);

            if (FoodDAO.Instance.EditFood(id, name, size, fcategory, price))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_MRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txb_MID.Text);

            if (FoodDAO.Instance.DeleteFood(id))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                LoadFood();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }


        #endregion

        #region Category

        private void Btn_CAdd_Click(object sender, EventArgs e)
        {
            string name = Txb_CName.Text;
            if (CategoryDAO.Instance.InsertCategory(name))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_CRemove_Click(object sender, EventArgs e)
        {

        }

        private void Btn_CEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txb_CID.Text);
            string name = Txb_CName.Text;
            if (CategoryDAO.Instance.EditCategory(id, name))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                LoadCategory();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_CView_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }

        #endregion

        #region Table

        private void Txb_TID_TextChanged(object sender, EventArgs e)
        {
            if (Dgv_T.SelectedCells.Count > 0)
            {
                int id = (int)Dgv_T.SelectedCells[0].OwningRow.Cells["ID"].Value;

                Table table = TableDAO.Instance.LoadTableListByID(id);
                int i = 0;
                foreach (Table item in Cbb_TStatus.Items)
                {
                    if (item.ID == table.ID)
                    {
                        Cbb_TStatus.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
            }
        }

        private void Btn_TAdd_Click(object sender, EventArgs e)
        {
            string name = Txb_MName.Text;
            string size = Txb_MSize.Text;
            string status = Cbb_TStatus.SelectedItem.ToString();
            if (TableDAO.Instance.InsertTable(name, status, size))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                loadTable();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_TRemove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txb_TID.Text);
            if (TableDAO.Instance.RemoveTable(id))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                loadTable();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_TEdit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(Txb_TID.Text);
            string name = Txb_MName.Text;
            string size = Txb_MSize.Text;
            string status = Cbb_TStatus.SelectedItem.ToString();
            if (TableDAO.Instance.EditTable(id, name, status, size))
            {
                MessageBox.Show("Success", "Notification", MessageBoxButtons.OK);
                loadTable();
            }
            else
            {
                MessageBox.Show("Error, Fail", "Notification", MessageBoxButtons.OK);
            }
        }

        private void Btn_TView_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        #endregion

        #region Account

        private void Txb_AUsername_TextChanged(object sender, EventArgs e)
        {
            if (Dgv_A.SelectedCells.Count > 0)
            {
                string username = Dgv_A.SelectedCells[0].OwningRow.Cells["UserName"].Value.ToString();

                Account table = AccountDAO.Instance.GetAccountByUsername(username);
                int i = 0;
                foreach (Account item in Cbb_AType.Items)
                {
                    if (item.Username == table.Username)
                    {
                        Cbb_AType.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
            }
        }

        private void Btn_AAdd_Click(object sender, EventArgs e)
        {

        }

        private void Btn_ARemove_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AEdit_Click(object sender, EventArgs e)
        {

        }

        private void Btn_AView_Click(object sender, EventArgs e)
        {
            loadAccount();
        }

        #endregion

        #endregion

    }
}
