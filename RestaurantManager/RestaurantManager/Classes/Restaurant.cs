using RestaurantManager.Connection;
using RestaurantManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal class Restaurant
    {
        Guid idRestaurant;
        Guid idOwner;
        Guid idRestaurantDetails;
        string name;
        string location;
        int state;
        List<Table> tables = new List<Table>();
       // RestaurantRepository repository;

        public Restaurant() { }

        public Restaurant(string name, string location, int state, List<Table> tables)
        {
            this.name = name;
            this.location = location;
            this.state = state;
            this.tables = tables;
        }
/*
        public Restaurant(Guid id,DatabaseConnection dbCon) {

            Restaurant tempRestaurant = new Restaurant();
            tempRestaurant = repository.GetRestaurantByOwner(id,dbCon);
            this.idRestaurant = tempRestaurant.GetIdRestaurant();
            this.idOwner = tempRestaurant.GetIdOwner();
            this.idRestaurantDetails = tempRestaurant.GetIdRestaurantDetails();
            this.name = tempRestaurant.GetName();
            this.location = tempRestaurant.GetLocation();
            this.state = tempRestaurant.GetState();
        }
*/
        public Guid GetIdRestaurant() { return idRestaurant; }
        public Guid GetIdOwner() { return idOwner; }
        public Guid GetIdRestaurantDetails() { return idRestaurantDetails; }
        public string GetName() { return name; }
        public string GetLocation() { return location; }
        public int GetState() { return state; }
        public List<Table> GetTables() { return tables;}

        public void SetIdRestaurant(Guid id) { idRestaurant = id; }
        public void SetIdOwner(Guid id) { idOwner = id; }
        public void SetIdRestaurantDetails(Guid id) { idRestaurantDetails = id; }
        public void SetName(string name) { this.name = name;}
        public void SetLocation(string location) {  this.location = location;}
        public void SetState(int state) {  this.state = state;}
        public void SetTables(List<Table> tables) { this.tables = tables; }   

        public void AddTable(Table table) {
            tables.Add(table);
        }

        public void UpdateTableState(int state,string TableName,int accessLevel) {

            Table tempTable = new Table();
            tempTable = tables.Find(table => table.GetTableName() ==  TableName);

            if (accessLevel < 3)
            {
                if (tempTable.GetState() == 1)
                    tempTable.SetState(state);
            }
            if (accessLevel >= 3)
            {
                    tempTable.SetState(state);
            }

        }
        
        public void SetTableServer(User user,string TableName)
        {
            Table tempTable = new Table();
            tempTable = tables.Find(table => table.GetTableName() == TableName);

            if (tempTable.GetState() != 1)
            {
                tempTable.SetIdServer(user.GetId());
             }
        }

    }
}
