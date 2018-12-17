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
    }
}
