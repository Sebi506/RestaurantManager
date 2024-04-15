using RestaurantManager.Repositories;
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

        public Admin(User user)
        {
            this.SetId(user.GetId());
            this.SetFirstName(user.GetFirstName());
            this.SetLastName(user.GetLastName());
            this.SetEmail(user.GetEmail());
            this.SetPassword(user.GetPassword());
            //this.SetAccessLevel(user.GetAccessLevel());

        }
        /*
        public void SetAccessLevel(int accessLevel,User user)
        { 
            UsersRepository usersRepository = new UsersRepository();
        }*/
   
        public void ModifyAccessLevel(string email, int accesslevel)
        {
        
            //find user in db, update accesslevel

        }

        public void UpdateRestaurant() { } 
    }
}
