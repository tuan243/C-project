using Restaurant_Management.DAO;
using Restaurant_Management.Data_Transfer_Object___DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Data_Access_Object___DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodDAO();
                return FoodDAO.instance;
            }
            set
            {
                FoodDAO.instance = value;
            }
        }

        private FoodDAO() { }

        public List<Food> GetListFood()
        {
            List<Food> ListF = new List<Food>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.Food");

            foreach (DataRow item in data.Rows)
            {
                Food F = new Food(item);
                ListF.Add(F);
            }

            return ListF;
        }
    }
}
