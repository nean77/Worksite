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
            fillUsers();
        }

        private async void fillUsers()
        {
            
        }

        private void addUserCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addUserCheckBox.Checked)
                firstNameTxt.Enabled = lastNameTxt.Enabled = loginTxt.Enabled = emailTxt.Enabled = isActiveCheckBox.Enabled = isAdminCheckBox.Enabled = addUserBtn.Enabled = true;
            else
            {
                firstNameTxt.Enabled = lastNameTxt.Enabled = loginTxt.Enabled = emailTxt.Enabled = isActiveCheckBox.Enabled = isAdminCheckBox.Enabled = addUserBtn.Enabled = false;
                firstNameTxt.Text = lastNameTxt.Text = loginTxt.Text = emailTxt.Text = String.Empty;
                isActiveCheckBox.Checked = isAdminCheckBox.Checked = false;
            }
        }

        private async void addUserBtn_Click(object sender, EventArgs e)
        {
            if (validatedFields())
            {
                AdministrationControlHelpers helpers = new AdministrationControlHelpers();
                helpers.PassUserDetails(firstNameTxt.Text, lastNameTxt.Text, loginTxt.Text, emailTxt.Text, isActiveCheckBox.Checked, isAdminCheckBox.Checked);
                await helpers.SaveUserAsync();
            }
        }

        private bool validatedFields()
        {
            if (firstNameTxt.Text != String.Empty && lastNameTxt.Text != String.Empty && loginTxt.Text != String.Empty && emailTxt.Text != String.Empty)
                return true;
            return false;
        }
    }
}
