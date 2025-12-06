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

        private void button1_Click(object sender, EventArgs e)
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

        // In Form1.cs

        private void buttonAdminList_Click(object sender, EventArgs e)
        {
            UserRepository repository = new UserRepository();

            // 1. Fetch the latest list (which now reflects database deletions/updates)
            this._users = repository.GetAllUsers();

            ListForm listForm = new ListForm(this);

            // 2. Load the FRESH list into the new ListForm
            listForm.LoadUserData(this._users);

            listForm.Show();
            this.Hide();
        }
        public void UpdateUserList(List<UserModel> updatedUsers)
        {
            this._users = updatedUsers;

            /* * IMPORTANT: If Form1 contains a DataGridView named 'dataGridViewUsers' 
             * that displays the user list, uncomment the following block to refresh it.
            */
            // if (dataGridViewUsers != null)
            // {
            //     dataGridViewUsers.DataSource = null;
            //     dataGridViewUsers.DataSource = this._users;
            // }
        }
    }
}