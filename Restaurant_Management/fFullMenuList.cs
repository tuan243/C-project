using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            CultureInfo culture = new CultureInfo("vi-VN");
            List<Food> ListF;
            if (cbb_Catergory.SelectedIndex == 0)
            {
                ListF = FoodDAO.Instance.GetAllListFood();
            }
            else
                ListF = FoodDAO.Instance.GetListFoodByCategoryID(id);
            foreach (Food item in ListF)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Size.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("C0", culture));

                lsvItem.Tag = item;
                Lv_SelectFood.Items.Add(lsvItem);
            }
            Lv_SelectFood.Items[0].Selected = true;
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
            if(this.Tag == null)
            {
                Btn_AddOrder.Visible = false;
                nUD_UnitCount.Visible = false;
            }
            else
            {
                Btn_AddOrder.Visible = true;
                nUD_UnitCount.Visible = true;
            }
            LoadCategory();
        }

        private void Lv_SelectFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            if (Lv_SelectFood.SelectedItems.Count > 0)
            {
                ListViewItem lsvitem = Lv_SelectFood.SelectedItems[0];
                Food food = lsvitem.Tag as Food;
                Txb_MID.Text = food.ID.ToString();
                Txb_MName.Text = food.Name;
                Txb_MSize.Text = food.Size;
                Txb_MPrice.Text = food.Price.ToString("C0", culture);

                int idC = food.FCategory;
                Category category = CategoryDAO.Instance.GetCategoryByID(idC);
                Txb_MCategory.Text = category.Name;
            }
            else
            {
                Txb_MID.Text = string.Empty;
                Txb_MName.Text = string.Empty;
            }

        }
    }
}
