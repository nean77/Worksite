namespace Worksite.Forms
{
    partial class AddEditServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditServiceForm));
            this.saveBtn = new MetroFramework.Controls.MetroButton();
            this.serviceIdTxt = new MetroFramework.Controls.MetroTextBox();
            this.servisStatuslLabel = new MetroFramework.Controls.MetroLabel();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            this.cancelBtn = new MetroFramework.Controls.MetroButton();
            this.serviceStatusComboBox = new MetroFramework.Controls.MetroComboBox();
            this.customerLabel = new MetroFramework.Controls.MetroLabel();
            this.customerComboBox = new MetroFramework.Controls.MetroComboBox();
            this.deviceLabel = new MetroFramework.Controls.MetroLabel();
            this.deviceComboBox = new MetroFramework.Controls.MetroComboBox();
            this.addDeviceBtn = new MetroFramework.Controls.MetroButton();
            this.addCustomer = new MetroFramework.Controls.MetroButton();
            this.inventNoTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.idLabel = new MetroFramework.Controls.MetroLabel();
            this.startDateLabel = new MetroFramework.Controls.MetroLabel();
            this.startDateTime = new MetroFramework.Controls.MetroDateTime();
            this.endDateLabel = new MetroFramework.Controls.MetroLabel();
            this.endDateTime = new MetroFramework.Controls.MetroDateTime();
            this.userLabel = new MetroFramework.Controls.MetroLabel();
            this.userComboBox = new MetroFramework.Controls.MetroComboBox();
            this.descriptionTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox4 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox5 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox6 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox7 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox8 = new MetroFramework.Controls.MetroCheckBox();
            this.hoursQtyTxt = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(390, 666);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Zapisz";
            this.saveBtn.UseSelectable = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // serviceIdTxt
            // 
            // 
            // 
            // 
            this.serviceIdTxt.CustomButton.Image = null;
            this.serviceIdTxt.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.serviceIdTxt.CustomButton.Name = "";
            this.serviceIdTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serviceIdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serviceIdTxt.CustomButton.TabIndex = 1;
            this.serviceIdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serviceIdTxt.CustomButton.UseSelectable = true;
            this.serviceIdTxt.CustomButton.Visible = false;
            this.serviceIdTxt.Enabled = false;
            this.serviceIdTxt.Lines = new string[0];
            this.serviceIdTxt.Location = new System.Drawing.Point(49, 666);
            this.serviceIdTxt.MaxLength = 32767;
            this.serviceIdTxt.Name = "serviceIdTxt";
            this.serviceIdTxt.PasswordChar = '\0';
            this.serviceIdTxt.PromptText = "Id serwisu";
            this.serviceIdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serviceIdTxt.SelectedText = "";
            this.serviceIdTxt.SelectionLength = 0;
            this.serviceIdTxt.SelectionStart = 0;
            this.serviceIdTxt.ShortcutsEnabled = true;
            this.serviceIdTxt.Size = new System.Drawing.Size(101, 23);
            this.serviceIdTxt.TabIndex = 3;
            this.serviceIdTxt.UseSelectable = true;
            this.serviceIdTxt.WaterMark = "Id serwisu";
            this.serviceIdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serviceIdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // servisStatuslLabel
            // 
            this.servisStatuslLabel.AutoSize = true;
            this.servisStatuslLabel.Location = new System.Drawing.Point(23, 170);
            this.servisStatuslLabel.Name = "servisStatuslLabel";
            this.servisStatuslLabel.Size = new System.Drawing.Size(99, 19);
            this.servisStatuslLabel.TabIndex = 3;
            this.servisStatuslLabel.Text = "Status naprawy:";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(309, 666);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Wyczyść";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(471, 666);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 9;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cancelBtn.UseSelectable = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // serviceStatusComboBox
            // 
            this.serviceStatusComboBox.FormattingEnabled = true;
            this.serviceStatusComboBox.ItemHeight = 23;
            this.serviceStatusComboBox.Location = new System.Drawing.Point(122, 165);
            this.serviceStatusComboBox.Name = "serviceStatusComboBox";
            this.serviceStatusComboBox.PromptText = "Status naprawy";
            this.serviceStatusComboBox.Size = new System.Drawing.Size(214, 29);
            this.serviceStatusComboBox.TabIndex = 10;
            this.serviceStatusComboBox.UseSelectable = true;
            this.serviceStatusComboBox.SelectedIndexChanged += new System.EventHandler(this.serviceStatusComboBox_SelectedIndexChanged);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(23, 80);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(93, 19);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Wybór klienta:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.ItemHeight = 23;
            this.customerComboBox.Location = new System.Drawing.Point(122, 75);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.PromptText = "Wybierz klienta";
            this.customerComboBox.Size = new System.Drawing.Size(394, 29);
            this.customerComboBox.TabIndex = 10;
            this.customerComboBox.UseSelectable = true;
            this.customerComboBox.SelectedIndexChanged += new System.EventHandler(this.customerComboBox_SelectedIndexChanged);
            // 
            // deviceLabel
            // 
            this.deviceLabel.AutoSize = true;
            this.deviceLabel.Location = new System.Drawing.Point(23, 123);
            this.deviceLabel.Name = "deviceLabel";
            this.deviceLabel.Size = new System.Drawing.Size(98, 19);
            this.deviceLabel.TabIndex = 3;
            this.deviceLabel.Text = "Wybór sprzętu:";
            // 
            // deviceComboBox
            // 
            this.deviceComboBox.Enabled = false;
            this.deviceComboBox.FormattingEnabled = true;
            this.deviceComboBox.ItemHeight = 23;
            this.deviceComboBox.Location = new System.Drawing.Point(122, 118);
            this.deviceComboBox.Name = "deviceComboBox";
            this.deviceComboBox.PromptText = "Wybierz sprzęt";
            this.deviceComboBox.Size = new System.Drawing.Size(394, 29);
            this.deviceComboBox.TabIndex = 10;
            this.deviceComboBox.UseSelectable = true;
            this.deviceComboBox.SelectedIndexChanged += new System.EventHandler(this.deviceComboBox_SelectedIndexChanged);
            // 
            // addDeviceBtn
            // 
            this.addDeviceBtn.Location = new System.Drawing.Point(522, 121);
            this.addDeviceBtn.Name = "addDeviceBtn";
            this.addDeviceBtn.Size = new System.Drawing.Size(25, 23);
            this.addDeviceBtn.TabIndex = 7;
            this.addDeviceBtn.Text = "+";
            this.addDeviceBtn.UseSelectable = true;
            this.addDeviceBtn.Click += new System.EventHandler(this.addDeviceBtn_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(522, 78);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(25, 23);
            this.addCustomer.TabIndex = 7;
            this.addCustomer.Text = "+";
            this.addCustomer.UseSelectable = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // inventNoTxt
            // 
            // 
            // 
            // 
            this.inventNoTxt.CustomButton.Image = null;
            this.inventNoTxt.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.inventNoTxt.CustomButton.Name = "";
            this.inventNoTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.inventNoTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.inventNoTxt.CustomButton.TabIndex = 1;
            this.inventNoTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.inventNoTxt.CustomButton.UseSelectable = true;
            this.inventNoTxt.CustomButton.Visible = false;
            this.inventNoTxt.Enabled = false;
            this.inventNoTxt.Lines = new string[0];
            this.inventNoTxt.Location = new System.Drawing.Point(440, 168);
            this.inventNoTxt.MaxLength = 32767;
            this.inventNoTxt.Name = "inventNoTxt";
            this.inventNoTxt.PasswordChar = '\0';
            this.inventNoTxt.PromptText = "Nr wewn.";
            this.inventNoTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.inventNoTxt.SelectedText = "";
            this.inventNoTxt.SelectionLength = 0;
            this.inventNoTxt.SelectionStart = 0;
            this.inventNoTxt.ShortcutsEnabled = true;
            this.inventNoTxt.Size = new System.Drawing.Size(107, 23);
            this.inventNoTxt.TabIndex = 3;
            this.inventNoTxt.UseSelectable = true;
            this.inventNoTxt.WaterMark = "Nr wewn.";
            this.inventNoTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.inventNoTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(342, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Nr wewnętrzny:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(23, 668);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 19);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "Id:";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(23, 215);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(145, 19);
            this.startDateLabel.TabIndex = 3;
            this.startDateLabel.Text = "Data otwarcia naprawy:";
            // 
            // startDateTime
            // 
            this.startDateTime.Location = new System.Drawing.Point(174, 210);
            this.startDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.startDateTime.Name = "startDateTime";
            this.startDateTime.Size = new System.Drawing.Size(372, 29);
            this.startDateTime.TabIndex = 11;
            this.startDateTime.ValueChanged += new System.EventHandler(this.startDateTime_ValueChanged);
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(23, 258);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(166, 19);
            this.endDateLabel.TabIndex = 3;
            this.endDateLabel.Text = "Data zakończenia naprawy:";
            // 
            // endDateTime
            // 
            this.endDateTime.Location = new System.Drawing.Point(195, 253);
            this.endDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.endDateTime.Name = "endDateTime";
            this.endDateTime.Size = new System.Drawing.Size(351, 29);
            this.endDateTime.TabIndex = 11;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(23, 301);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(67, 19);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "Serwisant:";
            // 
            // userComboBox
            // 
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.ItemHeight = 23;
            this.userComboBox.Location = new System.Drawing.Point(97, 296);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.PromptText = "Pracownik";
            this.userComboBox.Size = new System.Drawing.Size(449, 29);
            this.userComboBox.TabIndex = 10;
            this.userComboBox.UseSelectable = true;
            // 
            // descriptionTxt
            // 
            // 
            // 
            // 
            this.descriptionTxt.CustomButton.Image = null;
            this.descriptionTxt.CustomButton.Location = new System.Drawing.Point(378, 1);
            this.descriptionTxt.CustomButton.Name = "";
            this.descriptionTxt.CustomButton.Size = new System.Drawing.Size(143, 143);
            this.descriptionTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.descriptionTxt.CustomButton.TabIndex = 1;
            this.descriptionTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.descriptionTxt.CustomButton.UseSelectable = true;
            this.descriptionTxt.CustomButton.Visible = false;
            this.descriptionTxt.Lines = new string[0];
            this.descriptionTxt.Location = new System.Drawing.Point(24, 341);
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
            this.descriptionTxt.Size = new System.Drawing.Size(522, 145);
            this.descriptionTxt.TabIndex = 12;
            this.descriptionTxt.UseSelectable = true;
            this.descriptionTxt.WaterMark = "Opis";
            this.descriptionTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.descriptionTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 502);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Wykonano:";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Enabled = false;
            this.metroCheckBox1.Location = new System.Drawing.Point(23, 531);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox1.TabIndex = 13;
            this.metroCheckBox1.Text = "metroCheckBox1";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.Enabled = false;
            this.metroCheckBox2.Location = new System.Drawing.Point(23, 552);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox2.TabIndex = 13;
            this.metroCheckBox2.Text = "metroCheckBox1";
            this.metroCheckBox2.UseSelectable = true;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.Enabled = false;
            this.metroCheckBox3.Location = new System.Drawing.Point(23, 573);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox3.TabIndex = 13;
            this.metroCheckBox3.Text = "metroCheckBox1";
            this.metroCheckBox3.UseSelectable = true;
            // 
            // metroCheckBox4
            // 
            this.metroCheckBox4.AutoSize = true;
            this.metroCheckBox4.Enabled = false;
            this.metroCheckBox4.Location = new System.Drawing.Point(159, 531);
            this.metroCheckBox4.Name = "metroCheckBox4";
            this.metroCheckBox4.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox4.TabIndex = 13;
            this.metroCheckBox4.Text = "metroCheckBox1";
            this.metroCheckBox4.UseSelectable = true;
            // 
            // metroCheckBox5
            // 
            this.metroCheckBox5.AutoSize = true;
            this.metroCheckBox5.Enabled = false;
            this.metroCheckBox5.Location = new System.Drawing.Point(159, 552);
            this.metroCheckBox5.Name = "metroCheckBox5";
            this.metroCheckBox5.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox5.TabIndex = 13;
            this.metroCheckBox5.Text = "metroCheckBox1";
            this.metroCheckBox5.UseSelectable = true;
            // 
            // metroCheckBox6
            // 
            this.metroCheckBox6.AutoSize = true;
            this.metroCheckBox6.Enabled = false;
            this.metroCheckBox6.Location = new System.Drawing.Point(159, 573);
            this.metroCheckBox6.Name = "metroCheckBox6";
            this.metroCheckBox6.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox6.TabIndex = 13;
            this.metroCheckBox6.Text = "metroCheckBox1";
            this.metroCheckBox6.UseSelectable = true;
            // 
            // metroCheckBox7
            // 
            this.metroCheckBox7.AutoSize = true;
            this.metroCheckBox7.Enabled = false;
            this.metroCheckBox7.Location = new System.Drawing.Point(292, 531);
            this.metroCheckBox7.Name = "metroCheckBox7";
            this.metroCheckBox7.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox7.TabIndex = 13;
            this.metroCheckBox7.Text = "metroCheckBox1";
            this.metroCheckBox7.UseSelectable = true;
            // 
            // metroCheckBox8
            // 
            this.metroCheckBox8.AutoSize = true;
            this.metroCheckBox8.Enabled = false;
            this.metroCheckBox8.Location = new System.Drawing.Point(292, 552);
            this.metroCheckBox8.Name = "metroCheckBox8";
            this.metroCheckBox8.Size = new System.Drawing.Size(114, 15);
            this.metroCheckBox8.TabIndex = 13;
            this.metroCheckBox8.Text = "metroCheckBox1";
            this.metroCheckBox8.UseSelectable = true;
            this.metroCheckBox8.CheckedChanged += new System.EventHandler(this.metroCheckBox8_CheckedChanged);
            // 
            // hoursQtyTxt
            // 
            // 
            // 
            // 
            this.hoursQtyTxt.CustomButton.Image = null;
            this.hoursQtyTxt.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.hoursQtyTxt.CustomButton.Name = "";
            this.hoursQtyTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.hoursQtyTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hoursQtyTxt.CustomButton.TabIndex = 1;
            this.hoursQtyTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hoursQtyTxt.CustomButton.UseSelectable = true;
            this.hoursQtyTxt.CustomButton.Visible = false;
            this.hoursQtyTxt.Enabled = false;
            this.hoursQtyTxt.Lines = new string[0];
            this.hoursQtyTxt.Location = new System.Drawing.Point(292, 568);
            this.hoursQtyTxt.MaxLength = 32767;
            this.hoursQtyTxt.Name = "hoursQtyTxt";
            this.hoursQtyTxt.PasswordChar = '\0';
            this.hoursQtyTxt.PromptText = "Ilość godzin";
            this.hoursQtyTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hoursQtyTxt.SelectedText = "";
            this.hoursQtyTxt.SelectionLength = 0;
            this.hoursQtyTxt.SelectionStart = 0;
            this.hoursQtyTxt.ShortcutsEnabled = true;
            this.hoursQtyTxt.Size = new System.Drawing.Size(114, 23);
            this.hoursQtyTxt.TabIndex = 3;
            this.hoursQtyTxt.UseSelectable = true;
            this.hoursQtyTxt.WaterMark = "Ilość godzin";
            this.hoursQtyTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hoursQtyTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.hoursQtyTxt.EnabledChanged += new System.EventHandler(this.hoursQtyTxt_EnabledChanged);
            // 
            // AddEditServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 712);
            this.Controls.Add(this.metroCheckBox6);
            this.Controls.Add(this.metroCheckBox3);
            this.Controls.Add(this.metroCheckBox8);
            this.Controls.Add(this.metroCheckBox5);
            this.Controls.Add(this.metroCheckBox2);
            this.Controls.Add(this.metroCheckBox7);
            this.Controls.Add(this.metroCheckBox4);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.descriptionTxt);
            this.Controls.Add(this.endDateTime);
            this.Controls.Add(this.startDateTime);
            this.Controls.Add(this.deviceComboBox);
            this.Controls.Add(this.customerComboBox);
            this.Controls.Add(this.userComboBox);
            this.Controls.Add(this.serviceStatusComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.deviceLabel);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.servisStatuslLabel);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.inventNoTxt);
            this.Controls.Add(this.hoursQtyTxt);
            this.Controls.Add(this.serviceIdTxt);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.addDeviceBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditServiceForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddEditServiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveBtn;
        private MetroFramework.Controls.MetroTextBox serviceIdTxt;
        private MetroFramework.Controls.MetroLabel servisStatuslLabel;
        private MetroFramework.Controls.MetroButton clearBtn;
        private MetroFramework.Controls.MetroButton cancelBtn;
        private MetroFramework.Controls.MetroComboBox serviceStatusComboBox;
        private MetroFramework.Controls.MetroLabel customerLabel;
        private MetroFramework.Controls.MetroComboBox customerComboBox;
        private MetroFramework.Controls.MetroLabel deviceLabel;
        private MetroFramework.Controls.MetroComboBox deviceComboBox;
        private MetroFramework.Controls.MetroButton addDeviceBtn;
        private MetroFramework.Controls.MetroButton addCustomer;
        private MetroFramework.Controls.MetroTextBox inventNoTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel idLabel;
        private MetroFramework.Controls.MetroLabel startDateLabel;
        private MetroFramework.Controls.MetroDateTime startDateTime;
        private MetroFramework.Controls.MetroLabel endDateLabel;
        private MetroFramework.Controls.MetroDateTime endDateTime;
        private MetroFramework.Controls.MetroLabel userLabel;
        private MetroFramework.Controls.MetroComboBox userComboBox;
        private MetroFramework.Controls.MetroTextBox descriptionTxt;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox4;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox5;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox6;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox7;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox8;
        private MetroFramework.Controls.MetroTextBox hoursQtyTxt;
    }
}