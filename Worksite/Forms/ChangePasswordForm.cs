using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.Classes.EntityHelpers;
using Worksite.Exceptions;

namespace Worksite.Forms
{
    public partial class ChangePasswordForm : MetroForm
    {
        User _user = new User();
        WriteAdministrationEntityHelpers write = new WriteAdministrationEntityHelpers();
        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private async void savePasswdBtn_Click(object sender, EventArgs e)
        {
            if (!validateFields())
                return;
            PassNewUserPassword();
            var result = await write.UpdatePassword(_user);
            if (result)
            {
                DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                MetroMessageBox.Show(this, "Nie można zmienić hasła.", "Błąd komunikacji z bazą danych", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Abort;
        }
        private void passwdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateFields(e);
        }
        private bool validateFields(KeyPressEventArgs e = null)
        {
            if (!loginTxt.Text.Equals(_user.Login) ||
                !LastNameTxt.Text.Equals(_user.LastName))
            {
                warningLabel.Text = "Błąd";
                MetroMessageBox.Show(this, "Nie można zmienić hasła innego użytkownika", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!(passwdTxt1.Text == passwdTxt2.Text))
            {
                MetroMessageBox.Show(this, "Podane hasła muszą być identyczne", "Błąd");
                return false;
            }
            if (String.IsNullOrEmpty(loginTxt.Text) ||
                    String.IsNullOrEmpty(LastNameTxt.Text) ||
                    String.IsNullOrEmpty(passwdTxt1.Text) ||
                    String.IsNullOrEmpty(passwdTxt2.Text) ||
                    !passwdTxt1.Text.Equals(passwdTxt2.Text))
            {
                MetroMessageBox.Show(this, "Login, nazwisko lub hasło nie mogą być puste", "Błąd");
                return false;
            }
            return true;
        }
        private void passwdTxt_TextChanged(object sender, EventArgs e)
        {
            if (warningLabel.Visible)
                warningLabel.Visible = false;
        }
        private void loginTxt_TextChanged(object sender, EventArgs e)
        {
            if (warningLabel.Visible)
                warningLabel.Visible = false;
        }
        private void PassNewUserPassword()
        {
            _user.Password = write.CalculateSHA256Password(passwdTxt1.Text);
            _user.ChangePassword = false;
        }
    }
}
