namespace Worksite.UserControls
{
    partial class AdministrationUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.administrationLabel = new MetroFramework.Controls.MetroLabel();
            this.addUserBtn = new MetroFramework.Controls.MetroButton();
            this.addUserCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.firstNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.lastNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.loginTxt = new MetroFramework.Controls.MetroTextBox();
            this.emailTxt = new MetroFramework.Controls.MetroTextBox();
            this.isActiveCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.isAdminCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.firstNameListTxt = new MetroFramework.Controls.MetroTextBox();
            this.lastNameListTxt = new MetroFramework.Controls.MetroTextBox();
            this.loginListTxt = new MetroFramework.Controls.MetroTextBox();
            this.emailListTxt = new MetroFramework.Controls.MetroTextBox();
            this.isactiveListCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.isadminListCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.resetPasswdListCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.usersListBox = new System.Windows.Forms.ListBox();
            this.idTxt = new MetroFramework.Controls.MetroTextBox();
            this.userListLabel = new MetroFramework.Controls.MetroLabel();
            this.idLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // administrationLabel
            // 
            this.administrationLabel.AutoSize = true;
            this.administrationLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.administrationLabel.Location = new System.Drawing.Point(16, 24);
            this.administrationLabel.Name = "administrationLabel";
            this.administrationLabel.Size = new System.Drawing.Size(101, 19);
            this.administrationLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.administrationLabel.TabIndex = 1;
            this.administrationLabel.Text = "Administracja";
            this.administrationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.administrationLabel.UseStyleColors = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserBtn.Enabled = false;
            this.addUserBtn.Location = new System.Drawing.Point(748, 93);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(107, 23);
            this.addUserBtn.TabIndex = 8;
            this.addUserBtn.Text = "Dodaj";
            this.addUserBtn.UseSelectable = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // addUserCheckBox
            // 
            this.addUserCheckBox.AutoSize = true;
            this.addUserCheckBox.Location = new System.Drawing.Point(16, 71);
            this.addUserCheckBox.Name = "addUserCheckBox";
            this.addUserCheckBox.Size = new System.Drawing.Size(118, 15);
            this.addUserCheckBox.TabIndex = 1;
            this.addUserCheckBox.Text = "Dodaj pracownika";
            this.addUserCheckBox.UseSelectable = true;
            this.addUserCheckBox.CheckedChanged += new System.EventHandler(this.addUserCheckBox_CheckedChanged);
            // 
            // firstNameTxt
            // 
            // 
            // 
            // 
            this.firstNameTxt.CustomButton.Image = null;
            this.firstNameTxt.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.firstNameTxt.CustomButton.Name = "";
            this.firstNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstNameTxt.CustomButton.TabIndex = 1;
            this.firstNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstNameTxt.CustomButton.UseSelectable = true;
            this.firstNameTxt.CustomButton.Visible = false;
            this.firstNameTxt.Enabled = false;
            this.firstNameTxt.Lines = new string[0];
            this.firstNameTxt.Location = new System.Drawing.Point(16, 93);
            this.firstNameTxt.MaxLength = 32767;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PasswordChar = '\0';
            this.firstNameTxt.PromptText = "Imię";
            this.firstNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTxt.SelectedText = "";
            this.firstNameTxt.SelectionLength = 0;
            this.firstNameTxt.SelectionStart = 0;
            this.firstNameTxt.ShortcutsEnabled = true;
            this.firstNameTxt.Size = new System.Drawing.Size(101, 23);
            this.firstNameTxt.TabIndex = 2;
            this.firstNameTxt.UseSelectable = true;
            this.firstNameTxt.WaterMark = "Imię";
            this.firstNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastNameTxt
            // 
            // 
            // 
            // 
            this.lastNameTxt.CustomButton.Image = null;
            this.lastNameTxt.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.lastNameTxt.CustomButton.Name = "";
            this.lastNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastNameTxt.CustomButton.TabIndex = 1;
            this.lastNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastNameTxt.CustomButton.UseSelectable = true;
            this.lastNameTxt.CustomButton.Visible = false;
            this.lastNameTxt.Enabled = false;
            this.lastNameTxt.Lines = new string[0];
            this.lastNameTxt.Location = new System.Drawing.Point(123, 93);
            this.lastNameTxt.MaxLength = 32767;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PasswordChar = '\0';
            this.lastNameTxt.PromptText = "Nazwisko";
            this.lastNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTxt.SelectedText = "";
            this.lastNameTxt.SelectionLength = 0;
            this.lastNameTxt.SelectionStart = 0;
            this.lastNameTxt.ShortcutsEnabled = true;
            this.lastNameTxt.Size = new System.Drawing.Size(134, 23);
            this.lastNameTxt.TabIndex = 3;
            this.lastNameTxt.UseSelectable = true;
            this.lastNameTxt.WaterMark = "Nazwisko";
            this.lastNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginTxt
            // 
            // 
            // 
            // 
            this.loginTxt.CustomButton.Image = null;
            this.loginTxt.CustomButton.Location = new System.Drawing.Point(67, 1);
            this.loginTxt.CustomButton.Name = "";
            this.loginTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTxt.CustomButton.TabIndex = 1;
            this.loginTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTxt.CustomButton.UseSelectable = true;
            this.loginTxt.CustomButton.Visible = false;
            this.loginTxt.Enabled = false;
            this.loginTxt.Lines = new string[0];
            this.loginTxt.Location = new System.Drawing.Point(263, 93);
            this.loginTxt.MaxLength = 32767;
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.PasswordChar = '\0';
            this.loginTxt.PromptText = "Login";
            this.loginTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxt.SelectedText = "";
            this.loginTxt.SelectionLength = 0;
            this.loginTxt.SelectionStart = 0;
            this.loginTxt.ShortcutsEnabled = true;
            this.loginTxt.Size = new System.Drawing.Size(89, 23);
            this.loginTxt.TabIndex = 4;
            this.loginTxt.UseSelectable = true;
            this.loginTxt.WaterMark = "Login";
            this.loginTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTxt
            // 
            // 
            // 
            // 
            this.emailTxt.CustomButton.Image = null;
            this.emailTxt.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.emailTxt.CustomButton.Name = "";
            this.emailTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxt.CustomButton.TabIndex = 1;
            this.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxt.CustomButton.UseSelectable = true;
            this.emailTxt.CustomButton.Visible = false;
            this.emailTxt.Enabled = false;
            this.emailTxt.Lines = new string[0];
            this.emailTxt.Location = new System.Drawing.Point(358, 93);
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PromptText = "Email";
            this.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.ShortcutsEnabled = true;
            this.emailTxt.Size = new System.Drawing.Size(207, 23);
            this.emailTxt.TabIndex = 5;
            this.emailTxt.UseSelectable = true;
            this.emailTxt.WaterMark = "Email";
            this.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // isActiveCheckBox
            // 
            this.isActiveCheckBox.AutoSize = true;
            this.isActiveCheckBox.Enabled = false;
            this.isActiveCheckBox.Location = new System.Drawing.Point(571, 97);
            this.isActiveCheckBox.Name = "isActiveCheckBox";
            this.isActiveCheckBox.Size = new System.Drawing.Size(69, 15);
            this.isActiveCheckBox.TabIndex = 6;
            this.isActiveCheckBox.Text = "Aktywny";
            this.isActiveCheckBox.UseSelectable = true;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.AutoSize = true;
            this.isAdminCheckBox.Enabled = false;
            this.isAdminCheckBox.Location = new System.Drawing.Point(646, 97);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(96, 15);
            this.isAdminCheckBox.TabIndex = 7;
            this.isAdminCheckBox.Text = "Administrator";
            this.isAdminCheckBox.UseSelectable = true;
            // 
            // firstNameListTxt
            // 
            // 
            // 
            // 
            this.firstNameListTxt.CustomButton.Image = null;
            this.firstNameListTxt.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.firstNameListTxt.CustomButton.Name = "";
            this.firstNameListTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstNameListTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstNameListTxt.CustomButton.TabIndex = 1;
            this.firstNameListTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstNameListTxt.CustomButton.UseSelectable = true;
            this.firstNameListTxt.CustomButton.Visible = false;
            this.firstNameListTxt.Lines = new string[0];
            this.firstNameListTxt.Location = new System.Drawing.Point(241, 182);
            this.firstNameListTxt.MaxLength = 32767;
            this.firstNameListTxt.Name = "firstNameListTxt";
            this.firstNameListTxt.PasswordChar = '\0';
            this.firstNameListTxt.PromptText = "Imię";
            this.firstNameListTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameListTxt.SelectedText = "";
            this.firstNameListTxt.SelectionLength = 0;
            this.firstNameListTxt.SelectionStart = 0;
            this.firstNameListTxt.ShortcutsEnabled = true;
            this.firstNameListTxt.Size = new System.Drawing.Size(153, 23);
            this.firstNameListTxt.TabIndex = 2;
            this.firstNameListTxt.UseSelectable = true;
            this.firstNameListTxt.WaterMark = "Imię";
            this.firstNameListTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstNameListTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastNameListTxt
            // 
            // 
            // 
            // 
            this.lastNameListTxt.CustomButton.Image = null;
            this.lastNameListTxt.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.lastNameListTxt.CustomButton.Name = "";
            this.lastNameListTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastNameListTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastNameListTxt.CustomButton.TabIndex = 1;
            this.lastNameListTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastNameListTxt.CustomButton.UseSelectable = true;
            this.lastNameListTxt.CustomButton.Visible = false;
            this.lastNameListTxt.Lines = new string[0];
            this.lastNameListTxt.Location = new System.Drawing.Point(241, 211);
            this.lastNameListTxt.MaxLength = 32767;
            this.lastNameListTxt.Name = "lastNameListTxt";
            this.lastNameListTxt.PasswordChar = '\0';
            this.lastNameListTxt.PromptText = "Nazwisko";
            this.lastNameListTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameListTxt.SelectedText = "";
            this.lastNameListTxt.SelectionLength = 0;
            this.lastNameListTxt.SelectionStart = 0;
            this.lastNameListTxt.ShortcutsEnabled = true;
            this.lastNameListTxt.Size = new System.Drawing.Size(153, 23);
            this.lastNameListTxt.TabIndex = 3;
            this.lastNameListTxt.UseSelectable = true;
            this.lastNameListTxt.WaterMark = "Nazwisko";
            this.lastNameListTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastNameListTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // loginListTxt
            // 
            // 
            // 
            // 
            this.loginListTxt.CustomButton.Image = null;
            this.loginListTxt.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.loginListTxt.CustomButton.Name = "";
            this.loginListTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginListTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginListTxt.CustomButton.TabIndex = 1;
            this.loginListTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginListTxt.CustomButton.UseSelectable = true;
            this.loginListTxt.CustomButton.Visible = false;
            this.loginListTxt.Lines = new string[0];
            this.loginListTxt.Location = new System.Drawing.Point(241, 240);
            this.loginListTxt.MaxLength = 32767;
            this.loginListTxt.Name = "loginListTxt";
            this.loginListTxt.PasswordChar = '\0';
            this.loginListTxt.PromptText = "Login";
            this.loginListTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginListTxt.SelectedText = "";
            this.loginListTxt.SelectionLength = 0;
            this.loginListTxt.SelectionStart = 0;
            this.loginListTxt.ShortcutsEnabled = true;
            this.loginListTxt.Size = new System.Drawing.Size(153, 23);
            this.loginListTxt.TabIndex = 4;
            this.loginListTxt.UseSelectable = true;
            this.loginListTxt.WaterMark = "Login";
            this.loginListTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginListTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailListTxt
            // 
            // 
            // 
            // 
            this.emailListTxt.CustomButton.Image = null;
            this.emailListTxt.CustomButton.Location = new System.Drawing.Point(131, 1);
            this.emailListTxt.CustomButton.Name = "";
            this.emailListTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailListTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailListTxt.CustomButton.TabIndex = 1;
            this.emailListTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailListTxt.CustomButton.UseSelectable = true;
            this.emailListTxt.CustomButton.Visible = false;
            this.emailListTxt.Lines = new string[0];
            this.emailListTxt.Location = new System.Drawing.Point(241, 269);
            this.emailListTxt.MaxLength = 32767;
            this.emailListTxt.Name = "emailListTxt";
            this.emailListTxt.PasswordChar = '\0';
            this.emailListTxt.PromptText = "Email";
            this.emailListTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailListTxt.SelectedText = "";
            this.emailListTxt.SelectionLength = 0;
            this.emailListTxt.SelectionStart = 0;
            this.emailListTxt.ShortcutsEnabled = true;
            this.emailListTxt.Size = new System.Drawing.Size(153, 23);
            this.emailListTxt.TabIndex = 5;
            this.emailListTxt.UseSelectable = true;
            this.emailListTxt.WaterMark = "Email";
            this.emailListTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailListTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // isactiveListCheckBox
            // 
            this.isactiveListCheckBox.AutoSize = true;
            this.isactiveListCheckBox.Location = new System.Drawing.Point(425, 182);
            this.isactiveListCheckBox.Name = "isactiveListCheckBox";
            this.isactiveListCheckBox.Size = new System.Drawing.Size(69, 15);
            this.isactiveListCheckBox.TabIndex = 6;
            this.isactiveListCheckBox.Text = "Aktywny";
            this.isactiveListCheckBox.UseSelectable = true;
            // 
            // isadminListCheckBox
            // 
            this.isadminListCheckBox.AutoSize = true;
            this.isadminListCheckBox.Location = new System.Drawing.Point(425, 211);
            this.isadminListCheckBox.Name = "isadminListCheckBox";
            this.isadminListCheckBox.Size = new System.Drawing.Size(96, 15);
            this.isadminListCheckBox.TabIndex = 7;
            this.isadminListCheckBox.Text = "Administrator";
            this.isadminListCheckBox.UseSelectable = true;
            // 
            // resetPasswdListCheckBox
            // 
            this.resetPasswdListCheckBox.AutoSize = true;
            this.resetPasswdListCheckBox.Location = new System.Drawing.Point(425, 240);
            this.resetPasswdListCheckBox.Name = "resetPasswdListCheckBox";
            this.resetPasswdListCheckBox.Size = new System.Drawing.Size(96, 15);
            this.resetPasswdListCheckBox.TabIndex = 7;
            this.resetPasswdListCheckBox.Text = "Zresetuj hasło";
            this.resetPasswdListCheckBox.UseSelectable = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.updateBtn.Location = new System.Drawing.Point(241, 312);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(280, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Aktualizuj";
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // usersListBox
            // 
            this.usersListBox.FormattingEnabled = true;
            this.usersListBox.ItemHeight = 17;
            this.usersListBox.Location = new System.Drawing.Point(16, 182);
            this.usersListBox.Name = "usersListBox";
            this.usersListBox.Size = new System.Drawing.Size(207, 259);
            this.usersListBox.TabIndex = 11;
            this.usersListBox.SelectedIndexChanged += new System.EventHandler(this.usersListBox_SelectedIndexChanged);
            // 
            // idTxt
            // 
            // 
            // 
            // 
            this.idTxt.CustomButton.Image = null;
            this.idTxt.CustomButton.Location = new System.Drawing.Point(56, 1);
            this.idTxt.CustomButton.Name = "";
            this.idTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idTxt.CustomButton.TabIndex = 1;
            this.idTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idTxt.CustomButton.UseSelectable = true;
            this.idTxt.CustomButton.Visible = false;
            this.idTxt.Enabled = false;
            this.idTxt.Lines = new string[0];
            this.idTxt.Location = new System.Drawing.Point(451, 268);
            this.idTxt.MaxLength = 32767;
            this.idTxt.Name = "idTxt";
            this.idTxt.PasswordChar = '\0';
            this.idTxt.PromptText = "Id";
            this.idTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idTxt.SelectedText = "";
            this.idTxt.SelectionLength = 0;
            this.idTxt.SelectionStart = 0;
            this.idTxt.ShortcutsEnabled = true;
            this.idTxt.Size = new System.Drawing.Size(78, 23);
            this.idTxt.TabIndex = 5;
            this.idTxt.UseSelectable = true;
            this.idTxt.WaterMark = "Id";
            this.idTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // userListLabel
            // 
            this.userListLabel.AutoSize = true;
            this.userListLabel.Location = new System.Drawing.Point(16, 157);
            this.userListLabel.Name = "userListLabel";
            this.userListLabel.Size = new System.Drawing.Size(114, 19);
            this.userListLabel.TabIndex = 12;
            this.userListLabel.Text = "Lista pracowników";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(425, 270);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(20, 19);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "Id";
            // 
            // AdministrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.userListLabel);
            this.Controls.Add(this.usersListBox);
            this.Controls.Add(this.resetPasswdListCheckBox);
            this.Controls.Add(this.isadminListCheckBox);
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(this.isactiveListCheckBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.emailListTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.loginListTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.lastNameListTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameListTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.addUserCheckBox);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.administrationLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrationUserControl";
            this.Size = new System.Drawing.Size(869, 588);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel administrationLabel;
        private MetroFramework.Controls.MetroButton addUserBtn;
        private MetroFramework.Controls.MetroCheckBox addUserCheckBox;
        private MetroFramework.Controls.MetroTextBox firstNameTxt;
        private MetroFramework.Controls.MetroTextBox lastNameTxt;
        private MetroFramework.Controls.MetroTextBox loginTxt;
        private MetroFramework.Controls.MetroTextBox emailTxt;
        private MetroFramework.Controls.MetroCheckBox isActiveCheckBox;
        private MetroFramework.Controls.MetroCheckBox isAdminCheckBox;
        private MetroFramework.Controls.MetroTextBox firstNameListTxt;
        private MetroFramework.Controls.MetroTextBox lastNameListTxt;
        private MetroFramework.Controls.MetroTextBox loginListTxt;
        private MetroFramework.Controls.MetroTextBox emailListTxt;
        private MetroFramework.Controls.MetroCheckBox isactiveListCheckBox;
        private MetroFramework.Controls.MetroCheckBox isadminListCheckBox;
        private MetroFramework.Controls.MetroCheckBox resetPasswdListCheckBox;
        private MetroFramework.Controls.MetroButton updateBtn;
        private System.Windows.Forms.ListBox usersListBox;
        private MetroFramework.Controls.MetroTextBox idTxt;
        private MetroFramework.Controls.MetroLabel userListLabel;
        private MetroFramework.Controls.MetroLabel idLabel;
    }
}
