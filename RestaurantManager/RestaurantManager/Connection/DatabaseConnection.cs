using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RestaurantManager.Connection
{
    public class DatabaseConnection
    {
        string connectionString;
        SqlConnection connection;


        public DatabaseConnection()
        {
            //this.connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            //this.connection = new SqlConnection(@"Data Source=DESKTOP-KH2IB0O\SQLEXPRESS;Initial Catalog=RestaurantManagerDB;Integrated Security=True");
            this.connection = new SqlConnection("Data Source=DESKTOP-KH2IB0O\\SQLEXPRESS;Initial Catalog=RestaurantManagerDB;Integrated Security=True");

        }


        public void ExecuteSqlCommand(SqlCommand cmd)
        {

            connection.Open();

            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public SqlDataReader ExecuteSqlReader(SqlCommand cmd)
        {
            cmd.Connection = this.connection;
            SqlCommand cmd2 = new SqlCommand(cmd.CommandText, connection);

            cmd2.Parameters.AddWithValue("@email", cmd.Parameters[0].Value);
            cmd2.Parameters.AddWithValue("@password", cmd.Parameters[1].Value);

            SqlDataReader reader = cmd2.ExecuteReader();


            return reader;
        }

        public void OpenDbCon()
        {
            connection.Open();
        }

        public void CloseDbCon()
        {
            connection.Close();
        }

    }
}
