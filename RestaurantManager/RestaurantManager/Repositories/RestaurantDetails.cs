using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    internal class RestaurantDetails : IRepository<RestaurantDetails>
    {
        void IRepository<RestaurantDetails>.Add(RestaurantDetails entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<RestaurantDetails>.Delete(RestaurantDetails entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<RestaurantDetails>.Update(RestaurantDetails entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        RestaurantDetails IRepository<RestaurantDetails>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }

        public void setRestaurantDetailsById(Guid id, DatabaseConnection dbCon,Restaurant restaurant)
        {
            dbCon.OpenDbCon();
            SqlCommand cmd = new SqlCommand("select * from RestaurantDetails where id_restaurantDetails=@id");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);


            SqlDataReader reader = dbCon.ExecuteSqlReader(cmd);


            while (reader.Read())
            {

                restaurant.SetName(reader[1].ToString());
                restaurant.SetLocation(reader[2].ToString());
                restaurant.SetState((int)reader[3]);

            }

            dbCon.CloseDbCon();
        }

    }
}
