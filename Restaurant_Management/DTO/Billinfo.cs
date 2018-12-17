using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    public class Billinfo
    {
        public Billinfo(int id, int idFood, int idBill, int count)
        {
            this.ID = id;
            this.IDfood = idFood;
            this.IDBill = idBill;
            this.Count = count;
        }

        public Billinfo(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.IDfood = (int)row["IDFood"];
            this.IDBill = (int)row["IDBill"];
            this.Count = (int)row["Count"];
        }

        private int iD;
        private int iDFood;
        private int iDBill;
        private int count;

        public int ID { get => iD; set => iD = value; }
        public int IDfood { get => iDFood; set => iDFood = value; }
        public int IDBill { get => iDBill; set => iDBill = value; }
        public int Count { get => count; set => count = value; }
    }
}
