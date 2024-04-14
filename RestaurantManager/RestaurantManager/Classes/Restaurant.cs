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
        string name;
        string location;
        int state;
        List<Table> tables = new List<Table>();

        public Restaurant() { }

        public Restaurant(string name, string location, int state, List<Table> tables)
        {
            this.name = name;
            this.location = location;
            this.state = state;
            this.tables = tables;
        }

        public string GetName() { return name; }
        public string GetLocation() { return location; }
        public int GetState() { return state; }
        public List<Table> GetTables() { return tables;}
        public void SetName(string name) { this.name = name;}
        public void SetLocation(string location) {  this.location = location;}
        public void SetState(int state) {  this.state = state;}
        public void SetTables(List<Table> tables) { }   

    }
}
