using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    public class Table
    {
        public Table(int iD, string name, string status, int size)
        {
            this.ID = iD;
            this.Name = name;
            this.Status = status;
            this.Size = size;
        }

        public Table(DataRow row)
        {

            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Status = row["Status"].ToString();
            this.Size = (int)row["Size"];
        }

        private int iD;
        private string name;
        private string status;
        private int size;
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Status { get => status; set => status = value; }
        public int Size { get => size; set => size = value; }
    }
}
