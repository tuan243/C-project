﻿using Restaurant_Management.DAO;
using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region Method

        void LoadTable()
        {
            Flp_Table.Controls.Clear();
            //Load tableList from database.
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                //Create button.
                Button btn = new Button()
                {
                    Width = TableDAO.tableWidth, Height = TableDAO.tableHeight,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat,
            };
                btn.FlatAppearance.BorderSize = 4;
                
                btn.FlatAppearance.BorderColor = Color.LightGreen;
                //Set text for button.
                btn.Text = item.Name + " ( " + item.Size + " )" + Environment.NewLine + "( " + item.Status + " )";
                //Event click.
                btn.Click += Btn_Click;
                btn.Leave += new EventHandler(Btn_Leave);
                btn.GotFocus += new EventHandler(Btn_GotFocus);
                //Tag
                btn.Tag = item;
                //Set backcolor.
                switch(item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGreen;
                        break;
                    case "Có người":
                        btn.BackColor = Color.OrangeRed;
                        break;
                    default:
                        btn.BackColor = Color.BlueViolet;
                        break;
                }
                //Add to FlowlayoutPanel.
                Flp_Table.Controls.Add(btn);
            }
        }

        private void Btn_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.LightGreen;
        }

        private void Btn_GotFocus(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderColor = Color.Blue;
        }

        void ShowBill(int id)
        {
            //Change currency format to VND.
            CultureInfo culture = new CultureInfo("vi-VN");
            //Thread.CurrentThread.CurrentCulture = culture;

            //Clear listview.
            Lv_Bill.Items.Clear();
            //Get Menu
            List<RestaurantMenu> menu = MenuDAO.Instance.GetListMenubyTable(id);
            //Bill total price.
            float total = 0;
            foreach(RestaurantMenu item in menu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Size.ToString());
                lsvItem.SubItems.Add(item.Count.ToString("N0"));
                lsvItem.SubItems.Add(item.Price.ToString("C0", culture));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("C0", culture));
                //Update total.
                total = total + item.TotalPrice;
                Lv_Bill.Items.Add(lsvItem);
                lsvItem.Tag = item;
            }
            txb_Total.Text = total.ToString("C0", culture);
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
            foreach(Food item in ListF)
            {
                ListViewItem lsvItem = new ListViewItem(item.Name.ToString());
                lsvItem.SubItems.Add(item.Size.ToString());

                lsvItem.Tag = item;
                Lv_SelectFood.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Event

        private void fMain_Load(object sender, EventArgs e)
        {
            LoadTable();
            LoadCategory();
            
        }

        private void fMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to log out and exit?", "Log out and Exit", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin Admin = new fAdmin();
            Admin.ShowDialog();
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fProfile Profile = new fProfile();
            Profile.Tag = this.Tag;
            Profile.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lv_Bill_SizeChanged(object sender, EventArgs e)
        {
            col_name.Width = (int)(Lv_Bill.Width * 2 / 5);           
            col_totalprice.Width = (int)(Lv_Bill.Width - 225 - col_name.Width);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            Lv_Bill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

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

        private void Btn_AddOrder_Click(object sender, EventArgs e)
        {           
            Table table = Lv_Bill.Tag as Table;
            int idBill = BillDAO.Instance.Get_uncheckOutBillID_by_TableID(table.ID);
           
            int idFood = (Lv_SelectFood.SelectedItems[0].Tag as Food).ID;
            int count = (int)nUD_UnitCount.Value;

            if(idBill==-1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                idBill = BillDAO.Instance.GetMaxID();               
            }
            BillinfoDAO.Instance.InsertBillInfo(idBill, idFood, count);
            ShowBill(table.ID);
            LoadTable();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            Table table = Lv_Bill.Tag as Table;
            int idBill = BillDAO.Instance.Get_uncheckOutBillID_by_TableID(table.ID);
            int idFood = (Lv_Bill.SelectedItems[0].Tag as RestaurantMenu).ID;

            if (idBill != -1)
            {
                BillinfoDAO.Instance.RemoveItemInBillInfo(idBill, idFood);
            }
            ShowBill(table.ID);
        }

        private void Btn_CheckOut_Click(object sender, EventArgs e)
        {
            Table table = Lv_Bill.Tag as Table;
            int discount = (int)nUD_Discount.Value;
            int idBill = BillDAO.Instance.Get_uncheckOutBillID_by_TableID(table.ID);
            if (idBill != -1)
            {
                if (MessageBox.Show("Check Out " + table.Name + " ?", "Check Out", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill, discount);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }

        private void Btn_ViewFBill_Click(object sender, EventArgs e)
        {
            Table table = Lv_Bill.Tag as Table;
            fFullTableBill tableBill = new fFullTableBill();
            tableBill.Text = "Full Table Bill " + table.Name;
            tableBill.Tag = table;
            tableBill.ShowDialog();
            ShowBill(table.ID);
            LoadTable();
        }

        private void Btn_ViewFMenu_Click(object sender, EventArgs e)
        {
            Table table = Lv_Bill.Tag as Table;
            fFullMenuList menuList = new fFullMenuList();
            menuList.Text = "Full Menu List adding to " + table.Name;
            menuList.Tag = table;
            menuList.ShowDialog();
            ShowBill(table.ID);
            LoadTable();
        }

        #endregion
    }
}
