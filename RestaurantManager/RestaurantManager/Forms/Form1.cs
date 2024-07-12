using RestaurantManager.Connection;
using RestaurantManager.Forms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;



namespace RestaurantManager
{
    public partial class Form1 : Form
    {
        User loggedUser;
        DatabaseConnection dbCon;
        public Form1()
        {
            InitializeComponent();
            manageRestaurantButton.Visible = false;
        }
        public Form1(User user)
        {
            InitializeComponent();
            loggedUser = user;
            manageRestaurantButton.Visible = false;
            dbCon = DatabaseConnection.Instance;

            UsersRepository usersRepository = new UsersRepository();

            bool value = usersRepository.VerifyUserCredentials(user.GetEmail(),user.GetPassword(),dbCon);
          
            if (value)
            {
                label1.Text = "Login successfull";
                loggedUser = usersRepository.GetUserByEmail(user.GetEmail(), dbCon);
                if (loggedUser.GetAccessLevel() == 4)
                {
                    manageRestaurantButton.Visible = true;
                }
            }
            else
            {
                label1.Text = "Login failed";
            }
           
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form loginForm = new ReservationsForm(loggedUser,dbCon) ;
            loginForm.ShowDialog();
        }

        private void manageRestaurantButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form managerForm = new ManagerForm(loggedUser, dbCon);
            managerForm.ShowDialog();

        }
    }
}
