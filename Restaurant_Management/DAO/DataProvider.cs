using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.DAO
{
    //Create Singleton.
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }

        private DataProvider() { }

        private string connectionStr = "Data Source = MINHQUAN; Initial Catalog = RestaurantManagement; Integrated Security = True";

        
        public DataTable ExecuteQuery(string query, object[] parameter = null) //object parameter to avoid SQL Injection.
        {
            //Create datable.
            DataTable data = new DataTable();
            //Create connection.
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                //Open connection.
                connection.Open();
                //Add data to datatable.
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                } 

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                //Close connection.
                connection.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            //Create int.
            int data = 0;
            //Create connection.
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                //Open connection.
                connection.Open();
                //Add data to datatable.
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }

                data = command.ExecuteNonQuery();
                //Close connection.
                connection.Close();
            }
            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            //Create int.
            object data = 0;
            //Create connection.
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                //Open connection.
                connection.Open();
                //Add data to datatable.
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listpara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listpara)
                    {
                        command.Parameters.AddWithValue(item, parameter[i]);
                        i++;
                    }
                }

                data = command.ExecuteScalar();
                //Close connection.
                connection.Close();
            }
            return data;
        }
    }
}
