using RestaurantManager.Connection;
using RestaurantManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManager.Forms
{
    public partial class ManagerForm : Form
    {
        User loggedUser;
        Admin admin;
        Restaurant restaurant;
        DatabaseConnection dbConnection;
        DefinesClass defines;

        bool vipTable = false;
        bool privateTable = false;


        public ManagerForm()
        {
            InitializeComponent();
        }

        public ManagerForm(User user, DatabaseConnection dbCon)
        {
            InitializeComponent();

            loggedUser = user;

            dbConnection = dbCon;

            defines = new DefinesClass();

            if (loggedUser.GetAccessLevel() == 4)
            {
                admin = new Admin(loggedUser);
            }

            FillObjectsData();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void FillObjectsData()
        {
            restaurant = new Restaurant();

            RestaurantRepository restaurantRepository = new RestaurantRepository();

            restaurant = restaurantRepository.GetRestaurant(dbConnection);

            List<Table> tables = new List<Table>();


            TableRepository tableRepository = new TableRepository();

            tables = tableRepository.GetAllTables(dbConnection);

            restaurant.SetTables(tables);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void addTableButton_Click(object sender, EventArgs e)
        {
            string tableName = "";
            int capacity = 0;
            int state = 0;
            tableName = tableNameTB.Text;
            capacity = int.Parse(capacityTB.Text);
            Table tempTable = new Table(tableName,state,capacity);

            if (privateTable == true)
            {
                tempTable.IsPrivateTable(privateTable);
                privateTable = false;
            }
            if (vipTable == true)
            {
                tempTable.IsVipTable(vipTable);
                vipTable = false;
            }
            if (tDetailsTB.Text != "")
            {
                tempTable.SetDetails(tDetailsTB.Text);
            }

            restaurant.AddTable(tempTable);
        }

        private void vipTableButton_Click(object sender, EventArgs e)
        {
            if (vipTable == false) vipTable = true;
            if (vipTable == true) vipTable = false;
        }

        private void privateTableButton_Click(object sender, EventArgs e)
        {
            if(privateTable == false) privateTable = true;
            if(privateTable == true) privateTable = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form form = new Form1(loggedUser);
            form.ShowDialog();
        }
    }
}
