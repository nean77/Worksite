
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
            this.customersTab = new System.Windows.Forms.TabPage();
            this.servicesTab = new System.Windows.Forms.TabPage();
            this.devicesTab = new System.Windows.Forms.TabPage();
            this.statsTab = new System.Windows.Forms.TabPage();
            this.admtoolsTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
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
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(994, 644);
            this.TabControl.TabIndex = 5;
            // 
            // homeTab
            // 
            this.homeTab.ImageKey = "home24.png";
            this.homeTab.Location = new System.Drawing.Point(4, 31);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(986, 609);
            this.homeTab.TabIndex = 0;
            this.homeTab.Text = "Home";
            // 
            // customersTab
            // 
            this.customersTab.ImageKey = "user24.png";
            this.customersTab.Location = new System.Drawing.Point(4, 31);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(3);
            this.customersTab.Size = new System.Drawing.Size(786, 409);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Klienci";
            // 
            // servicesTab
            // 
            this.servicesTab.ImageKey = "wrench24.png";
            this.servicesTab.Location = new System.Drawing.Point(4, 31);
            this.servicesTab.Name = "servicesTab";
            this.servicesTab.Size = new System.Drawing.Size(786, 409);
            this.servicesTab.TabIndex = 2;
            this.servicesTab.Text = "Serwisy";
            // 
            // devicesTab
            // 
            this.devicesTab.ImageKey = "device24.png";
            this.devicesTab.Location = new System.Drawing.Point(4, 31);
            this.devicesTab.Name = "devicesTab";
            this.devicesTab.Size = new System.Drawing.Size(786, 409);
            this.devicesTab.TabIndex = 3;
            this.devicesTab.Text = "Sprzęty";
            // 
            // statsTab
            // 
            this.statsTab.ImageKey = "chart24.png";
            this.statsTab.Location = new System.Drawing.Point(4, 31);
            this.statsTab.Name = "statsTab";
            this.statsTab.Size = new System.Drawing.Size(786, 409);
            this.statsTab.TabIndex = 4;
            this.statsTab.Text = "Statystyki";
            // 
            // admtoolsTab
            // 
            this.admtoolsTab.ImageKey = "tools24.png";
            this.admtoolsTab.Location = new System.Drawing.Point(4, 31);
            this.admtoolsTab.Name = "admtoolsTab";
            this.admtoolsTab.Size = new System.Drawing.Size(786, 409);
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
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worksite";
            this.TabControl.ResumeLayout(false);
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
    }
}

