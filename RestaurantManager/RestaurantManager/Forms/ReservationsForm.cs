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
    public partial class ReservationsForm : Form
    {
        User loggedUser;
        public ReservationsForm()
        {
            InitializeComponent();
        }

        public ReservationsForm(User user)
        {
            InitializeComponent();

            loggedUser = user;
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
             
        }

        private void reserveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
