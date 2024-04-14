using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    internal class RestaurantRepository : IRepository<Restaurant>
    {

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
    }
}
