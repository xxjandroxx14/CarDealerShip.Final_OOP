
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP
{
    public partial class ListForm : Form
    {
        public ListForm()
        {


            InitializeComponent();
        }

        private void Buttonview_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to User Manager!");

            UserRepository userRepository = new UserRepository();
            List<UserModel> users = userRepository.GetAllUsers();

            LoadUserData(users);
        }


        public void LoadUserData(List<UserModel> users)
        {

            datagridviewClient.DataSource = users;
        }

    }
}