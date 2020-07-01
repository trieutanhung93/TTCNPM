using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace BKFoodCourt.Models
{
    public class ListFood  //Load Data to List
    {
        public List<Food> foods;

        private DataTable dataTable = new DataTable();

        public ListFood()
        {
            string connString = @"Data Source=DESKTOP-C8J1S1O\SQLEXPRESS;Initial Catalog=BKFOODCOURT;Integrated Security=True";
            string query = "select * from Food";

            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataTable);
            conn.Close();
            da.Dispose();

            try
            {
                foods = new List<Food>();

                foreach (var row in dataTable.AsEnumerable())
                {
                    Food obj = new Food();

                    foreach (var prop in obj.GetType().GetProperties())
                    {
                        try
                        {
                            PropertyInfo propertyInfo = obj.GetType().GetProperty(prop.Name);
                            propertyInfo.SetValue(obj, Convert.ChangeType(row[prop.Name], propertyInfo.PropertyType), null);
                        }
                        catch
                        {
                            continue;
                        }
                    }

                    foods.Add(obj);
                }
            }
            catch
            {
                Console.Write("Error");
            }
        }
    }
}