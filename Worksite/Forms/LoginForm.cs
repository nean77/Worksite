using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.Exceptions;

namespace Worksite.Forms
{
    public partial class LoginForm : MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (validateLoginData())
                DialogResult = DialogResult.OK;
        }

        private bool validateLoginData()
        {
            Login login = new Login(loginTxt.Text, passwdTxt.Text);
            try
            {
                CurrentUser currentUser = CurrentUser.GetInstance();
                currentUser.SetCurUser(login.LoginUser().UserId,
                    login.LoginUser().FirstName,
                    login.LoginUser().LastName,
                    login.LoginUser().Administrator);
            }
            catch (NonRecognizedUserException)
            {
                warningLabel.Text = "Błąd logowania";
                warningLabel.Visible = true;
                return false;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Błąd", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void passwdTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateFields(e);
        }
        private void loginTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            validateFields(e);
        }
        private void validateFields(KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (!String.IsNullOrEmpty(passwdTxt.Text) || !String.IsNullOrEmpty(loginTxt.Text))
                {
                    loginBtn.PerformClick();
                }
                warningLabel.Text = "Login lub hasło nie mogą być puste";
            }
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
    }
}
