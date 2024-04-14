using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal class Admin : User
    {

        public Admin() { }

        public void ModifyAccessLevel(User user, int accesslevel)
        {
        
            //find user in db, update accesslevel

        }

        public void UpdateRestaurant() { } 
    }
}
