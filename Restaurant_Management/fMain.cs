using Restaurant_Management.DAO;
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
        private void fMain_Load(object sender, EventArgs e)
        {
            LoadTable();
        }

        #region Method

        void LoadTable()
        {
            //Load tableList from database.
            List<Table> tableList = TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                //Create button.
                Button btn = new Button()
                {
                    Width = TableDAO.tableWidth, Height = TableDAO.tableHeight
                };
                //Set text for button.
                btn.Text = item.Name + " ( " + item.Size + " ) " + Environment.NewLine + "( " + item.Status + " )";
                //Event click.
                btn.Click += Btn_Click;
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
                lsvItem.SubItems.Add(item.Count.ToString("N0"));
                lsvItem.SubItems.Add(item.Price.ToString("C0", culture));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("C0", culture));
                //Update total.
                total = total + item.TotalPrice;
                Lv_Bill.Items.Add(lsvItem);
            }
            txb_Total.Text = total.ToString("C0", culture);
        }

        #endregion

        #region Event

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

        private void Lv_Bill_SizeChanged(object sender, EventArgs e)
        {
            col_name.Width = (int)(Lv_Bill.Width / 2 - 50);
            col_price.Width = (int)(Lv_Bill.Width * 0.245);
            col_totalprice.Width = (int)(Lv_Bill.Width * 0.245);
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
        }


        #endregion
    }
}
