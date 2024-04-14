using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
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

    }
}
