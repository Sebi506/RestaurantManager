using RestaurantManager.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Interfaces
{
    public interface IRepository<T>
    {
         void Add(T entity, DatabaseConnection dbCon);

         void Delete(T entity, DatabaseConnection dbCon);

         void Update(T entity, DatabaseConnection dbCon);

         T Get(Guid id, DatabaseConnection dbCon);
    }
}
