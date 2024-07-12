using RestaurantManager.Connection;
using RestaurantManager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace RestaurantManager.Forms
{
    public partial class ReservationsForm : Form
    {
        User loggedUser;
        Admin admin;
        Restaurant restaurant;
        DatabaseConnection dbConnection;
        DefinesClass defines;

        public ReservationsForm()
        {
            InitializeComponent();
        }

        public ReservationsForm(User user,DatabaseConnection dbCon)
        {
            InitializeComponent();

            loggedUser = user;

            dbConnection = dbCon;

            defines = new DefinesClass();

            if(loggedUser.GetAccessLevel()==4)
            {
                admin = new Admin(loggedUser);
            }


            UIVisibility();

            FillObjectsData();

            PrepareListView();

            PrepareDropDown();
        }

        private void PrepareListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Table name");
            listView1.Columns.Add("Capacity ");
            listView1.Columns.Add("Status ");
            listView1.Columns[0].Width = 50;

            FillListView();
        }

        private void PrepareDropDown()
        {
            stateDropDown.Items.Add(defines.GetTableDefine(1));
            stateDropDown.Items.Add(defines.GetTableDefine(2));
            stateDropDown.Items.Add(defines.GetTableDefine(3));
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

        private void UIVisibility()
        {
            if (loggedUser.GetAccessLevel() < 3)
            {
                takeTableButton.Visible = false;
                modifyTableStateButton.Visible = false;
                stateDropDown.Visible = false;
                SelectStateLabel.Visible = false;
            }
        }
        private void FillListView()
        {

            listView1.Items.Clear();
            foreach (Table table in restaurant.GetTables())
            {

                listView1.Items.Add(new ListViewItem(new[] { table.GetTableName(),table.GetTableCapacity().ToString(), defines.GetTableDefine(table.GetState())}));
                
            }

        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
             
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            string tablename = textBox2.Text;

            restaurant.UpdateTableState(2, tablename, loggedUser.GetAccessLevel());

            FillListView();

        }

        private void takeTableButton_Click(object sender, EventArgs e)
        {
            string tablename = textBox2.Text;

            restaurant.SetTableServer(loggedUser, tablename);

            FillListView();
        }

        private void modifyTableStateButton_Click(object sender, EventArgs e)
        {
            string tablename = textBox2.Text;

            int option = defines.GetTableDefine(stateDropDown.SelectedItem.ToString());

            restaurant.UpdateTableState(option, tablename, loggedUser.GetAccessLevel());

            FillListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1(loggedUser);
            form.ShowDialog();
        }
    }
}
