using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP
{
    public partial class ListForm : Form
    {
        private List<UserModel> Users;
        private int SelectedRowIndex = -1;
        private Form1 ClientForm;
        private string OriginalEmail = string.Empty;

        public ListForm(Form1 parent)
        {
            InitializeComponent();
            ClientForm = parent;

            datagridviewClient.CellDoubleClick += datagridviewClient_CellDoubleClick;

            buttonDelete.Click += buttonDelete_Click;
            buttonBack.Click += buttonBack_Click;
        }


        public ListForm()
        {
            InitializeComponent();

        }

        public void LoadUserData(List<UserModel> users)
        {
            Users = users;
            RefreshDataGridView();
        }

        private void datagridviewClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SelectedRowIndex = e.RowIndex;
                DataGridViewRow row = datagridviewClient.Rows[e.RowIndex];

                string email = row.Cells["Email"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();

                txtEmail.Text = email;
                txtPassword.Text = password;
                OriginalEmail = email;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (SelectedRowIndex == -1 || string.IsNullOrEmpty(OriginalEmail))
            {
                MessageBox.Show("Double-click a user in the table to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string newEmail = txtEmail.Text.Trim();
            string newPassword = txtPassword.Text;


            UserModel userToUpdate = Users.FirstOrDefault(u => u.Email.Equals(OriginalEmail, StringComparison.OrdinalIgnoreCase));
            if (userToUpdate == null)
            {
                MessageBox.Show("Error: Original user data not found.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEmailUnchanged = userToUpdate.Email.Equals(newEmail, StringComparison.OrdinalIgnoreCase);
            bool isPasswordUnchanged = userToUpdate.Password.Equals(newPassword);

            if (isEmailUnchanged && isPasswordUnchanged)
            {
                MessageBox.Show("No changes detected.", "No Update Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            UserRepository repository = new UserRepository();
            bool updateSuccess = repository.Update(OriginalEmail, newEmail, newPassword);

            if (updateSuccess)
            {

                Users = repository.GetAllUsers();
                RefreshDataGridView();
                ClearUpdateFields();
                MessageBox.Show("Successfully updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update failed. The new email may already be in use by another user.", "Update Failed: Email Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SelectedRowIndex == -1 || string.IsNullOrEmpty(OriginalEmail))
            {
                MessageBox.Show("Double-click a user in the table to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the user with email: {OriginalEmail}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {

                UserRepository repository = new UserRepository();
                bool deleteSuccess = repository.Delete(OriginalEmail);

                if (deleteSuccess)
                {

                    Users = repository.GetAllUsers();

                    RefreshDataGridView();
                    ClearUpdateFields();


                    if (ClientForm != null)
                    {
                        ClientForm.UpdateUserList(Users);
                    }

                    MessageBox.Show($"{OriginalEmail} has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deletion failed in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefreshDataGridView()
        {
            datagridviewClient.DataSource = null;
            datagridviewClient.DataSource = Users;
            datagridviewClient.Refresh();
        }

        private void ClearUpdateFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            SelectedRowIndex = -1;
            OriginalEmail = string.Empty;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();

            if (ClientForm != null)
            {
                ClientForm.UpdateUserList(Users);

                ClientForm.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
       