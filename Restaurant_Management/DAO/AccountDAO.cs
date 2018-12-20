using Restaurant_Management.DTO;
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

        public Account GetAccountByUsername(string username)
        {
            string query = "UserProc_GetAccountByUsername @username";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { username });

            DataRow item = result.Rows[0];
            Account acc = new Account(item);

            return acc;
        }

        public void ChangePassword(string username, string newpassword)
        {
            string query = "UserProc_ChangePassWord @username , @newpass";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { username, newpassword });
        }
    }
}
