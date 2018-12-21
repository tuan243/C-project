using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class BillinfoDAO
    {
        private static BillinfoDAO instance;

        public static BillinfoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillinfoDAO();
                return BillinfoDAO.instance;
            }
            private set
            {
                BillinfoDAO.instance = value;
            }
        }

        private BillinfoDAO() { }

        public List<Billinfo> GetListBillinfo(int id)
        {
            List<Billinfo> ListBillinfo = new List<Billinfo>();

            string query = "UserProc_GetBillinfo @IDBill";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach(DataRow item in data.Rows)
            {
                Billinfo info = new Billinfo(item);
                ListBillinfo.Add(info);
            }

            return ListBillinfo;
        }

        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            string query = "UserProc_InsertBillInfo @IDBill , @IDFood , @Count";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood, count });
        }

        public void RemoveItemInBillInfo(int idBill, int idFood)
        {
            string query = "UserProc_RemoveItemInBillInfo @IDBill , @IDFood";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBill, idFood });
        }

        public void DeleteBillinfoByFoodID(int id)
        {
            string query = "UserProc_DeleteBillinfoByFoodID @id";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }
    }
}
