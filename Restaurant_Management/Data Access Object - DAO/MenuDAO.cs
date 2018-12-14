using Restaurant_Management.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuDAO();
                return MenuDAO.instance;
            }
            private set
            {
                MenuDAO.instance = value;
            }
        }

        private MenuDAO() { }

        public List<RestaurantMenu> GetListMenubyTable(int id)
        {
            List<RestaurantMenu> listMenu = new List<RestaurantMenu>();
            //Import data from database.
            string query = "USerProc_GetMenu @IDTable";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { id });
            //Add to list.
            foreach(DataRow item in data.Rows)
            {
                RestaurantMenu menu = new RestaurantMenu(item);
                listMenu.Add(menu);
            }


            return listMenu;
        }
    }
}
