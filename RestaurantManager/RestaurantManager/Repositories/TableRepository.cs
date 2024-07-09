using RestaurantManager.Connection;
using RestaurantManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManager.Classes;

namespace RestaurantManager.Repositories
{
    internal class TableRepository : IRepository<Table> 
    {
        void IRepository<Table>.Add(Table entity, DatabaseConnection dbCon)
        {

            SqlCommand cmd = new SqlCommand("insert into Table values(@id_table,@id_restaurant,@id_server,@tableName,@tableCapacity,@tableState) ");
            Guid Id = Guid.NewGuid();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_table", Id);
            cmd.Parameters.AddWithValue("@id_restaurant", entity.GetIdRestaurant());
            cmd.Parameters.AddWithValue("@id_server", entity.GetIdServer());
            cmd.Parameters.AddWithValue("@tableName", entity.GetTableName());
            cmd.Parameters.AddWithValue("@tableCapacity", entity.GetTableCapacity());
            cmd.Parameters.AddWithValue("@tableState", 1);

            dbCon.ExecuteSqlCommand(cmd);
        }

        void IRepository<Table>.Delete(Table entity, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("delete from RestaurantTable where id_table=@id");
            Guid Id = Guid.NewGuid();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", entity.GetIdTable());
            dbCon.ExecuteSqlCommand(cmd);
        }

        void IRepository<Table>.Update(Table entity, DatabaseConnection dbCon)
        {
            SqlCommand cmd = new SqlCommand("update RestaurantTable set capacity =@Capacity where id_table=@id");
            Guid Id = Guid.NewGuid();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Capacity", entity.GetTableCapacity());
            cmd.Parameters.AddWithValue("@id", entity.GetIdTable());

            dbCon.ExecuteSqlCommand(cmd);
        }

        Table IRepository<Table>.Get(Guid id, DatabaseConnection dbCon)
        {
            return null;
        }

        public List<Table> GetAllTables(DatabaseConnection dbCon)
        {
            List<Table> tables= new List<Table>();

            string query = "select * from RestaurantTable";

            dbCon.OpenDbCon();

            SqlDataReader reader = dbCon.ExecuteSqlReader(query);

            while(reader.Read()) {

            Table tempTable = new Table();
            tempTable.SetIdTable((Guid)reader[0]);
            tempTable.SetIdRestaurant((Guid)reader[1]);
            if ((DBNull)reader[2]!= DBNull.Value ) { tempTable.SetIdServer((Guid)reader[2]); }
            tempTable.SetTableName(reader[3].ToString());
            tempTable.SetTableCapacity((int)reader[4]);
            tempTable.SetState((int)reader[5]);
            
            tables.Add(tempTable);
            }

            dbCon.CloseDbCon();

            return tables;
        }

        public Table GetById(Guid id,DatabaseConnection dbCon) 
        {
            Table tempTable = new Table();
            SqlCommand cmd = new SqlCommand("select * from RestaurantTable where id_table=@idTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idTable", id);

            dbCon.OpenDbCon();

            SqlDataReader reader = dbCon.ExecuteSqlReader(cmd);


            while (reader.Read())
            {

                tempTable.SetIdTable((Guid)reader[0]);
                tempTable.SetIdRestaurant((Guid)reader[1]);
                if ((DBNull)reader[2] != DBNull.Value) { tempTable.SetIdServer((Guid)reader[2]); }
                tempTable.SetTableName(reader[3].ToString());
                tempTable.SetTableCapacity((int)reader[4]);
                tempTable.SetState((int)reader[5]);

            }

            dbCon.CloseDbCon();


            return tempTable;
        }
    }
}
