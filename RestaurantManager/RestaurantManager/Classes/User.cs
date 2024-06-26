﻿using RestaurantManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public  class User
    {
        Guid id;
        string FirstName { get; set; }
        string LastName;
        string Email;
        string Password;
        int AccessLevel;

        UsersRepository usersRepository;
        public User() { 
            usersRepository = new UsersRepository();
        }

        public Guid GetId() { return id; }
        public string GetFirstName() { return FirstName; }
        public string GetLastName() { return LastName; } 
        public string GetEmail() { return Email; } 
        public string GetPassword() { return Password;}
        public int GetAccessLevel() { return AccessLevel;}

        public void SetId(Guid id) { this.id = id;}
        public void SetFirstName(string firstName) {  FirstName = firstName; }
        public void SetLastName(string lastName) {  LastName = lastName; }
        public void SetEmail(string email) {  Email = email; }  
        public void SetPassword(string password) {  Password = password; }
        public void SetAccessLevel(int accessLevel) {  AccessLevel = accessLevel; }
        public void LogIn(string Email, string Password)
        {
            //find user in db by email+password
            //fill data from db
        }

        
    }
}
