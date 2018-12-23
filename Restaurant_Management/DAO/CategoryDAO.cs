using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CategoryDAO();
                return CategoryDAO.instance;
            }
            set
            {
                CategoryDAO.instance = value;
            }
        }

        private CategoryDAO() { }

        public List<Category> GetCategory()
        {
            List<Category> List = new List<Category>();
            string query = "select * from dbo.Category";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                Category category = new Category(item);
                List.Add(category);
            }

            return List;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;
            string query = "select * from dbo.Category where ID = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);
            }
            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = "UserProc_InsertCategory @name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { name });

            return result > 0;
        }

        public bool EditCategory(int id, string name)
        {
            string query = "UseProcr_EditCategory @id , @name";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name });

            return result > 0;
        }
        
    }
}
