using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data_Transfer_Object___DTO
{
    public class Food
    {
        public Food(int id, string name, string size, int fCategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.Size = size;
            this.FCategory = fCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Size = row["Size"].ToString();
            this.FCategory = (int)row["Fcategory"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }

        private int iD;
        private string name;
        private string size;
        private int fCategory;
        private float price;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Size { get => size; set => size = value; }
        public int FCategory { get => fCategory; set => fCategory = value; }
        public float Price { get => price; set => price = value; }
    }
}
