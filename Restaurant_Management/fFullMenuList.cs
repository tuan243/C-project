using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Management.DAO;
using Restaurant_Management.DTO;

namespace Restaurant_Management
{
    public partial class fFullMenuList : Form
    {
        public fFullMenuList()
        {
            InitializeComponent();
        }

        void LoadCategory()
        {
            Category AllCategory = new Category(0, "All Category");
            List<Category> ListCa = CategoryDAO.Instance.GetCategory();
            ListCa.Insert(0, AllCategory);
            cbb_Catergory.DataSource = ListCa;
            cbb_Catergory.DisplayMember = "Name";
        }

        void LoadFoodListByCategory(int id)
        {
            List<Food> ListF;
            if (cbb_Catergory.SelectedIndex == 0)
            {
                ListF = FoodDAO.Instance.GeAllListFood();
            }
            else
                ListF = FoodDAO.Instance.GetListFoodByCategoryID(id);
            foreach (Food item in ListF)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Size.ToString());

                lsvItem.Tag = item;
                Lv_SelectFood.Items.Add(lsvItem);
            }
        }
        #region SelectFood

        private void cbb_Catergory_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lv_SelectFood.Items.Clear();
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            int id = selected.ID;

            LoadFoodListByCategory(id);
        }

        #endregion

        private void fFullMenuList_Load(object sender, EventArgs e)
        {
            LoadCategory();

        }
    }
}
