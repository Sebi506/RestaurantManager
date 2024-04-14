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
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(User user)
        {
            InitializeComponent();
            loggedUser = user;

            DatabaseConnection dbCon = new DatabaseConnection();

            UsersRepository usersRepository = new UsersRepository();

            bool value = usersRepository.VerifyUserCredentials(user.GetEmail(),user.GetPassword(),dbCon);
          
            if (value)
            {
                label1.Text = "Login successfull";
                loggedUser = usersRepository.GetUserByEmail(user.GetEmail(), dbCon);
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
            Form loginForm = new ReservationsForm(loggedUser) ;
            loginForm.ShowDialog();
        }
    }
}
