
using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using System.Collections.Generic; // Required for List<UserModel>
using System;

namespace CarDealerShip.Final_OOP
{
    public partial class Form1 : Form
    {
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
                    MessageBox.Show("User created successfully. Click the 'View Users' button to see the list.",
                        "Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Menu menu = new Menu();
                    menu.Show();
                    this.Hide(); // Change is here: Hides Form1 instead of closing it

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
                this.Hide(); // Change is here: Hides Form1 instead of closing it
            }
            else
            {
                MessageBox.Show("Login failed. Check your email and password.",
                    "Authentication Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }

}