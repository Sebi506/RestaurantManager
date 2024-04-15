using RestaurantManager.Connection;
using RestaurantManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal class Table
    {
        Guid idTable;
        Guid idRestaurant;
        Guid idServer;
        string tableName;
        int state;
        int tableCapacity;
       // TableRepository repository;

        public Table()
        {
        }

      /*  public Table(Guid id,DatabaseConnection dbCon)
        {
            repository = new TableRepository();
            Table table  = repository.GetById(id, dbCon);
        }*/

        public Table(string tableName, int state, int tableCapacity)
        {
            this.tableName = tableName;
            this.state = state;
            this.tableCapacity = tableCapacity;
        }

        public Guid GetIdTable() { return idTable; }
        public Guid GetIdRestaurant() { return idRestaurant; }
        public Guid GetIdServer() { return idServer; }
        public string GetTableName() { return tableName; }
        public int GetTableCapacity() {  return tableCapacity; }
        public int GetState() { return state; }

        public void SetIdTable(Guid idTable) {  this.idTable = idTable; }
        public void SetIdRestaurant(Guid idRestaurant) {  this.idRestaurant = idRestaurant; }
        public void SetIdServer(Guid idServer) {  this.idServer = idServer; }
        public void SetTableName(string tableName) { this.tableName = tableName;}
        public void SetTableCapacity(int tableCapacity) {  this.tableCapacity = tableCapacity;}
        public void SetState(int state) {  this.state = state;}

    }
}
