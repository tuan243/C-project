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
    }
}
