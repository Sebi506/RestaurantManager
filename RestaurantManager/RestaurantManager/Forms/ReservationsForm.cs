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

namespace RestaurantManager.Forms
{
    public partial class ReservationsForm : Form
    {
        User loggedUser;
        DatabaseConnection dbConnection;
        public ReservationsForm()
        {
            InitializeComponent();
        }

        public ReservationsForm(User user,DatabaseConnection dbCon)
        {
            InitializeComponent();

            loggedUser = user;

            dbConnection = dbCon;

            if (loggedUser.GetAccessLevel()<3)
            {
                takeTableButton.Visible= false;
                modifyTableStateButton.Visible= false;
                stateDropDown.Visible= false;
                SelectStateLabel.Visible= false;
            }

            List<Table> tables = new List<Table>();

            string query = " select * from tables ";
            SqlDataReader reader = dbConnection.ExecuteSqlReader(query);

            TableRepository tableRepository = new TableRepository();

        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
             
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
