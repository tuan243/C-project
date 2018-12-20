using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class AccountDAO
    {
        //Create Singleton.
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
            private set
            {
                AccountDAO.instance = value;
            }
        }

        private AccountDAO() { }
        //Load data from Database for Login.
        public bool Login(string username, string password)
        {
            string query = "UserProc_Login @username , @password";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username, password });


            return result.Rows.Count > 0;
        }
    }
}
