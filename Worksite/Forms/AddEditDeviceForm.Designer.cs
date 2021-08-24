namespace Worksite.Forms
{
    partial class AddEditDeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditDeviceForm));
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.nameTxt = new MetroFramework.Controls.MetroTextBox();
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.inventNoTxt = new MetroFramework.Controls.MetroTextBox();
            this.inventNoLabel = new MetroFramework.Controls.MetroLabel();
            this.serialTxt = new MetroFramework.Controls.MetroTextBox();
            this.serialLabel = new MetroFramework.Controls.MetroLabel();
            this.devTypelLabel = new MetroFramework.Controls.MetroLabel();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.devTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.customerLabel = new MetroFramework.Controls.MetroLabel();
            this.customerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.addCustomerButton = new MetroFramework.Controls.MetroButton();
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
            // nameTxt
            // 
            // 
            // 
            // 
            this.nameTxt.CustomButton.Image = null;
            this.nameTxt.CustomButton.Location = new System.Drawing.Point(388, 1);
            this.nameTxt.CustomButton.Name = "";
            this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTxt.CustomButton.TabIndex = 1;
            this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTxt.CustomButton.UseSelectable = true;
            this.nameTxt.CustomButton.Visible = false;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(76, 83);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.PromptText = "Nazwa sprzętu";
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(410, 23);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.UseSelectable = true;
            this.nameTxt.WaterMark = "Nazwa sprzętu";
            this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(23, 83);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 19);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Nazwa:";
            // 
            // inventNoTxt
            // 
            // 
            // 
            // 
            this.inventNoTxt.CustomButton.Image = null;
            this.inventNoTxt.CustomButton.Location = new System.Drawing.Point(90, 1);
            this.inventNoTxt.CustomButton.Name = "";
            this.inventNoTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inventNoTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inventNoTxt.CustomButton.TabIndex = 1;
            this.inventNoTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inventNoTxt.CustomButton.UseSelectable = true;
            this.inventNoTxt.CustomButton.Visible = false;
            this.inventNoTxt.Lines = new string[0];
            this.inventNoTxt.Location = new System.Drawing.Point(127, 121);
            this.inventNoTxt.MaxLength = 32767;
            this.inventNoTxt.Name = "inventNoTxt";
            this.inventNoTxt.PasswordChar = '\0';
            this.inventNoTxt.PromptText = "Nr wewn.";
            this.inventNoTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inventNoTxt.SelectedText = "";
            this.inventNoTxt.SelectionLength = 0;
            this.inventNoTxt.SelectionStart = 0;
            this.inventNoTxt.ShortcutsEnabled = true;
            this.inventNoTxt.Size = new System.Drawing.Size(112, 23);
            this.inventNoTxt.TabIndex = 3;
            this.inventNoTxt.UseSelectable = true;
            this.inventNoTxt.WaterMark = "Nr wewn.";
            this.inventNoTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inventNoTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // inventNoLabel
            // 
            this.inventNoLabel.AutoSize = true;
            this.inventNoLabel.Location = new System.Drawing.Point(23, 121);
            this.inventNoLabel.Name = "inventNoLabel";
            this.inventNoLabel.Size = new System.Drawing.Size(98, 19);
            this.inventNoLabel.TabIndex = 3;
            this.inventNoLabel.Text = "Nr wewnętrzny:";
            // 
            // serialTxt
            // 
            // 
            // 
            // 
            this.serialTxt.CustomButton.Image = null;
            this.serialTxt.CustomButton.Location = new System.Drawing.Point(364, 1);
            this.serialTxt.CustomButton.Name = "";
            this.serialTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serialTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serialTxt.CustomButton.TabIndex = 1;
            this.serialTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serialTxt.CustomButton.UseSelectable = true;
            this.serialTxt.CustomButton.Visible = false;
            this.serialTxt.Lines = new string[0];
            this.serialTxt.Location = new System.Drawing.Point(100, 158);
            this.serialTxt.MaxLength = 32767;
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.PasswordChar = '\0';
            this.serialTxt.PromptText = "Numer seryjny";
            this.serialTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serialTxt.SelectedText = "";
            this.serialTxt.SelectionLength = 0;
            this.serialTxt.SelectionStart = 0;
            this.serialTxt.ShortcutsEnabled = true;
            this.serialTxt.Size = new System.Drawing.Size(386, 23);
            this.serialTxt.TabIndex = 4;
            this.serialTxt.UseSelectable = true;
            this.serialTxt.WaterMark = "Numer seryjny";
            this.serialTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serialTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(23, 158);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(71, 19);
            this.serialLabel.TabIndex = 3;
            this.serialLabel.Text = "Nr seryjny:";
            // 
            // devTypelLabel
            // 
            this.devTypelLabel.AutoSize = true;
            this.devTypelLabel.Location = new System.Drawing.Point(243, 121);
            this.devTypelLabel.Name = "devTypelLabel";
            this.devTypelLabel.Size = new System.Drawing.Size(32, 19);
            this.devTypelLabel.TabIndex = 3;
            this.devTypelLabel.Text = "Typ:";
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
            // devTypeComboBox
            // 
            this.devTypeComboBox.FormattingEnabled = true;
            this.devTypeComboBox.ItemHeight = 23;
            this.devTypeComboBox.Location = new System.Drawing.Point(281, 118);
            this.devTypeComboBox.Name = "devTypeComboBox";
            this.devTypeComboBox.PromptText = "Typ sprzętu";
            this.devTypeComboBox.Size = new System.Drawing.Size(205, 29);
            this.devTypeComboBox.TabIndex = 10;
            this.devTypeComboBox.UseSelectable = true;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(23, 200);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(93, 19);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Wybór klienta:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.ItemHeight = 23;
            this.customerComboBox.Location = new System.Drawing.Point(122, 195);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.PromptText = "Wybierz klienta";
            this.customerComboBox.Size = new System.Drawing.Size(364, 29);
            this.customerComboBox.TabIndex = 10;
            this.customerComboBox.UseSelectable = true;
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(338, 241);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(148, 23);
            this.addCustomerButton.TabIndex = 7;
            this.addCustomerButton.Text = "Nowy klient";
            this.addCustomerButton.UseSelectable = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // AddEditDeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 403);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.devTypeComboBox);
            this.Controls.Add(this.devTypelLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.inventNoLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.inventNoTxt);
            this.Controls.Add(this.serialTxt);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditDeviceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditCustomerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroTextBox nameTxt;
        private MetroFramework.Controls.MetroLabel nameLabel;
        private MetroFramework.Controls.MetroTextBox inventNoTxt;
        private MetroFramework.Controls.MetroLabel inventNoLabel;
        private MetroFramework.Controls.MetroTextBox serialTxt;
        private MetroFramework.Controls.MetroLabel serialLabel;
        private MetroFramework.Controls.MetroLabel devTypelLabel;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroComboBox devTypeComboBox;
        private MetroFramework.Controls.MetroLabel customerLabel;
        private MetroFramework.Controls.MetroComboBox customerComboBox;
        private MetroFramework.Controls.MetroButton addCustomerButton;
    }
}