using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    internal class TableRepository : IRepository<Table>
    {
        void IRepository<Table>.Add(Table entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<Table>.Delete(Table entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<Table>.Update(Table entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        Table IRepository<Table>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }
    }
}
