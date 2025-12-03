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

                   
                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    MessageBox.Show("Signup failed. That email may already be in use.",
                        "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

       
        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
           
            UserRepository repository = new UserRepository();
            List<UserModel> allUsers = repository.GetAllUsers();

           
            ListForm dataForm = new ListForm();
            dataForm.LoadUserData(allUsers);
            dataForm.ShowDialog();
        }
    }
}