using SMS_Backend.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Frontend
{
    public partial class UserProfInfo : Form
    {
        private string[] cachedProps = [];
        private User? selUser;
        private void RefreshList()
        {
            lstUsers.Items.Clear();
            lstUsers.Items.AddRange(Program.Users.Keys.ToArray());
            btnDelUser.Enabled = lstUsers.SelectedItems.Count != 0 && Program.Users.Count > 1;
        }

        public UserProfInfo()
        {
            InitializeComponent();
            RefreshList();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelUser.Enabled = lstUsers.SelectedItems.Count != 0 && Program.Users.Count > 1;
            txtUsername.Enabled = lstUsers.SelectedItems.Count != 0;
            txtPassword.Enabled = lstUsers.SelectedItems.Count != 0;
            txtRole.Enabled = lstUsers.SelectedItems.Count != 0;
            txtDept.Enabled = lstUsers.SelectedItems.Count != 0;
            txtOfficeLoc.Enabled = lstUsers.SelectedItems.Count != 0;
            User? user = Program.Users[lstUsers.SelectedItem.ToString()];
            if (user is not null)
            {
                txtUsername.Text = user.Username;
                txtPassword.Text = user.Password;
                txtRole.Text = user.Role;
                txtDept.Text = user.Department;
                txtOfficeLoc.Text = user.OfficeLocation;
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!btnCancelCreate.Visible)
            { // then enter creation mode
                btnCancelCreate.Visible = true;
                btnDelUser.Visible = false;
                btnClose.Enabled = false;
                btnAddUser.Enabled = false;
                lstUsers.Enabled = false;
                cachedProps = [
                    txtUsername.Text,
                    txtPassword.Text,
                    txtRole.Text,
                    txtDept.Text,
                    txtOfficeLoc.Text
                    ];
                txtUsername.Clear();
                txtPassword.Clear();
                txtRole.Clear();
                txtDept.Clear();
                txtOfficeLoc.Clear();
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
                txtRole.Enabled = true;
                txtDept.Enabled = true;
                txtOfficeLoc.Enabled = true;
            }
            else
            { // create the user
                btnCancelCreate.Visible = false;
                btnDelUser.Visible = true;
                btnClose.Enabled = true;
                string name = txtUsername.Text.Trim();
                Program.Users.Add(name, new User(name, txtPassword.Text, txtRole.Text, txtDept.Text, txtOfficeLoc.Text));
                btnAddUser.Enabled = true;
                lstUsers.Enabled = true;
                RefreshList();
                lstUsers.SelectedItem = name;
            }
        }

        private void btnCancelCreate_Click(object sender, EventArgs e)
        {
            btnCancelCreate.Visible = false;
            btnDelUser.Visible = true;
            btnClose.Enabled = true;
            lstUsers.Enabled = true;
            btnDelUser.Visible = true;
            btnClose.Enabled = true;
            txtUsername.Text = cachedProps[0];
            txtPassword.Text = cachedProps[1];
            txtRole.Text = cachedProps[2];
            txtDept.Text = cachedProps[3];
            txtOfficeLoc.Text = cachedProps[4];
            btnAddUser.Enabled = true;
            txtUsername.Enabled = lstUsers.SelectedItems.Count != 0;
            txtPassword.Enabled = lstUsers.SelectedItems.Count != 0;
            txtRole.Enabled = lstUsers.SelectedItems.Count != 0;
            txtDept.Enabled = lstUsers.SelectedItems.Count != 0;
            txtOfficeLoc.Enabled = lstUsers.SelectedItems.Count != 0;
            lstUsers.Enabled = true;
        }

        private void btnDelUser_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("You haven't selected any users to delete.", "Can't delete 0 users",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Program.LoggedInUser is not null && lstUsers.SelectedItem.ToString().Equals(Program.LoggedInUser.Username))
            {
                MessageBox.Show("You can't delete yourself!", "Can't delete self",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Delete the selected users?\nThis cannot be undone.",
                "Delete Selected Users",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                Program.Users.Remove(lstUsers.SelectedItem.ToString());
                RefreshList();
                txtUsername.Clear();
                txtPassword.Clear();
                txtRole.Clear();
                txtDept.Clear();
                txtOfficeLoc.Clear();
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
                txtRole.Enabled = false;
                txtDept.Enabled = false;
                txtOfficeLoc.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            
            string newName = txtUsername.Text.Trim();

            if (lstUsers.Enabled && lstUsers.SelectedItem is not null && !Program.Users.ContainsKey(newName) && !newName.Equals(""))
            {
                string oldName = lstUsers.SelectedItem.ToString();
                User user = Program.Users[oldName];
                bool isSelf = Program.LoggedInUser.Equals(user);

                user.Username = newName;

                Program.Users.Remove(oldName);
                Program.Users.Add(newName, user);

                if (isSelf) Program.LoggedInUser = user;

                RefreshList();
                lstUsers.SelectedItem = newName;
            }
            else if (!lstUsers.Enabled) btnAddUser.Enabled = !txtUsername.Text.Trim().Equals("") && !Program.Users.ContainsKey(txtUsername.Text.Trim()) &&
                                        !txtPassword.Text.Equals("") &&
                                        !txtRole.Text.Equals("") &&
                                        !txtDept.Text.Equals("") &&
                                        !txtOfficeLoc.Text.Equals("");
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string password = txtPassword.Text;
            if (lstUsers.Enabled && lstUsers.SelectedItem is not null && !password.Equals("")) Program.Users[lstUsers.SelectedItem.ToString()].Password = password;
            else if (!lstUsers.Enabled) btnAddUser.Enabled = !txtUsername.Text.Trim().Equals("") && !Program.Users.ContainsKey(txtUsername.Text.Trim()) &&
                                        !txtPassword.Text.Equals("") &&
                                        !txtRole.Text.Equals("") &&
                                        !txtDept.Text.Equals("") &&
                                        !txtOfficeLoc.Text.Equals("");
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            string role = txtRole.Text;
            if (lstUsers.Enabled && lstUsers.SelectedItem is not null && !role.Equals("")) Program.Users[lstUsers.SelectedItem.ToString()].Role = role;
            else if (!lstUsers.Enabled) btnAddUser.Enabled = !txtUsername.Text.Trim().Equals("") && !Program.Users.ContainsKey(txtUsername.Text.Trim()) &&
                                        !txtPassword.Text.Equals("") &&
                                        !txtRole.Text.Equals("") &&
                                        !txtDept.Text.Equals("") &&
                                        !txtOfficeLoc.Text.Equals("");
        }

        private void txtDept_TextChanged(object sender, EventArgs e)
        {
            string department = txtDept.Text;
            if (lstUsers.Enabled && lstUsers.SelectedItem is not null && !department.Equals("")) Program.Users[lstUsers.SelectedItem.ToString()].Department = department;
            else if (!lstUsers.Enabled) btnAddUser.Enabled = !txtUsername.Text.Trim().Equals("") && !Program.Users.ContainsKey(txtUsername.Text.Trim()) &&
                                        !txtPassword.Text.Equals("") &&
                                        !txtRole.Text.Equals("") &&
                                        !txtDept.Text.Equals("") &&
                                        !txtOfficeLoc.Text.Equals("");
        }

        private void txtOfficeLoc_TextChanged(object sender, EventArgs e)
        {
            string location = txtOfficeLoc.Text;
            if (lstUsers.Enabled && lstUsers.SelectedItem is not null && !location.Equals("")) Program.Users[lstUsers.SelectedItem.ToString()].OfficeLocation = location;
            else if (!lstUsers.Enabled) btnAddUser.Enabled = !txtUsername.Text.Trim().Equals("") && !Program.Users.ContainsKey(txtUsername.Text.Trim()) &&
                                        !txtPassword.Text.Equals("") &&
                                        !txtRole.Text.Equals("") &&
                                        !txtDept.Text.Equals("") &&
                                        !txtOfficeLoc.Text.Equals("");
        }
    }
}
