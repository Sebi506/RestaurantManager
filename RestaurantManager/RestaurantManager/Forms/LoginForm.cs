﻿using RestaurantManager.Repositories;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
     
        private void loginButton_Click(object sender, EventArgs e)
        {
            User loggedUser = new User();

            string email = emailTB.Text;
            string password = passwordTB.Text;

            loggedUser.SetEmail(email);
            loggedUser.SetPassword(password);

            this.Hide();
            Form form = new Form1(loggedUser);
            form.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
