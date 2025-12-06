using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP
{
    public partial class ListForm : Form
    {
        private List<UserModel> _users;
        private int _selectedRowIndex = -1;
        private Form1 _parentForm;
        private string _originalEmail = string.Empty; 

        public ListForm(Form1 parent)
        {
            InitializeComponent();
            _parentForm = parent;

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
            _users = users;
            RefreshDataGridView();
        }

        private void datagridviewClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _selectedRowIndex = e.RowIndex;
                DataGridViewRow row = datagridviewClient.Rows[e.RowIndex];

                string email = row.Cells["Email"].Value.ToString();
                string password = row.Cells["Password"].Value.ToString();

                txtEmail.Text = email;
                txtPassword.Text = password;
                _originalEmail = email; // ⭐ Capture the original email
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndex == -1 || string.IsNullOrEmpty(_originalEmail))
            {
                MessageBox.Show("Double-click a user in the table to update.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            string newEmail = txtEmail.Text.Trim();
            string newPassword = txtPassword.Text;

          
            UserModel userToUpdate = _users.FirstOrDefault(u => u.Email.Equals(_originalEmail, StringComparison.OrdinalIgnoreCase));
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
            bool updateSuccess = repository.Update(_originalEmail, newEmail, newPassword);

            if (updateSuccess)
            {

                _users = repository.GetAllUsers();
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
            if (_selectedRowIndex == -1 || string.IsNullOrEmpty(_originalEmail))
            {
                MessageBox.Show("Double-click a user in the table to delete.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete the user with email: {_originalEmail}?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
             
                UserRepository repository = new UserRepository();
                bool deleteSuccess = repository.Delete(_originalEmail);

                if (deleteSuccess)
                {

                    _users = repository.GetAllUsers();

                    RefreshDataGridView();
                    ClearUpdateFields();


                    if (_parentForm != null)
                    {
                        _parentForm.UpdateUserList(_users);
                    }

                    MessageBox.Show($"{_originalEmail} has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            datagridviewClient.DataSource = _users;
            datagridviewClient.Refresh();
        }

        private void ClearUpdateFields()
        {
            txtEmail.Clear();
            txtPassword.Clear();
            _selectedRowIndex = -1;
            _originalEmail = string.Empty;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClearUpdateFields();

            if (_parentForm != null)
            {
                _parentForm.UpdateUserList(_users);

                _parentForm.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}