namespace Worksite.Forms
{
    partial class AddEditCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditCustomerForm));
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.firstNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameTxt = new MetroFramework.Controls.MetroTextBox();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            this.companyTxt = new MetroFramework.Controls.MetroTextBox();
            this.companyNameLabel = new MetroFramework.Controls.MetroLabel();
            this.phoneTxt = new MetroFramework.Controls.MetroTextBox();
            this.emailTxt = new MetroFramework.Controls.MetroTextBox();
            this.phoneLabel = new MetroFramework.Controls.MetroLabel();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.descriptionTxt = new MetroFramework.Controls.MetroTextBox();
            this.descriptionLabel = new MetroFramework.Controls.MetroLabel();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(324, 333);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // firstNameTxt
            // 
            // 
            // 
            // 
            this.firstNameTxt.CustomButton.Image = null;
            this.firstNameTxt.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.firstNameTxt.CustomButton.Name = "";
            this.firstNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.firstNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.firstNameTxt.CustomButton.TabIndex = 1;
            this.firstNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.firstNameTxt.CustomButton.UseSelectable = true;
            this.firstNameTxt.CustomButton.Visible = false;
            this.firstNameTxt.Lines = new string[0];
            this.firstNameTxt.Location = new System.Drawing.Point(68, 83);
            this.firstNameTxt.MaxLength = 32767;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.PasswordChar = '\0';
            this.firstNameTxt.PromptText = "Imię";
            this.firstNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTxt.SelectedText = "";
            this.firstNameTxt.SelectionLength = 0;
            this.firstNameTxt.SelectionStart = 0;
            this.firstNameTxt.ShortcutsEnabled = true;
            this.firstNameTxt.Size = new System.Drawing.Size(171, 23);
            this.firstNameTxt.TabIndex = 1;
            this.firstNameTxt.UseSelectable = true;
            this.firstNameTxt.WaterMark = "Imię";
            this.firstNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.firstNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(23, 83);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(37, 19);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "Imię:";
            // 
            // lastNameTxt
            // 
            // 
            // 
            // 
            this.lastNameTxt.CustomButton.Image = null;
            this.lastNameTxt.CustomButton.Location = new System.Drawing.Point(149, 1);
            this.lastNameTxt.CustomButton.Name = "";
            this.lastNameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.lastNameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lastNameTxt.CustomButton.TabIndex = 1;
            this.lastNameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lastNameTxt.CustomButton.UseSelectable = true;
            this.lastNameTxt.CustomButton.Visible = false;
            this.lastNameTxt.Lines = new string[0];
            this.lastNameTxt.Location = new System.Drawing.Point(315, 83);
            this.lastNameTxt.MaxLength = 32767;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.PasswordChar = '\0';
            this.lastNameTxt.PromptText = "Nazwisko";
            this.lastNameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTxt.SelectedText = "";
            this.lastNameTxt.SelectionLength = 0;
            this.lastNameTxt.SelectionStart = 0;
            this.lastNameTxt.ShortcutsEnabled = true;
            this.lastNameTxt.Size = new System.Drawing.Size(171, 23);
            this.lastNameTxt.TabIndex = 2;
            this.lastNameTxt.UseSelectable = true;
            this.lastNameTxt.WaterMark = "Nazwisko";
            this.lastNameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lastNameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(243, 83);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(66, 19);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Nazwisko:";
            // 
            // companyTxt
            // 
            // 
            // 
            // 
            this.companyTxt.CustomButton.Image = null;
            this.companyTxt.CustomButton.Location = new System.Drawing.Point(389, 1);
            this.companyTxt.CustomButton.Name = "";
            this.companyTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.companyTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.companyTxt.CustomButton.TabIndex = 1;
            this.companyTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.companyTxt.CustomButton.UseSelectable = true;
            this.companyTxt.CustomButton.Visible = false;
            this.companyTxt.Lines = new string[0];
            this.companyTxt.Location = new System.Drawing.Point(75, 121);
            this.companyTxt.MaxLength = 32767;
            this.companyTxt.Name = "companyTxt";
            this.companyTxt.PasswordChar = '\0';
            this.companyTxt.PromptText = "Nazwa firmy";
            this.companyTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.companyTxt.SelectedText = "";
            this.companyTxt.SelectionLength = 0;
            this.companyTxt.SelectionStart = 0;
            this.companyTxt.ShortcutsEnabled = true;
            this.companyTxt.Size = new System.Drawing.Size(411, 23);
            this.companyTxt.TabIndex = 3;
            this.companyTxt.UseSelectable = true;
            this.companyTxt.WaterMark = "Nazwa firmy";
            this.companyTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.companyTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Location = new System.Drawing.Point(23, 121);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(46, 19);
            this.companyNameLabel.TabIndex = 3;
            this.companyNameLabel.Text = "Firma:";
            // 
            // phoneTxt
            // 
            // 
            // 
            // 
            this.phoneTxt.CustomButton.Image = null;
            this.phoneTxt.CustomButton.Location = new System.Drawing.Point(140, 1);
            this.phoneTxt.CustomButton.Name = "";
            this.phoneTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.phoneTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.phoneTxt.CustomButton.TabIndex = 1;
            this.phoneTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.phoneTxt.CustomButton.UseSelectable = true;
            this.phoneTxt.CustomButton.Visible = false;
            this.phoneTxt.Lines = new string[0];
            this.phoneTxt.Location = new System.Drawing.Point(77, 158);
            this.phoneTxt.MaxLength = 32767;
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.PasswordChar = '\0';
            this.phoneTxt.PromptText = "Numer telefonu";
            this.phoneTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.phoneTxt.SelectedText = "";
            this.phoneTxt.SelectionLength = 0;
            this.phoneTxt.SelectionStart = 0;
            this.phoneTxt.ShortcutsEnabled = true;
            this.phoneTxt.Size = new System.Drawing.Size(162, 23);
            this.phoneTxt.TabIndex = 4;
            this.phoneTxt.UseSelectable = true;
            this.phoneTxt.WaterMark = "Numer telefonu";
            this.phoneTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.phoneTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // emailTxt
            // 
            // 
            // 
            // 
            this.emailTxt.CustomButton.Image = null;
            this.emailTxt.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.emailTxt.CustomButton.Name = "";
            this.emailTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.emailTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.emailTxt.CustomButton.TabIndex = 1;
            this.emailTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.emailTxt.CustomButton.UseSelectable = true;
            this.emailTxt.CustomButton.Visible = false;
            this.emailTxt.Lines = new string[0];
            this.emailTxt.Location = new System.Drawing.Point(293, 158);
            this.emailTxt.MaxLength = 32767;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.PasswordChar = '\0';
            this.emailTxt.PromptText = "Email";
            this.emailTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTxt.SelectedText = "";
            this.emailTxt.SelectionLength = 0;
            this.emailTxt.SelectionStart = 0;
            this.emailTxt.ShortcutsEnabled = true;
            this.emailTxt.Size = new System.Drawing.Size(193, 23);
            this.emailTxt.TabIndex = 5;
            this.emailTxt.UseSelectable = true;
            this.emailTxt.WaterMark = "Email";
            this.emailTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.emailTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(23, 158);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(53, 19);
            this.phoneLabel.TabIndex = 3;
            this.phoneLabel.Text = "Telefon:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(243, 158);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 19);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "Email:";
            // 
            // descriptionTxt
            // 
            // 
            // 
            // 
            this.descriptionTxt.CustomButton.Image = null;
            this.descriptionTxt.CustomButton.Location = new System.Drawing.Point(310, 2);
            this.descriptionTxt.CustomButton.Name = "";
            this.descriptionTxt.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.descriptionTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTxt.CustomButton.TabIndex = 1;
            this.descriptionTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTxt.CustomButton.UseSelectable = true;
            this.descriptionTxt.CustomButton.Visible = false;
            this.descriptionTxt.Lines = new string[0];
            this.descriptionTxt.Location = new System.Drawing.Point(68, 194);
            this.descriptionTxt.MaxLength = 32767;
            this.descriptionTxt.Multiline = true;
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.PasswordChar = '\0';
            this.descriptionTxt.PromptText = "Opis";
            this.descriptionTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.descriptionTxt.SelectedText = "";
            this.descriptionTxt.SelectionLength = 0;
            this.descriptionTxt.SelectionStart = 0;
            this.descriptionTxt.ShortcutsEnabled = true;
            this.descriptionTxt.Size = new System.Drawing.Size(418, 110);
            this.descriptionTxt.TabIndex = 6;
            this.descriptionTxt.UseSelectable = true;
            this.descriptionTxt.WaterMark = "Opis";
            this.descriptionTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(23, 194);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(39, 19);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Opis:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(243, 333);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(405, 333);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddEditCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 403);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.companyTxt);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditCustomerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroTextBox firstNameTxt;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroTextBox lastNameTxt;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroTextBox companyTxt;
        private MetroFramework.Controls.MetroLabel companyNameLabel;
        private MetroFramework.Controls.MetroTextBox phoneTxt;
        private MetroFramework.Controls.MetroTextBox emailTxt;
        private MetroFramework.Controls.MetroLabel phoneLabel;
        private MetroFramework.Controls.MetroLabel emailLabel;
        private MetroFramework.Controls.MetroTextBox descriptionTxt;
        private MetroFramework.Controls.MetroLabel descriptionLabel;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
    }
}