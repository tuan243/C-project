using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class BillDAO
    {
        //Create Singleton
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return BillDAO.instance;
            }
            private set
            {
                BillDAO.instance = value;
            }
        }

        private BillDAO() { }

        public int Get_uncheckOutBillID_by_TableID(int id)
        {
            string query = "UserProc_GetUnCheckOutBilliD @IDTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            else
                return -1;
        }

        public void InsertBill(int id)
        {
            string query = "UserProc_InsertBill @IDTable";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }

        public int GetMaxID()
        {
            string query = "select max(ID) from dbo.Bill";
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar(query);
            }
            catch
            {
                return 1;
            }
        }

    }
}
