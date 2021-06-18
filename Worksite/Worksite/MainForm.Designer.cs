namespace Worksite
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIcons = new System.Windows.Forms.ImageList(this.components);
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.expiredServiceCountTxt = new System.Windows.Forms.Label();
            this.openServiceCountTxt = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.infoSecLineServiceTxt = new MaterialSkin.Controls.MaterialLabel();
            this.servicesTxt = new MaterialSkin.Controls.MaterialLabel();
            this.infoHeaderServiceTxt = new MaterialSkin.Controls.MaterialLabel();
            this.welcomeTxt = new MaterialSkin.Controls.MaterialLabel();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.servicesTab = new System.Windows.Forms.TabPage();
            this.devicesTab = new System.Windows.Forms.TabPage();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.admtoolsTab = new System.Windows.Forms.TabPage();
            this.addCustomerHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.findServiceHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.addServiceHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.TabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIcons
            // 
            this.menuIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIcons.ImageStream")));
            this.menuIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIcons.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            this.menuIcons.Images.SetKeyName(1, "bookmark24.png");
            this.menuIcons.Images.SetKeyName(2, "chart24.png");
            this.menuIcons.Images.SetKeyName(3, "device24.png");
            this.menuIcons.Images.SetKeyName(4, "home24.png");
            this.menuIcons.Images.SetKeyName(5, "icons8_search_24px.png");
            this.menuIcons.Images.SetKeyName(6, "icons8_search_24px_1.png");
            this.menuIcons.Images.SetKeyName(7, "minusBlack.png");
            this.menuIcons.Images.SetKeyName(8, "plus.png");
            this.menuIcons.Images.SetKeyName(9, "plusBlack.png");
            this.menuIcons.Images.SetKeyName(10, "round_backup_white_24dp.png");
            this.menuIcons.Images.SetKeyName(11, "round_http_white_24dp.png");
            this.menuIcons.Images.SetKeyName(12, "tools24.png");
            this.menuIcons.Images.SetKeyName(13, "user24.png");
            this.menuIcons.Images.SetKeyName(14, "wrench24.png");
            this.menuIcons.Images.SetKeyName(15, "search.png");
            this.menuIcons.Images.SetKeyName(16, "showMore.png");
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.homeTab);
            this.TabControl.Controls.Add(this.customersTab);
            this.TabControl.Controls.Add(this.servicesTab);
            this.TabControl.Controls.Add(this.devicesTab);
            this.TabControl.Controls.Add(this.statsTab);
            this.TabControl.Controls.Add(this.admtoolsTab);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.menuIcons;
            this.TabControl.Location = new System.Drawing.Point(4, 4);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(992, 642);
            this.TabControl.TabIndex = 0;
            this.TabControl.TabIndexChanged += new System.EventHandler(this.TabControl_TabIndexChanged);
            // 
            // homeTab
            // 
            this.homeTab.BackColor = System.Drawing.SystemColors.Control;
            this.homeTab.Controls.Add(this.expiredServiceCountTxt);
            this.homeTab.Controls.Add(this.openServiceCountTxt);
            this.homeTab.Controls.Add(this.materialDivider1);
            this.homeTab.Controls.Add(this.addCustomerHomeBtn);
            this.homeTab.Controls.Add(this.findServiceHomeBtn);
            this.homeTab.Controls.Add(this.addServiceHomeBtn);
            this.homeTab.Controls.Add(this.materialLabel3);
            this.homeTab.Controls.Add(this.infoSecLineServiceTxt);
            this.homeTab.Controls.Add(this.servicesTxt);
            this.homeTab.Controls.Add(this.infoHeaderServiceTxt);
            this.homeTab.Controls.Add(this.welcomeTxt);
            this.homeTab.ImageKey = "home24.png";
            this.homeTab.Location = new System.Drawing.Point(4, 31);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(984, 607);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // expiredServiceCountTxt
            // 
            this.expiredServiceCountTxt.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.expiredServiceCountTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expiredServiceCountTxt.Location = new System.Drawing.Point(15, 354);
            this.expiredServiceCountTxt.Name = "expiredServiceCountTxt";
            this.expiredServiceCountTxt.Size = new System.Drawing.Size(57, 24);
            this.expiredServiceCountTxt.TabIndex = 3;
            this.expiredServiceCountTxt.Text = "0000";
            this.expiredServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openServiceCountTxt
            // 
            this.openServiceCountTxt.Font = new System.Drawing.Font("Roboto", 14.25F);
            this.openServiceCountTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openServiceCountTxt.Location = new System.Drawing.Point(15, 282);
            this.openServiceCountTxt.Name = "openServiceCountTxt";
            this.openServiceCountTxt.Size = new System.Drawing.Size(57, 24);
            this.openServiceCountTxt.TabIndex = 3;
            this.openServiceCountTxt.Text = "0000";
            this.openServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(387, 0);
            this.materialDivider1.MaximumSize = new System.Drawing.Size(3, 3000);
            this.materialDivider1.MinimumSize = new System.Drawing.Size(3, 603);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(3, 603);
            this.materialDivider1.TabIndex = 5;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.ForeColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Location = new System.Drawing.Point(88, 354);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 24);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "serwisów";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoSecLineServiceTxt
            // 
            this.infoSecLineServiceTxt.AutoSize = true;
            this.infoSecLineServiceTxt.Depth = 0;
            this.infoSecLineServiceTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.infoSecLineServiceTxt.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.infoSecLineServiceTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.infoSecLineServiceTxt.Location = new System.Drawing.Point(15, 317);
            this.infoSecLineServiceTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoSecLineServiceTxt.Name = "infoSecLineServiceTxt";
            this.infoSecLineServiceTxt.Size = new System.Drawing.Size(177, 24);
            this.infoSecLineServiceTxt.TabIndex = 0;
            this.infoSecLineServiceTxt.Text = "w tym opóźnionych:";
            // 
            // servicesTxt
            // 
            this.servicesTxt.AutoSize = true;
            this.servicesTxt.Depth = 0;
            this.servicesTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.servicesTxt.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.servicesTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.servicesTxt.Location = new System.Drawing.Point(88, 282);
            this.servicesTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.servicesTxt.Name = "servicesTxt";
            this.servicesTxt.Size = new System.Drawing.Size(85, 24);
            this.servicesTxt.TabIndex = 0;
            this.servicesTxt.Text = "serwisów";
            this.servicesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoHeaderServiceTxt
            // 
            this.infoHeaderServiceTxt.AutoSize = true;
            this.infoHeaderServiceTxt.Depth = 0;
            this.infoHeaderServiceTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.infoHeaderServiceTxt.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.infoHeaderServiceTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.infoHeaderServiceTxt.Location = new System.Drawing.Point(15, 245);
            this.infoHeaderServiceTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.infoHeaderServiceTxt.Name = "infoHeaderServiceTxt";
            this.infoHeaderServiceTxt.Size = new System.Drawing.Size(192, 24);
            this.infoHeaderServiceTxt.TabIndex = 0;
            this.infoHeaderServiceTxt.Text = "Posiadasz otwartych:";
            // 
            // welcomeTxt
            // 
            this.welcomeTxt.AutoSize = true;
            this.welcomeTxt.Depth = 0;
            this.welcomeTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.welcomeTxt.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.welcomeTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.welcomeTxt.Location = new System.Drawing.Point(15, 18);
            this.welcomeTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.welcomeTxt.Name = "welcomeTxt";
            this.welcomeTxt.Size = new System.Drawing.Size(247, 24);
            this.welcomeTxt.TabIndex = 0;
            this.welcomeTxt.Text = "Witaj w programie Worksite";
            // 
            // customersTab
            // 
            this.customersTab.BackColor = System.Drawing.SystemColors.Control;
            this.customersTab.ImageKey = "user24.png";
            this.customersTab.Location = new System.Drawing.Point(4, 31);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(984, 607);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Klienci";
            // 
            // servicesTab
            // 
            this.servicesTab.ImageKey = "wrench24.png";
            this.servicesTab.Location = new System.Drawing.Point(4, 31);
            this.servicesTab.Name = "servicesTab";
            this.servicesTab.Size = new System.Drawing.Size(984, 607);
            this.servicesTab.TabIndex = 2;
            this.servicesTab.Text = "Serwisy";
            this.servicesTab.UseVisualStyleBackColor = true;
            // 
            // devicesTab
            // 
            this.devicesTab.ImageKey = "device24.png";
            this.devicesTab.Location = new System.Drawing.Point(4, 31);
            this.devicesTab.Name = "devicesTab";
            this.devicesTab.Size = new System.Drawing.Size(984, 607);
            this.devicesTab.TabIndex = 3;
            this.devicesTab.Text = "Sprzęt";
            this.devicesTab.UseVisualStyleBackColor = true;
            // 
            // statsTab
            // 
            this.statsTab.ImageKey = "chart24.png";
            this.statsTab.Location = new System.Drawing.Point(4, 31);
            this.statsTab.Name = "statsTab";
            this.statsTab.Size = new System.Drawing.Size(984, 607);
            this.statsTab.TabIndex = 4;
            this.statsTab.Text = "Statystyki";
            this.statsTab.UseVisualStyleBackColor = true;
            // 
            // admtoolsTab
            // 
            this.admtoolsTab.ImageKey = "tools24.png";
            this.admtoolsTab.Location = new System.Drawing.Point(4, 31);
            this.admtoolsTab.Name = "admtoolsTab";
            this.admtoolsTab.Size = new System.Drawing.Size(984, 607);
            this.admtoolsTab.TabIndex = 5;
            this.admtoolsTab.Text = "Administracja";
            this.admtoolsTab.UseVisualStyleBackColor = true;
            // 
            // addCustomerHomeBtn
            // 
            this.addCustomerHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addCustomerHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addCustomerHomeBtn.Depth = 0;
            this.addCustomerHomeBtn.HighEmphasis = true;
            this.addCustomerHomeBtn.Icon = global::Worksite.Properties.Resources.plus;
            this.addCustomerHomeBtn.Location = new System.Drawing.Point(193, 72);
            this.addCustomerHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addCustomerHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addCustomerHomeBtn.Name = "addCustomerHomeBtn";
            this.addCustomerHomeBtn.Size = new System.Drawing.Size(160, 36);
            this.addCustomerHomeBtn.TabIndex = 2;
            this.addCustomerHomeBtn.Text = "Dodaj klienta";
            this.addCustomerHomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCustomerHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addCustomerHomeBtn.UseAccentColor = false;
            this.addCustomerHomeBtn.UseVisualStyleBackColor = true;
            // 
            // findServiceHomeBtn
            // 
            this.findServiceHomeBtn.AutoSize = false;
            this.findServiceHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.findServiceHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.findServiceHomeBtn.Depth = 0;
            this.findServiceHomeBtn.HighEmphasis = true;
            this.findServiceHomeBtn.Icon = global::Worksite.Properties.Resources.icons8_search_24px_1;
            this.findServiceHomeBtn.Location = new System.Drawing.Point(15, 118);
            this.findServiceHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.findServiceHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.findServiceHomeBtn.Name = "findServiceHomeBtn";
            this.findServiceHomeBtn.Size = new System.Drawing.Size(338, 36);
            this.findServiceHomeBtn.TabIndex = 3;
            this.findServiceHomeBtn.Text = "Wyszukaj naprawę";
            this.findServiceHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.findServiceHomeBtn.UseAccentColor = false;
            this.findServiceHomeBtn.UseVisualStyleBackColor = true;
            // 
            // addServiceHomeBtn
            // 
            this.addServiceHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addServiceHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addServiceHomeBtn.Depth = 0;
            this.addServiceHomeBtn.HighEmphasis = true;
            this.addServiceHomeBtn.Icon = global::Worksite.Properties.Resources.plus;
            this.addServiceHomeBtn.Location = new System.Drawing.Point(15, 72);
            this.addServiceHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addServiceHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addServiceHomeBtn.Name = "addServiceHomeBtn";
            this.addServiceHomeBtn.Size = new System.Drawing.Size(170, 36);
            this.addServiceHomeBtn.TabIndex = 1;
            this.addServiceHomeBtn.Text = "Dodaj naprawę";
            this.addServiceHomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addServiceHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addServiceHomeBtn.UseAccentColor = false;
            this.addServiceHomeBtn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.TabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.DrawerUseColors = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(880, 445);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "asdasd";
            this.Text = "Worksite";
            this.TabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList menuIcons;
        private System.Windows.Forms.TabPage homeTab;
        private MaterialSkin.Controls.MaterialButton addCustomerHomeBtn;
        private MaterialSkin.Controls.MaterialButton findServiceHomeBtn;
        private MaterialSkin.Controls.MaterialButton addServiceHomeBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel infoSecLineServiceTxt;
        private MaterialSkin.Controls.MaterialLabel servicesTxt;
        private MaterialSkin.Controls.MaterialLabel infoHeaderServiceTxt;
        private MaterialSkin.Controls.MaterialLabel welcomeTxt;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.TabPage servicesTab;
        private System.Windows.Forms.TabPage devicesTab;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.TabPage admtoolsTab;
        private System.Windows.Forms.Label expiredServiceCountTxt;
        private System.Windows.Forms.Label openServiceCountTxt;
        public MaterialSkin.Controls.MaterialTabControl TabControl;
        public System.Windows.Forms.TabPage customersTab;
    }
}

