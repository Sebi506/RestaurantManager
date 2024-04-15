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
    public sealed class DatabaseConnection
    {
        string connectionString;
        SqlConnection connection;

        private static DatabaseConnection instance= null;

        public DatabaseConnection()
        {
            //this.connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            //this.connection = new SqlConnection(@"Data Source=DESKTOP-KH2IB0O\SQLEXPRESS;Initial Catalog=RestaurantManagerDB;Integrated Security=True");
            this.connection = new SqlConnection("Data Source=DESKTOP-KH2IB0O\\SQLEXPRESS;Initial Catalog=RestaurantManagerDB;Integrated Security=True");

        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }

        public void ExecuteSqlCommand(SqlCommand cmd)
        {

            cmd.ExecuteNonQuery();

        }

        public void ExecuteSqlCommand(string query)
        {
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecuteSqlReader(SqlCommand cmd)
        {
            cmd.Connection = this.connection;
            SqlCommand cmd2 = new SqlCommand(cmd.CommandText, connection);
            foreach(SqlParameter cmdParameter in cmd.Parameters)
            cmd2.Parameters.AddWithValue(cmdParameter.ParameterName.ToString(), cmdParameter.Value);

            SqlDataReader reader = cmd2.ExecuteReader();


            return reader;
        }

        public SqlDataReader ExecuteSqlReader(string query)
        {

            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();

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
