﻿using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager.Repositories
{
    public class UsersRepository : IRepository<User>
    {

        void IRepository<User>.Add(User user, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("insert into Users values(@id,@firstName,@lastName,@email,@password,@accesslevel) ");
            Guid Id= Guid.NewGuid();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.Parameters.AddWithValue("@firstName", user.GetFirstName());
            cmd.Parameters.AddWithValue("@lastName", user.GetLastName());
            cmd.Parameters.AddWithValue("@email", user.GetEmail());
            cmd.Parameters.AddWithValue("@password", user.GetPassword());
            cmd.Parameters.AddWithValue("@accesslevel", 1);

            dbCon.ExecuteSqlCommand(cmd);

        }

        void IRepository<User>.Delete(User entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        void IRepository<User>.Update(User entity, DatabaseConnection dbCon)
        {
            throw new NotImplementedException();
        }

        User IRepository<User>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }

        public User GetUserByEmail(string email, DatabaseConnection dbCon)
        {
            User user = new User();

            SqlCommand cmd = new SqlCommand("select * from  Users where Users.email = @email ");
            Guid Id = Guid.NewGuid();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                user.SetId ((Guid)reader["id_user"]);
                user.SetFirstName((string)reader["firstName"]);
                user.SetLastName((string)reader["lastName"]);
                user.SetEmail((string)reader["email"]);
                user.SetPassword((string)reader["userPassword"]);
                user.SetAccessLevel((int)reader["accessLevel"]);

            }

            return user;
        }

        public bool VerifyUserCredentials(string email,string password, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "select * from  Users where Users.email = @email and Users.userPassword = @password ";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            dbCon.OpenDbCon();

            SqlDataReader reader = dbCon.ExecuteSqlReader(cmd);

            if (reader.Read()) { return true; dbCon.CloseDbCon(); }
            dbCon.CloseDbCon();
            return false;
        }
    }
}
