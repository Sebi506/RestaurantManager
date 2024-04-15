using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    internal class RestaurantRepository : IRepository<Restaurant>
    {
        RestaurantDetails repository = new RestaurantDetails();
        void IRepository<Restaurant>.Add(Restaurant entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<Restaurant>.Delete(Restaurant entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<Restaurant>.Update(Restaurant entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        Restaurant IRepository<Restaurant>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }

        public Restaurant GetRestaurantByOwner(Guid id, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("select * from Restaurant where id_owner=@idOwner");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idOwner", id);

            dbCon.OpenDbCon();

            SqlDataReader reader = dbCon.ExecuteSqlReader(cmd);

            Restaurant tempRestaurant = new Restaurant();

            while (reader.Read())
            {

                tempRestaurant.SetIdRestaurant((Guid)reader[0]);
                tempRestaurant.SetIdOwner((Guid)reader[1]);
                tempRestaurant.SetIdRestaurantDetails((Guid)reader[2]);

            }

            repository.setRestaurantDetailsById(tempRestaurant.GetIdRestaurantDetails(), dbCon, tempRestaurant);

            dbCon.CloseDbCon();

            return tempRestaurant;
        }

        public Restaurant GetRestaurant(DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("select * from Restaurant");
            cmd.CommandType = CommandType.StoredProcedure;

            dbCon.OpenDbCon();

            SqlDataReader reader = dbCon.ExecuteSqlReader(cmd);

            Restaurant tempRestaurant = new Restaurant();

            while (reader.Read())
            {

                tempRestaurant.SetIdRestaurant((Guid)reader[0]);
                tempRestaurant.SetIdOwner((Guid)reader[1]);
                tempRestaurant.SetIdRestaurantDetails((Guid)reader[2]);

            }

            dbCon.CloseDbCon();

            repository.setRestaurantDetailsById(tempRestaurant.GetIdRestaurantDetails(), dbCon, tempRestaurant);


            return tempRestaurant;
        }
    }
}
