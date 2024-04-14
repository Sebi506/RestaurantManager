using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    internal class Table
    {
        string tableName;
        int state;
        int tableCapacity;

        public Table()
        {
        }

        public Table(string tableName, int state, int tableCapacity)
        {
            this.tableName = tableName;
            this.state = state;
            this.tableCapacity = tableCapacity;
        }

        public string GetTableName(string tableName) { return tableName; }
        public int GetTableCapacity() {  return tableCapacity; }
        public int GetState() { return state; }

        public void SetTableName(string tableName) { this.tableName = tableName;}
        public void SetTableCapacity(int tableCapacity) {  this.tableCapacity = tableCapacity;}
        public void SetState(int state) {  this.state = state;}
    }
}
