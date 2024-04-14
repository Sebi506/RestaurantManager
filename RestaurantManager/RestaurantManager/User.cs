using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal  class User
    {
        string FirstName;
        string LastName;
        string Email;
        string Password;
        int AccessLevel;

        public User() { 
        
        }

        public void LogIn(string Email, string Password)
        {
            //find user in db by email+password
            //fill data from db
        }

        
    }
}
