
namespace Worksite
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuIcon = new System.Windows.Forms.ImageList(this.components);
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.notePanel1 = new MaterialSkin.Controls.MaterialExpansionPanel();
            this.expiredServiceCountTxt = new System.Windows.Forms.Label();
            this.openServiceCountTxt = new System.Windows.Forms.Label();
            this.addNoteHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.findServiceHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.addCustomerHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.addServiceHomeBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.servicesTxt = new MaterialSkin.Controls.MaterialLabel();
            this.infoSecLineServiceTxt = new MaterialSkin.Controls.MaterialLabel();
            this.infoHeaderServiceTxt = new MaterialSkin.Controls.MaterialLabel();
            this.welcomeTxt = new MaterialSkin.Controls.MaterialLabel();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.servicesTab = new System.Windows.Forms.TabPage();
            this.devicesTab = new System.Windows.Forms.TabPage();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.admtoolsTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIcon
            // 
            this.menuIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.menuIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIcon.ImageStream")));
            this.menuIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIcon.Images.SetKeyName(0, "baseline_fingerprint_black_24dp.png");
            this.menuIcon.Images.SetKeyName(1, "bookmark24.png");
            this.menuIcon.Images.SetKeyName(2, "chart24.png");
            this.menuIcon.Images.SetKeyName(3, "device24.png");
            this.menuIcon.Images.SetKeyName(4, "home24.png");
            this.menuIcon.Images.SetKeyName(5, "minusBlack.png");
            this.menuIcon.Images.SetKeyName(6, "plus.png");
            this.menuIcon.Images.SetKeyName(7, "plusBlack.png");
            this.menuIcon.Images.SetKeyName(8, "round_backup_white_24dp.png");
            this.menuIcon.Images.SetKeyName(9, "round_http_white_24dp.png");
            this.menuIcon.Images.SetKeyName(10, "tools24.png");
            this.menuIcon.Images.SetKeyName(11, "user24.png");
            this.menuIcon.Images.SetKeyName(12, "wrench24.png");
            this.menuIcon.Images.SetKeyName(13, "icons8_search_24px.png");
            this.menuIcon.Images.SetKeyName(14, "icons8_search_24px_1.png");
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
            this.TabControl.ImageList = this.menuIcon;
            this.TabControl.Location = new System.Drawing.Point(3, 3);
            this.TabControl.MinimumSize = new System.Drawing.Size(880, 445);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(994, 644);
            this.TabControl.TabIndex = 5;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.materialCard2);
            this.homeTab.Controls.Add(this.materialCard1);
            this.homeTab.Controls.Add(this.materialDivider1);
            this.homeTab.Controls.Add(this.notePanel1);
            this.homeTab.Controls.Add(this.expiredServiceCountTxt);
            this.homeTab.Controls.Add(this.openServiceCountTxt);
            this.homeTab.Controls.Add(this.addNoteHomeBtn);
            this.homeTab.Controls.Add(this.findServiceHomeBtn);
            this.homeTab.Controls.Add(this.addCustomerHomeBtn);
            this.homeTab.Controls.Add(this.addServiceHomeBtn);
            this.homeTab.Controls.Add(this.materialLabel3);
            this.homeTab.Controls.Add(this.servicesTxt);
            this.homeTab.Controls.Add(this.infoSecLineServiceTxt);
            this.homeTab.Controls.Add(this.infoHeaderServiceTxt);
            this.homeTab.Controls.Add(this.welcomeTxt);
            this.homeTab.ImageKey = "home24.png";
            this.homeTab.Location = new System.Drawing.Point(4, 31);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(986, 609);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // materialCard2
            // 
            this.materialCard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(587, 250);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(376, 91);
            this.materialCard2.TabIndex = 6;
            // 
            // materialCard1
            // 
            this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(587, 151);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(376, 91);
            this.materialCard1.TabIndex = 6;
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
            // notePanel1
            // 
            this.notePanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.notePanel1.Collapse = true;
            this.notePanel1.Depth = 0;
            this.notePanel1.ExpandHeight = 265;
            this.notePanel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.notePanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.notePanel1.Location = new System.Drawing.Point(587, 89);
            this.notePanel1.Margin = new System.Windows.Forms.Padding(16, 1, 16, 0);
            this.notePanel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.notePanel1.Name = "notePanel1";
            this.notePanel1.Padding = new System.Windows.Forms.Padding(24, 64, 24, 16);
            this.notePanel1.Size = new System.Drawing.Size(376, 48);
            this.notePanel1.TabIndex = 4;
            // 
            // expiredServiceCountTxt
            // 
            this.expiredServiceCountTxt.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.openServiceCountTxt.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.openServiceCountTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openServiceCountTxt.Location = new System.Drawing.Point(15, 282);
            this.openServiceCountTxt.Name = "openServiceCountTxt";
            this.openServiceCountTxt.Size = new System.Drawing.Size(57, 24);
            this.openServiceCountTxt.TabIndex = 3;
            this.openServiceCountTxt.Text = "0000";
            this.openServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addNoteHomeBtn
            // 
            this.addNoteHomeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addNoteHomeBtn.AutoSize = false;
            this.addNoteHomeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addNoteHomeBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addNoteHomeBtn.Depth = 0;
            this.addNoteHomeBtn.HighEmphasis = true;
            this.addNoteHomeBtn.Icon = global::Worksite.Properties.Resources.plusBlack;
            this.addNoteHomeBtn.Location = new System.Drawing.Point(750, 31);
            this.addNoteHomeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addNoteHomeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.addNoteHomeBtn.Name = "addNoteHomeBtn";
            this.addNoteHomeBtn.Size = new System.Drawing.Size(189, 36);
            this.addNoteHomeBtn.TabIndex = 2;
            this.addNoteHomeBtn.Text = "Dodaj notatkę";
            this.addNoteHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.addNoteHomeBtn.UseAccentColor = false;
            this.addNoteHomeBtn.UseVisualStyleBackColor = true;
            this.addNoteHomeBtn.Click += new System.EventHandler(this.findServiceHomeBtn_Click);
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
            this.findServiceHomeBtn.TabIndex = 2;
            this.findServiceHomeBtn.Text = "Wyszukaj naprawę";
            this.findServiceHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.findServiceHomeBtn.UseAccentColor = false;
            this.findServiceHomeBtn.UseVisualStyleBackColor = true;
            this.findServiceHomeBtn.Click += new System.EventHandler(this.findServiceHomeBtn_Click);
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
            this.addCustomerHomeBtn.TabIndex = 1;
            this.addCustomerHomeBtn.Text = "Dodaj klienta";
            this.addCustomerHomeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addCustomerHomeBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addCustomerHomeBtn.UseAccentColor = false;
            this.addCustomerHomeBtn.UseVisualStyleBackColor = true;
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
            this.customersTab.ImageKey = "user24.png";
            this.customersTab.Location = new System.Drawing.Point(4, 31);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(986, 609);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Klienci";
            // 
            // servicesTab
            // 
            this.servicesTab.ImageKey = "wrench24.png";
            this.servicesTab.Location = new System.Drawing.Point(4, 31);
            this.servicesTab.Name = "servicesTab";
            this.servicesTab.Size = new System.Drawing.Size(986, 609);
            this.servicesTab.TabIndex = 2;
            this.servicesTab.Text = "Serwisy";
            // 
            // devicesTab
            // 
            this.devicesTab.ImageKey = "device24.png";
            this.devicesTab.Location = new System.Drawing.Point(4, 31);
            this.devicesTab.Name = "devicesTab";
            this.devicesTab.Size = new System.Drawing.Size(986, 609);
            this.devicesTab.TabIndex = 3;
            this.devicesTab.Text = "Sprzęty";
            // 
            // statsTab
            // 
            this.statsTab.ImageKey = "chart24.png";
            this.statsTab.Location = new System.Drawing.Point(4, 31);
            this.statsTab.Name = "statsTab";
            this.statsTab.Size = new System.Drawing.Size(986, 609);
            this.statsTab.TabIndex = 4;
            this.statsTab.Text = "Statystyki";
            // 
            // admtoolsTab
            // 
            this.admtoolsTab.ImageKey = "tools24.png";
            this.admtoolsTab.Location = new System.Drawing.Point(4, 31);
            this.admtoolsTab.Name = "admtoolsTab";
            this.admtoolsTab.Size = new System.Drawing.Size(986, 609);
            this.admtoolsTab.TabIndex = 5;
            this.admtoolsTab.Text = "Administracja";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.TabControl);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(850, 445);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksite";
            this.TabControl.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.homeTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.TabPage servicesTab;
        private System.Windows.Forms.TabPage devicesTab;
        private System.Windows.Forms.TabPage statsTab;
        private System.Windows.Forms.TabPage admtoolsTab;
        private System.Windows.Forms.ImageList menuIcon;
        private MaterialSkin.Controls.MaterialLabel welcomeTxt;
        private MaterialSkin.Controls.MaterialButton addCustomerHomeBtn;
        private MaterialSkin.Controls.MaterialButton addServiceHomeBtn;
        private MaterialSkin.Controls.MaterialButton findServiceHomeBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel servicesTxt;
        private MaterialSkin.Controls.MaterialLabel infoSecLineServiceTxt;
        private MaterialSkin.Controls.MaterialLabel infoHeaderServiceTxt;
        private System.Windows.Forms.Label openServiceCountTxt;
        private System.Windows.Forms.Label expiredServiceCountTxt;
        private MaterialSkin.Controls.MaterialButton addNoteHomeBtn;
        private MaterialSkin.Controls.MaterialExpansionPanel notePanel1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
    }
}

