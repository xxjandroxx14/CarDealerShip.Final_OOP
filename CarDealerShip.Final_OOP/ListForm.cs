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

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (datagridviewClient.SelectedRows.Count > 0)
            {
               
                string emailToDelete = datagridviewClient.SelectedRows[0].Cells["Email"].Value.ToString();

                
                DialogResult confirmResult = MessageBox.Show(
                    $"Are you sure you want to delete the user with email: {emailToDelete}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // 4. Delete from the database
                    UserRepository repository = new UserRepository();
                    int rowsDeleted = repository.Delete(emailToDelete);

                    if (rowsDeleted > 0)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 5. Refresh the DataGridView instantly by reloading all users
                        List<UserModel> updatedUsers = repository.GetAllUsers();
                        LoadUserData(updatedUsers);
                    }
                    else
                    {
                        MessageBox.Show("Deletion failed. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}