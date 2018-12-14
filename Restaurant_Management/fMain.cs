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
                btn.Text = item.Name + Environment.NewLine + "( " + item.Status + " )";
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
            ////Get Billinfo
            //int idBillinfo = BillDAO.Instance.Get_uncheckOutBillID_by_TableID(id);
            //List<Billinfo> listBillinfo = BillinfoDAO.Instance.GetListBillinfo(idBillinfo);

            //Get Menu
            List<RestaurantMenu> menu = MenuDAO.Instance.GetListMenubyTable(id);

            foreach(RestaurantMenu item in menu)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());

                Lv_Bill.Items.Add(lsvItem);
            }
        }

        #endregion

        #region Event

        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            ShowBill(tableID);
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

        #endregion


    }
}
