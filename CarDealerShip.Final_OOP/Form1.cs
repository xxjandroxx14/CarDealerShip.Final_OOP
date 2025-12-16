using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace CarDealerShip.Final_OOP
{
    public partial class Form1 : Form
    {

        private List<UserModel> _users = new List<UserModel>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            bool isInvalidInput = string.IsNullOrWhiteSpace(email)
                                 || string.IsNullOrWhiteSpace(password);

            if (isInvalidInput)
            {
                MessageBox.Show("Please fill in all fields.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                UserRepository repository = new UserRepository();
                bool userAdded = repository.Add(email, password);

                if (userAdded)
                {
                    this._users = repository.GetAllUsers();

                    MessageBox.Show("User created successfully.",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Signup failed. That email may already be in use.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;

            bool isInvalidInput = string.IsNullOrWhiteSpace(email)
                                 || string.IsNullOrWhiteSpace(password);

            if (isInvalidInput)
            {
                MessageBox.Show("Please enter both email and password.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            UserRepository repository = new UserRepository();
            bool isAuthenticated = repository.Authenticate(email, password);

            if (isAuthenticated)
            {
                MessageBox.Show("Login successful! Welcome.",
                    "Success", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                Menu menu = new Menu();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed. Check your email and password.",
                    "Authentication Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void buttonAdminList_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository();


            this._users = repository.GetAllUsers();

            ListForm listForm = new ListForm(this);


            listForm.LoadUserData(this._users);

            listForm.Show();
            this.Hide();
        }
        public void UpdateUserList(List<UserModel> updatedUsers)
        {
            this._users = updatedUsers;



        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

            textBoxPassword.PasswordChar = '*';
        }

        
    }
}