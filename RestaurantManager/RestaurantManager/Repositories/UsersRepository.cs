using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    public class UsersRepository : IRepository<User>
    {

        void IRepository<User>.Add(User user, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("sp_insert");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", user.GetFirstName());
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@phone", textBox3.Text);
            cmd.Parameters.AddWithValue("@address", textBox4.Text);

            throw new NotImplementedException();
        }

        void IRepository<User>.Delete(User entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Update(User entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }
    }
}
