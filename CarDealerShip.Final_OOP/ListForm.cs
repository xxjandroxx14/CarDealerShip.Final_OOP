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

        public ListForm()
        {
            InitializeComponent();

            datagridviewClient.CellDoubleClick += datagridviewClient_CellDoubleClick;
            buttonUpdate.Click += buttonUpdate_Click;
            buttonDelete.Click += buttonDelete_Click;
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

                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtPassword.Text = row.Cells["Password"].Value.ToString();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndex == -1 || _selectedRowIndex >= _users.Count)
            {
                MessageBox.Show(" Double-click to update.");
                return;
            }

            UserModel userToUpdate = _users[_selectedRowIndex];
            string newEmail = txtEmail.Text.Trim();
            string newPassword = txtPassword.Text;

          
            bool isEmailUnchanged = userToUpdate.Email.Equals(newEmail, StringComparison.OrdinalIgnoreCase);
            bool isPasswordUnchanged = userToUpdate.Password.Equals(newPassword);

            if (isEmailUnchanged && isPasswordUnchanged)
            {
                MessageBox.Show("Already Exists .", "No Update Needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!isEmailUnchanged)
            {
                bool emailExists = _users.Any(u =>
                    u.Email.Equals(newEmail, StringComparison.OrdinalIgnoreCase) &&
                    _users.IndexOf(u) != _selectedRowIndex);

                if (emailExists)
                {
                    MessageBox.Show("The new email address you entered is already Existing .", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

     
            userToUpdate.Email = newEmail;
            userToUpdate.Password = newPassword;

            RefreshDataGridView();
            ClearUpdateFields();
            MessageBox.Show($"Successfully updated.");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (_selectedRowIndex == -1 || _selectedRowIndex >= _users.Count)
            {
                MessageBox.Show("Doubled Click to delete.");
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                _users.RemoveAt(_selectedRowIndex);

                RefreshDataGridView();
                ClearUpdateFields();
                MessageBox.Show($" Has been deleted.");
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
        }

        private void textBoxEmailList_TextChanged(object sender, EventArgs e)
        {

        }
    }
}