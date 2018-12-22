using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
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

        public List<Food> GetListFoodByCategoryID(int id)
        {
            List<Food> ListF = new List<Food>();
            string query = "UserProc_GetFoodByCategoryID @ID";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });

            foreach (DataRow item in data.Rows)
            {
                Food F = new Food(item);
                ListF.Add(F);
            }

            return ListF;
        }

        public List<Food> GetAllListFood()
        {
            List<Food> ListF = new List<Food>();
            string query = "select * from dbo.food";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food F = new Food(item);
                ListF.Add(F);
            }

            return ListF;
        }

        public bool InsertFood(string name, string size, int fcategory, float price)
        {
            string query = "UserProc_InsertFood @name , @size , @Fcategory , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, size, fcategory, price });

            return result > 0;
        }

        public bool EditFood(int id, string name, string size, int fcategory, float price)
        {
            string query = "UserProc_EditFood @id , @name , @size , @Fcategory , @price";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, size, fcategory, price });

            return result > 0;
        }

        public bool DeleteFood(int id)
        {
            BillinfoDAO.Instance.DeleteBillinfoByFoodID(id);

            string query = "UserProc_DeleteFood @id";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });

            return result > 0;
        }

    }
}
