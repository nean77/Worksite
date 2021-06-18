namespace Worksite.UserControls.CustomersUC
{
    partial class CustomersMainUC
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
            this.customersDGV = new System.Windows.Forms.DataGridView();
            this.CustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCardGrid = new MaterialSkin.Controls.MaterialCard();
            this.addCustomerHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.findServiceHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).BeginInit();
            this.materialCardGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersDGV
            // 
            this.customersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerId,
            this.firstName,
            this.lastName,
            this.companyName,
            this.phoneNo,
            this.email,
            this.description});
            this.customersDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDGV.Location = new System.Drawing.Point(14, 14);
            this.customersDGV.MultiSelect = false;
            this.customersDGV.Name = "customersDGV";
            this.customersDGV.ReadOnly = true;
            this.customersDGV.RowHeadersVisible = false;
            this.customersDGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customersDGV.Size = new System.Drawing.Size(933, 492);
            this.customersDGV.TabIndex = 1;
            // 
            // CustomerId
            // 
            this.CustomerId.HeaderText = "Id klienta";
            this.CustomerId.Name = "CustomerId";
            this.CustomerId.ReadOnly = true;
            // 
            // firstName
            // 
            this.firstName.HeaderText = "Imię";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Nazwisko";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // companyName
            // 
            this.companyName.HeaderText = "Nazwa firmy";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            // 
            // phoneNo
            // 
            this.phoneNo.HeaderText = "Numer telefonu";
            this.phoneNo.Name = "phoneNo";
            this.phoneNo.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // description
            // 
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Visible = false;
            // 
            // materialCardGrid
            // 
            this.materialCardGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCardGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardGrid.Controls.Add(this.customersDGV);
            this.materialCardGrid.Depth = 0;
            this.materialCardGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardGrid.Location = new System.Drawing.Point(14, 14);
            this.materialCardGrid.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardGrid.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardGrid.Name = "materialCardGrid";
            this.materialCardGrid.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardGrid.Size = new System.Drawing.Size(961, 520);
            this.materialCardGrid.TabIndex = 2;
            // 
            // addCustomerHomeBtn
            // 
            this.addCustomerHomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addCustomerHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustomerHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addCustomerHomeBtn.Depth = 0;
            this.addCustomerHomeBtn.HighEmphasis = true;
            this.addCustomerHomeBtn.Icon = global::Worksite.Properties.Resources.plus;
            this.addCustomerHomeBtn.Location = new System.Drawing.Point(615, 548);
            this.addCustomerHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCustomerHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCustomerHomeBtn.Name = "addCustomerHomeBtn";
            this.addCustomerHomeBtn.Size = new System.Drawing.Size(160, 36);
            this.addCustomerHomeBtn.TabIndex = 4;
            this.addCustomerHomeBtn.Text = "Dodaj klienta";
            this.addCustomerHomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCustomerHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addCustomerHomeBtn.UseAccentColor = false;
            this.addCustomerHomeBtn.UseVisualStyleBackColor = true;
            // 
            // findServiceHomeBtn
            // 
            this.findServiceHomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.findServiceHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findServiceHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.findServiceHomeBtn.Depth = 0;
            this.findServiceHomeBtn.HighEmphasis = true;
            this.findServiceHomeBtn.Icon = global::Worksite.Properties.Resources.icons8_search_24px_1;
            this.findServiceHomeBtn.Location = new System.Drawing.Point(786, 548);
            this.findServiceHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.findServiceHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.findServiceHomeBtn.Name = "findServiceHomeBtn";
            this.findServiceHomeBtn.Size = new System.Drawing.Size(189, 36);
            this.findServiceHomeBtn.TabIndex = 5;
            this.findServiceHomeBtn.Text = "Wyszukaj klienta";
            this.findServiceHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.findServiceHomeBtn.UseAccentColor = false;
            this.findServiceHomeBtn.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = global::Worksite.Properties.Resources.showMore;
            this.materialButton1.Location = new System.Drawing.Point(473, 548);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(131, 36);
            this.materialButton1.TabIndex = 6;
            this.materialButton1.Text = "Szczegóły";
            this.materialButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // CustomersMainUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.findServiceHomeBtn);
            this.Controls.Add(this.addCustomerHomeBtn);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.materialCardGrid);
            this.Name = "CustomersMainUC";
            this.Size = new System.Drawing.Size(989, 601);
            ((System.ComponentModel.ISupportInitialize)(this.customersDGV)).EndInit();
            this.materialCardGrid.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView customersDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private MaterialSkin.Controls.MaterialCard materialCardGrid;
        private MaterialSkin.Controls.MaterialButton addCustomerHomeBtn;
        private MaterialSkin.Controls.MaterialButton findServiceHomeBtn;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}
