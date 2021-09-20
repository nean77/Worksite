using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using Worksite.UserControls.Helpers;
using Worksite.Forms;
using MetroFramework;

namespace Worksite.UserControls
{
    public partial class AdministrationUserControl : MetroUserControl
    {
        public AdministrationUserControl()
        {
            InitializeComponent();
            FillUsers();
        }

        private async void FillUsers()
        {
            AdministrationControlHelpers helpers = new AdministrationControlHelpers();
            var list = await helpers.GetUsersAsync();
            usersListBox.Items.Clear();
            foreach (var l in list)
            {
                usersListBox.Items.Add(l);
            }
        }
        private bool ValidatedFields(bool IsUpdate = false)
        {
            switch (IsUpdate)
            {
                case (true):
                    if (firstNameListTxt.Text != String.Empty && lastNameListTxt.Text != String.Empty && loginListTxt.Text != String.Empty && emailListTxt.Text != String.Empty)
                        return true;
                    break;
                default:
                    if (firstNameTxt.Text != String.Empty && lastNameTxt.Text != String.Empty && loginTxt.Text != String.Empty && emailTxt.Text != String.Empty)
                        return true;
                    break;
            }
            return false;

        }
        private void ClearAddUserControls()
        {
            firstNameTxt.Enabled = lastNameTxt.Enabled = loginTxt.Enabled = emailTxt.Enabled = isActiveCheckBox.Enabled = isAdminCheckBox.Enabled = addUserBtn.Enabled = false;
            firstNameTxt.Text = lastNameTxt.Text = loginTxt.Text = emailTxt.Text = String.Empty;
            isActiveCheckBox.Checked = isAdminCheckBox.Checked = false;
        }

        private void addUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addUserCheckBox.Checked)
                firstNameTxt.Enabled = lastNameTxt.Enabled = loginTxt.Enabled = emailTxt.Enabled = isActiveCheckBox.Enabled = isAdminCheckBox.Enabled = addUserBtn.Enabled = true;
            else
            {
                ClearAddUserControls();
            }
        }
        private async void addUserBtn_Click(object sender, EventArgs e)
        {
            if (ValidatedFields())
            {
                AdministrationControlHelpers helpers = new AdministrationControlHelpers();
                helpers.PassUserDetails(firstNameTxt.Text, lastNameTxt.Text, loginTxt.Text, emailTxt.Text, isActiveCheckBox.Checked, isAdminCheckBox.Checked);
                var result = await helpers.SaveUserAsync();
                if (result)
                {
                    MetroMessageBox.Show(this, "Użytkownik został dodany");
                    ClearAddUserControls();
                    FillUsers();
                }
                else
                {
                    MetroMessageBox.Show(this, "Nastąpił problem z dodaniem nowego pracownika, spróbuj ponownie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }      
        private void usersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var usr = usersListBox.SelectedItem as User;
            if (usr == null) return;

            firstNameListTxt.Text = usr.FirstName;
            lastNameListTxt.Text = usr.LastName;
            loginListTxt.Text = usr.Login;
            emailListTxt.Text = usr.Email;
            isactiveListCheckBox.Checked = usr.Active;
            isadminListCheckBox.Checked = usr.Administrator;
            resetPasswdListCheckBox.Checked = usr.ChangePassword;
            idTxt.Text = usr.UserId.ToString();
        }
        private async void updateBtn_Click(object sender, EventArgs e)
        {
            if (!ValidatedFields(true))
            {
                MetroMessageBox.Show(this, "Uzupełnij dane.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            AdministrationControlHelpers helpers = new AdministrationControlHelpers();
            helpers.PassUserDetails(firstNameListTxt.Text, 
                lastNameListTxt.Text, 
                loginListTxt.Text, 
                emailListTxt.Text, 
                isactiveListCheckBox.Checked, 
                isadminListCheckBox.Checked, 
                resetPasswdListCheckBox.Checked,
                Convert.ToInt64(idTxt.Text));

            bool result = await helpers.UpdateUserAsync();
            if (result)
            {
                FillUsers();
            }
        }

    }
}
