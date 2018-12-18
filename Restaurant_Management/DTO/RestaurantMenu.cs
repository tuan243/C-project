using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DTO
{
    public class RestaurantMenu
    {
        public RestaurantMenu(int id, string foodName, string size, int count, float price, float totalPrice)
        {
            this.ID = id;
            this.FoodName = foodName;
            this.Size = size;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public RestaurantMenu(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.FoodName = row["Name"].ToString();
            this.Size = row["Size"].ToString();
            this.Count = (int)row["Count"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }

        private int iD;
        private string foodName;
        private string size;
        private int count;
        private float price;
        private float totalPrice;

        public int ID { get => iD; set => iD = value; }
        public string FoodName { get => foodName; set => foodName = value; }
        public string Size { get => size; set => size = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
