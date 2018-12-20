using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    public class Account
    {
        public Account(string username, string password, string displayname, int type)
        {
            this.Username = username;
            this.Password = password;
            this.DisplayName = displayname;
            this.Type = type;
        }

        public Account(DataRow row)
        {
            this.Username = row["Username"].ToString();
            this.Password = row["Password"].ToString();
            this.DisplayName = row["Displayname"].ToString();
            this.Type = (int)row["Type"];
        }

        private string username;
        private string password;
        private string displayName;
        private int type;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public int Type { get => type; set => type = value; }
    }
}
