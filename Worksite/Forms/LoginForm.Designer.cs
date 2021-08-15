namespace Worksite.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.headerLabel = new MetroFramework.Controls.MetroLabel();
            this.loginTxt = new MetroFramework.Controls.MetroTextBox();
            this.loginLabel = new MetroFramework.Controls.MetroLabel();
            this.passwdTxt = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.loginBtn = new MetroFramework.Controls.MetroButton();
            this.warningLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.headerLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.headerLabel.Location = new System.Drawing.Point(23, 79);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(287, 25);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Zaloguj się do aplikacji Worksite";
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
            this.loginTxt.Lines = new string[] {
        "nean"};
            this.loginTxt.Location = new System.Drawing.Point(23, 143);
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
            this.loginTxt.Text = "nean";
            this.loginTxt.UseSelectable = true;
            this.loginTxt.WaterMark = "Login";
            this.loginTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.loginTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.loginTxt.TextChanged += new System.EventHandler(this.loginTxt_TextChanged);
            this.loginTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginTxt_KeyPress);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(24, 118);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(44, 19);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Login:";
            // 
            // passwdTxt
            // 
            // 
            // 
            // 
            this.passwdTxt.CustomButton.Image = null;
            this.passwdTxt.CustomButton.Location = new System.Drawing.Point(265, 1);
            this.passwdTxt.CustomButton.Name = "";
            this.passwdTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passwdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwdTxt.CustomButton.TabIndex = 1;
            this.passwdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwdTxt.CustomButton.UseSelectable = true;
            this.passwdTxt.CustomButton.Visible = false;
            this.passwdTxt.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.passwdTxt.Lines = new string[] {
        "nean"};
            this.passwdTxt.Location = new System.Drawing.Point(23, 212);
            this.passwdTxt.MaxLength = 32767;
            this.passwdTxt.Name = "passwdTxt";
            this.passwdTxt.PasswordChar = '●';
            this.passwdTxt.PromptText = "Hasło";
            this.passwdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwdTxt.SelectedText = "";
            this.passwdTxt.SelectionLength = 0;
            this.passwdTxt.SelectionStart = 0;
            this.passwdTxt.ShortcutsEnabled = true;
            this.passwdTxt.Size = new System.Drawing.Size(287, 23);
            this.passwdTxt.TabIndex = 2;
            this.passwdTxt.Text = "nean";
            this.passwdTxt.UseSelectable = true;
            this.passwdTxt.UseSystemPasswordChar = true;
            this.passwdTxt.WaterMark = "Hasło";
            this.passwdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwdTxt.TextChanged += new System.EventHandler(this.passwdTxt_TextChanged);
            this.passwdTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwdTxt_KeyPress);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(24, 187);
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
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(154, 287);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 30);
            this.loginBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "Zaloguj";
            this.loginBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginBtn.UseSelectable = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.warningLabel.Location = new System.Drawing.Point(24, 255);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(58, 19);
            this.warningLabel.Style = MetroFramework.MetroColorStyle.Red;
            this.warningLabel.TabIndex = 4;
            this.warningLabel.Text = "warning";
            this.warningLabel.UseStyleColors = true;
            this.warningLabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 337);
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.passwdTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.headerLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(341, 337);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(341, 337);
            this.Name = "LoginForm";
            this.Text = "Worksite - logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel headerLabel;
        private MetroFramework.Controls.MetroTextBox loginTxt;
        private MetroFramework.Controls.MetroLabel loginLabel;
        private MetroFramework.Controls.MetroTextBox passwdTxt;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroButton loginBtn;
        private MetroFramework.Controls.MetroLabel warningLabel;
    }
}