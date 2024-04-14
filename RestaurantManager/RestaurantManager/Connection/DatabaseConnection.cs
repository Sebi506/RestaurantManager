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
            this.connection = new SqlConnection(@"Data Source=DESKTOP-42V5QOA\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

        }


        public void ExecuteSqlCommand(SqlCommand cmd)
        {
/*
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);
            con.Open();
            int i = cmd.ExecuteNonQuery();*/

            connection.Open();

            cmd.ExecuteNonQuery(); 

            connection.Close();
        }
    }
}
