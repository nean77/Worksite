namespace Worksite.Forms
{
    partial class ChangePasswordForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.loginTxt = new MetroFramework.Controls.MetroTextBox();
            this.loginLabel = new MetroFramework.Controls.MetroLabel();
            this.passwdTxt2 = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.savePasswdBtn = new MetroFramework.Controls.MetroButton();
            this.warningLabel = new MetroFramework.Controls.MetroLabel();
            this.LastNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.LastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwdTxt1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            // 
            // 
            // 
            this.loginTxt.CustomButton.Image = null;
            this.loginTxt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.loginTxt.CustomButton.Name = "";
            this.loginTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.loginTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTxt.CustomButton.TabIndex = 1;
            this.loginTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTxt.CustomButton.UseSelectable = true;
            this.loginTxt.CustomButton.Visible = false;
            this.loginTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loginTxt.Lines = new string[0];
            this.loginTxt.Location = new System.Drawing.Point(23, 85);
            this.loginTxt.MaxLength = 32767;
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.PasswordChar = '\0';
            this.loginTxt.PromptText = "Login";
            this.loginTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxt.SelectedText = "";
            this.loginTxt.SelectionLength = 0;
            this.loginTxt.SelectionStart = 0;
            this.loginTxt.ShortcutsEnabled = true;
            this.loginTxt.Size = new System.Drawing.Size(287, 23);
            this.loginTxt.TabIndex = 1;
            this.loginTxt.UseSelectable = true;
            this.loginTxt.WaterMark = "Login";
            this.loginTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.loginTxt.TextChanged += new System.EventHandler(this.loginTxt_TextChanged);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(24, 60);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 19);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // passwdTxt2
            // 
            // 
            // 
            // 
            this.passwdTxt2.CustomButton.Image = null;
            this.passwdTxt2.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.passwdTxt2.CustomButton.Name = "";
            this.passwdTxt2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwdTxt2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwdTxt2.CustomButton.TabIndex = 1;
            this.passwdTxt2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwdTxt2.CustomButton.UseSelectable = true;
            this.passwdTxt2.CustomButton.Visible = false;
            this.passwdTxt2.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwdTxt2.Lines = new string[0];
            this.passwdTxt2.Location = new System.Drawing.Point(23, 246);
            this.passwdTxt2.MaxLength = 32767;
            this.passwdTxt2.Name = "passwdTxt2";
            this.passwdTxt2.PasswordChar = '●';
            this.passwdTxt2.PromptText = "Hasło";
            this.passwdTxt2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwdTxt2.SelectedText = "";
            this.passwdTxt2.SelectionLength = 0;
            this.passwdTxt2.SelectionStart = 0;
            this.passwdTxt2.ShortcutsEnabled = true;
            this.passwdTxt2.Size = new System.Drawing.Size(287, 23);
            this.passwdTxt2.TabIndex = 4;
            this.passwdTxt2.UseSelectable = true;
            this.passwdTxt2.UseSystemPasswordChar = true;
            this.passwdTxt2.WaterMark = "Hasło";
            this.passwdTxt2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwdTxt2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwdTxt2.TextChanged += new System.EventHandler(this.passwdTxt_TextChanged);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 221);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(44, 19);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Hasło:";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(235, 287);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 30);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // savePasswdBtn
            // 
            this.savePasswdBtn.Location = new System.Drawing.Point(154, 287);
            this.savePasswdBtn.Name = "savePasswdBtn";
            this.savePasswdBtn.Size = new System.Drawing.Size(75, 30);
            this.savePasswdBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.savePasswdBtn.TabIndex = 5;
            this.savePasswdBtn.Text = "Zapisz";
            this.savePasswdBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.savePasswdBtn.UseSelectable = true;
            this.savePasswdBtn.Click += new System.EventHandler(this.savePasswdBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.warningLabel.Location = new System.Drawing.Point(24, 289);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(58, 19);
            this.warningLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.warningLabel.TabIndex = 4;
            this.warningLabel.Text = "warning";
            this.warningLabel.UseStyleColors = true;
            this.warningLabel.Visible = false;
            // 
            // LastNameTxt
            // 
            // 
            // 
            // 
            this.LastNameTxt.CustomButton.Image = null;
            this.LastNameTxt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.LastNameTxt.CustomButton.Name = "";
            this.LastNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.LastNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LastNameTxt.CustomButton.TabIndex = 1;
            this.LastNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LastNameTxt.CustomButton.UseSelectable = true;
            this.LastNameTxt.CustomButton.Visible = false;
            this.LastNameTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LastNameTxt.Lines = new string[0];
            this.LastNameTxt.Location = new System.Drawing.Point(23, 138);
            this.LastNameTxt.MaxLength = 32767;
            this.LastNameTxt.Name = "LastNameTxt";
            this.LastNameTxt.PasswordChar = '\0';
            this.LastNameTxt.PromptText = "Nazwisko";
            this.LastNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNameTxt.SelectedText = "";
            this.LastNameTxt.SelectionLength = 0;
            this.LastNameTxt.SelectionStart = 0;
            this.LastNameTxt.ShortcutsEnabled = true;
            this.LastNameTxt.Size = new System.Drawing.Size(287, 23);
            this.LastNameTxt.TabIndex = 2;
            this.LastNameTxt.UseSelectable = true;
            this.LastNameTxt.WaterMark = "Nazwisko";
            this.LastNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LastNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.LastNameTxt.TextChanged += new System.EventHandler(this.loginTxt_TextChanged);
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(24, 113);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(66, 19);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Nazwisko:";
            // 
            // passwdTxt1
            // 
            // 
            // 
            // 
            this.passwdTxt1.CustomButton.Image = null;
            this.passwdTxt1.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.passwdTxt1.CustomButton.Name = "";
            this.passwdTxt1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwdTxt1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwdTxt1.CustomButton.TabIndex = 1;
            this.passwdTxt1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwdTxt1.CustomButton.UseSelectable = true;
            this.passwdTxt1.CustomButton.Visible = false;
            this.passwdTxt1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwdTxt1.Lines = new string[0];
            this.passwdTxt1.Location = new System.Drawing.Point(22, 194);
            this.passwdTxt1.MaxLength = 32767;
            this.passwdTxt1.Name = "passwdTxt1";
            this.passwdTxt1.PasswordChar = '●';
            this.passwdTxt1.PromptText = "Hasło";
            this.passwdTxt1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwdTxt1.SelectedText = "";
            this.passwdTxt1.SelectionLength = 0;
            this.passwdTxt1.SelectionStart = 0;
            this.passwdTxt1.ShortcutsEnabled = true;
            this.passwdTxt1.Size = new System.Drawing.Size(287, 23);
            this.passwdTxt1.TabIndex = 3;
            this.passwdTxt1.UseSelectable = true;
            this.passwdTxt1.UseSystemPasswordChar = true;
            this.passwdTxt1.WaterMark = "Hasło";
            this.passwdTxt1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwdTxt1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwdTxt1.TextChanged += new System.EventHandler(this.passwdTxt_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Hasło:";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 337);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.savePasswdBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.passwdTxt1);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwdTxt2);
            this.Controls.Add(this.LastNameTxt);
            this.Controls.Add(this.loginTxt);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(341, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(341, 337);
            this.Name = "ChangePasswordForm";
            this.Text = "Worksite - Zmiana hasła";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox loginTxt;
        private MetroFramework.Controls.MetroLabel loginLabel;
        private MetroFramework.Controls.MetroTextBox passwdTxt2;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroButton savePasswdBtn;
        private MetroFramework.Controls.MetroLabel warningLabel;
        private MetroFramework.Controls.MetroTextBox LastNameTxt;
        private MetroFramework.Controls.MetroLabel LastNameLabel;
        private MetroFramework.Controls.MetroTextBox passwdTxt1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}