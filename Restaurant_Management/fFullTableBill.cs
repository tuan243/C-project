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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class fFullTableBill : Form
    {
        public fFullTableBill()
        {
            InitializeComponent();
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
            foreach (RestaurantMenu item in menu)
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

        private void fFullTableBill_Load(object sender, EventArgs e)
        {
            Table table = this.Tag as Table;
            ShowBill(table.ID);
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            Table table = this.Tag as Table;
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
            Table table = this.Tag as Table;
            CultureInfo culture = new CultureInfo("vi-VN");

            int discount = (int)nUD_Discount.Value;
            float Total = (float)txb_Total.Tag;
            float FinalTotal = Total * (100 - discount) / 100;
            int idBill = BillDAO.Instance.Get_uncheckOutBillID_by_TableID(table.ID);
            if (idBill != -1)
            {
                string str = "Totol Price is : " + Total.ToString("C0", culture) +
                             Environment.NewLine + "Discount is : " + discount + "%" +
                             Environment.NewLine + "Final price is : " + FinalTotal.ToString("C0", culture);

                if (MessageBox.Show(str, "Check Out " + table.Name, MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    TableDAO.Instance.ChangeTableStatus(table.ID, "Trống");
                    BillDAO.Instance.CheckOut(idBill, discount, FinalTotal);
                    this.Close();
                }
            }
        }
    }
}
