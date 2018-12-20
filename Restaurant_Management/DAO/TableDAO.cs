using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class TableDAO
    {
        //Width and Height for button Table.
        public static int tableWidth = 90;
        public static int tableHeight = 50;
        //Create Singleton.
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TableDAO();
                return TableDAO.instance;
            }
            private set
            {
                TableDAO.instance = value;
            }
        }

        private TableDAO() { }

        //Load Tablelist.
        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("UserProc_GetListTable");

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public void ChangeTableStatus(int id, string status)
        {
            string query = "UserProc_ChangeTableStatus @IDTable , @Status";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, status });
        }

        public List<Table> LoadTableListByStatus(string status)
        {
            List<Table> tableList = new List<Table>();

            string query = "UserProc_GetListTableByStatus @status";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { status });

            foreach (DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

        public void SwitchTable(int idFirstTable, int idSecondTable)
        {
            string query = "UserProc_SwitchTable @idFirstTable , @idSecondTable";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFirstTable, idSecondTable });
        }

        public void CombineTable(int idFirstTable, int idSecondTable)
        {
            string query = "UserProc_CombineTable @idFirstTable , @idSecondTable";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idFirstTable, idSecondTable });
        }

        //public void ChangeTableStatus(int id, string status)
        //{
        //    string query = "UserProc_ChangeTableStatus @IDTable , @Status";
        //    DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, status });
        //}
    }
}
