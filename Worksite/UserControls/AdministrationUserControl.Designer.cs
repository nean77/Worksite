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
            // AdministrationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.isAdminCheckBox);
            this.Controls.Add(this.isActiveCheckBox);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.loginTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.addUserCheckBox);
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
    }
}
