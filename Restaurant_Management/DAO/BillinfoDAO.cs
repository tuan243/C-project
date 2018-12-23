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
