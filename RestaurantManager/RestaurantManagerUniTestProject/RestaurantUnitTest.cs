using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RestaurantManager;

namespace RestaurantManagerUniTestProject
{
    [TestClass]
    public class RestaurantUnitTest
    {

        /*
         Unit test for UpdateTableState
         Case 1 : accessLevel>=3 
         Expected result : table state changed 
         */
        [TestMethod]
        public void UpdateRestaurantStateTest1()
        {
            //Arrange
            Restaurant restaurant = new Restaurant();
            Table table = new Table();
            int old_state = 1;
            int new_state = 2;

            int accessLevel = 4;

            table.SetState(old_state);
            table.SetTableName("test-table");
            restaurant.AddTable(table);

            

            //Act
            restaurant.UpdateTableState(new_state, table.GetTableName(), accessLevel);

            //Assert

            Assert.AreEqual(table.GetState(), new_state);


        }

        /*
         Unit test for UpdateTableState
         Case 2 : accessLevel<3 | old table state == 1
         Expected result : Table state changed
         */
        [TestMethod]
        public void UpdateRestaurantStateTest2()
        {
            //Arrange
            Restaurant restaurant = new Restaurant();
            Table table = new Table();
            int old_state = 1;
            int new_state = 2;

            int accessLevel = 1;

            table.SetState(old_state);
            table.SetTableName("test-table");
            restaurant.AddTable(table);

            //Act
            restaurant.UpdateTableState(new_state, table.GetTableName(), accessLevel);

            //Assert

            Assert.AreEqual(table.GetState(), new_state);

        }

        /*
         Unit test for UpdateTableState
         Case 3 : accessLevel<3 | old table state != 1
         Expected result : Table state not changed
         */
        [TestMethod]
        public void UpdateRestaurantStateTest3()
        {
            //Arrange
            Restaurant restaurant = new Restaurant();
            Table table = new Table();
            int old_state = 2;
            int new_state = 3;

            int accessLevel = 1;

            table.SetState(old_state);
            table.SetTableName("test-table");
            restaurant.AddTable(table);



            //Act
            restaurant.UpdateTableState(new_state, table.GetTableName(), accessLevel);

            //Assert

            Assert.AreEqual(table.GetState(), old_state);

        }

        /*
         Unit test for UpdateTableState
         Case 1 : table state is "free"
         Expected result : Table server not assigned
         */
        [TestMethod]
        public void SetTableServerTest1()
        {
            //Arrange

            User user = new User();
            Guid id;
            id= Guid.NewGuid();
            Restaurant restaurant = new Restaurant();
            Table table = new Table();

            user.SetAccessLevel(2);
            user.SetId(id);
            table.SetState(1);
            table.SetTableName("test-table");
            restaurant.AddTable(table);
            //Act

            restaurant.SetTableServer(user, table.GetTableName());

            //Assert

            Assert.AreNotEqual(table.GetIdServer(), user.GetId());

        }

        /*
         Unit test for UpdateTableState
         Case 2 : table state is "not free"
         Expected result : Table server assigned
         */
        [TestMethod]
        public void SetTableServerTest2()
        {
            //Arrange

            User user = new User();
            Guid id;
            id = Guid.NewGuid();
            Restaurant restaurant = new Restaurant();
            Table table = new Table();

            user.SetAccessLevel(2);
            user.SetId(id);
            table.SetState(2);
            table.SetTableName("test-table");
            restaurant.AddTable(table);
            //Act

            restaurant.SetTableServer(user, table.GetTableName());

            //Assert

            Assert.AreEqual(table.GetIdServer(), user.GetId());

        }
    }
}
