using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Forms
{
    public partial class LoginForm : MaterialForm
    {
        #region Private members
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private string login { get; set; }
        private string password { get; set; }
        #endregion

        public LoginForm()
        {
            InitializeComponent();
            setColor();            
        }

        #region Private methods
        private void setColor()
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800,
                Primary.Grey900,
                Primary.Grey500,
                Accent.Blue400,
                TextShade.WHITE);
        }

        private bool findUser()
        {
            using (WorksiteEntities context = new WorksiteEntities())
            {
                User user = context.Users.FirstOrDefault(
                    u => u.Login == login &&
                    u.Password == password);

                if(user != null && user.Active==true)
                {
                    Program.currentUser = user;
                    return true;
                }
                if (user != null && user.Active == false)
                {
                    MaterialMessageBox.Show(this, "Użytkownik nie aktywny", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    user = context.Users.FirstOrDefault(
                        u => u.Login == login);

                    if (user != null)
                    {
                        MaterialMessageBox.Show(this, "Błędne hasło", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    MaterialMessageBox.Show(this, "Użytkownik o podanych danych nie istnieje", "Błąd logowania", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            return false;
        }
        #endregion

        #region Private events
        private void passwordTxt_Enter(object sender, EventArgs e)
        {
            if(passwordTxt.Text != string.Empty)
            {
                passwordTxt.SelectAll();
            }
        }

        private void passwordTxt_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordTxt.Text != string.Empty)
            {
                passwordTxt.SelectAll();
            }
        }

        private void passwordTxt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (passwordTxt.Text != string.Empty)
            {
                passwordTxt.SelectAll();
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login = loginTxt.Text;
            password = passwordTxt.Text;

            if (findUser())
                DialogResult = DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
    }
}
