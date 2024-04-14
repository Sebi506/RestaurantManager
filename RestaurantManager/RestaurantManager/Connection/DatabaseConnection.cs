using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Connection
{
    public class DatabaseConnection
    {
        string connectionString;
        SqlConnection connection;

        public DatabaseConnection() {
            this.connectionString = string.Empty;
        }

        public DatabaseConnection(string connectionString)
        {
            this.connectionString = connectionString;
            //this.connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            this.connection = new SqlConnection(@"Data Source=DESKTOP-KH2IB0O\SQLEXPRESS;Initial Catalog=RestaurantManagerDB;Integrated Security=True;Trust Server Certificate=True");

        }


        public void ExecuteSqlCommand(SqlCommand cmd)
        {

            connection.Open();

            cmd.ExecuteNonQuery(); 

            connection.Close();
        }
    }
}
