namespace Worksite.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroPanelMenu = new MetroFramework.Controls.MetroPanel();
            this.AdmToolsTile = new MetroFramework.Controls.MetroTile();
            this.StatsTile = new MetroFramework.Controls.MetroTile();
            this.DevicesTile = new MetroFramework.Controls.MetroTile();
            this.ServicesTile = new MetroFramework.Controls.MetroTile();
            this.CustomersTile = new MetroFramework.Controls.MetroTile();
            this.HomeTile = new MetroFramework.Controls.MetroTile();
            this.metroPanelContainer = new MetroFramework.Controls.MetroPanel();
            this.metroPanelFooter = new MetroFramework.Controls.MetroPanel();
            this.LoggedLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanelMenu.SuspendLayout();
            this.metroPanelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanelMenu
            // 
            this.metroPanelMenu.Controls.Add(this.AdmToolsTile);
            this.metroPanelMenu.Controls.Add(this.StatsTile);
            this.metroPanelMenu.Controls.Add(this.DevicesTile);
            this.metroPanelMenu.Controls.Add(this.ServicesTile);
            this.metroPanelMenu.Controls.Add(this.CustomersTile);
            this.metroPanelMenu.Controls.Add(this.HomeTile);
            this.metroPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanelMenu.HorizontalScrollbarBarColor = true;
            this.metroPanelMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelMenu.HorizontalScrollbarSize = 10;
            this.metroPanelMenu.Location = new System.Drawing.Point(30, 97);
            this.metroPanelMenu.Name = "metroPanelMenu";
            this.metroPanelMenu.Size = new System.Drawing.Size(268, 611);
            this.metroPanelMenu.TabIndex = 0;
            this.metroPanelMenu.VerticalScrollbarBarColor = true;
            this.metroPanelMenu.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelMenu.VerticalScrollbarSize = 10;
            // 
            // AdmToolsTile
            // 
            this.AdmToolsTile.ActiveControl = null;
            this.AdmToolsTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdmToolsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdmToolsTile.Location = new System.Drawing.Point(3, 313);
            this.AdmToolsTile.Name = "AdmToolsTile";
            this.AdmToolsTile.Size = new System.Drawing.Size(262, 50);
            this.AdmToolsTile.TabIndex = 1;
            this.AdmToolsTile.Text = "ADMINISTRACJA";
            this.AdmToolsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdmToolsTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AdmToolsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.AdmToolsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.AdmToolsTile.UseSelectable = true;
            // 
            // StatsTile
            // 
            this.StatsTile.ActiveControl = null;
            this.StatsTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatsTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatsTile.Location = new System.Drawing.Point(3, 257);
            this.StatsTile.Name = "StatsTile";
            this.StatsTile.Size = new System.Drawing.Size(262, 50);
            this.StatsTile.TabIndex = 1;
            this.StatsTile.Text = "STATYSTYKI";
            this.StatsTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StatsTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StatsTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.StatsTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.StatsTile.UseSelectable = true;
            // 
            // DevicesTile
            // 
            this.DevicesTile.ActiveControl = null;
            this.DevicesTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DevicesTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevicesTile.Location = new System.Drawing.Point(3, 201);
            this.DevicesTile.Name = "DevicesTile";
            this.DevicesTile.Size = new System.Drawing.Size(262, 50);
            this.DevicesTile.TabIndex = 1;
            this.DevicesTile.Text = "SPRZĘT";
            this.DevicesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DevicesTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DevicesTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.DevicesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.DevicesTile.UseSelectable = true;
            this.DevicesTile.Click += new System.EventHandler(this.DevicesTile_Click);
            // 
            // ServicesTile
            // 
            this.ServicesTile.ActiveControl = null;
            this.ServicesTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServicesTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesTile.Location = new System.Drawing.Point(3, 145);
            this.ServicesTile.Name = "ServicesTile";
            this.ServicesTile.Size = new System.Drawing.Size(262, 50);
            this.ServicesTile.TabIndex = 1;
            this.ServicesTile.Text = "SERWISY";
            this.ServicesTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServicesTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ServicesTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ServicesTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.ServicesTile.UseSelectable = true;
            this.ServicesTile.Click += new System.EventHandler(this.ServicesTile_Click);
            // 
            // CustomersTile
            // 
            this.CustomersTile.ActiveControl = null;
            this.CustomersTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomersTile.Location = new System.Drawing.Point(3, 89);
            this.CustomersTile.Name = "CustomersTile";
            this.CustomersTile.Size = new System.Drawing.Size(262, 50);
            this.CustomersTile.TabIndex = 1;
            this.CustomersTile.Text = "KLIENCI";
            this.CustomersTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CustomersTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.CustomersTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.CustomersTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.CustomersTile.UseSelectable = true;
            this.CustomersTile.Click += new System.EventHandler(this.CustomersTile_Click);
            // 
            // HomeTile
            // 
            this.HomeTile.ActiveControl = null;
            this.HomeTile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeTile.Location = new System.Drawing.Point(3, 33);
            this.HomeTile.Name = "HomeTile";
            this.HomeTile.Size = new System.Drawing.Size(262, 50);
            this.HomeTile.TabIndex = 1;
            this.HomeTile.Text = "HOME";
            this.HomeTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HomeTile.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.HomeTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.HomeTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.HomeTile.UseSelectable = true;
            this.HomeTile.Click += new System.EventHandler(this.HomeTile_Click);
            // 
            // metroPanelContainer
            // 
            this.metroPanelContainer.AutoSize = true;
            this.metroPanelContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanelContainer.HorizontalScrollbarBarColor = true;
            this.metroPanelContainer.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelContainer.HorizontalScrollbarSize = 10;
            this.metroPanelContainer.Location = new System.Drawing.Point(298, 97);
            this.metroPanelContainer.Name = "metroPanelContainer";
            this.metroPanelContainer.Size = new System.Drawing.Size(922, 611);
            this.metroPanelContainer.TabIndex = 0;
            this.metroPanelContainer.VerticalScrollbarBarColor = true;
            this.metroPanelContainer.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelContainer.VerticalScrollbarSize = 10;
            // 
            // metroPanelFooter
            // 
            this.metroPanelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanelFooter.Controls.Add(this.LoggedLabel);
            this.metroPanelFooter.HorizontalScrollbarBarColor = true;
            this.metroPanelFooter.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanelFooter.HorizontalScrollbarSize = 10;
            this.metroPanelFooter.Location = new System.Drawing.Point(33, 675);
            this.metroPanelFooter.Name = "metroPanelFooter";
            this.metroPanelFooter.Size = new System.Drawing.Size(1193, 30);
            this.metroPanelFooter.TabIndex = 2;
            this.metroPanelFooter.VerticalScrollbarBarColor = true;
            this.metroPanelFooter.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanelFooter.VerticalScrollbarSize = 10;
            // 
            // LoggedLabel
            // 
            this.LoggedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoggedLabel.AutoSize = true;
            this.LoggedLabel.Location = new System.Drawing.Point(5, 5);
            this.LoggedLabel.Name = "LoggedLabel";
            this.LoggedLabel.Size = new System.Drawing.Size(111, 19);
            this.LoggedLabel.TabIndex = 99999;
            this.LoggedLabel.Text = "Zalogowany jako:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 740);
            this.Controls.Add(this.metroPanelFooter);
            this.Controls.Add(this.metroPanelContainer);
            this.Controls.Add(this.metroPanelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1250, 740);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(30, 97, 30, 32);
            this.Text = "Worksite";
            this.metroPanelMenu.ResumeLayout(false);
            this.metroPanelFooter.ResumeLayout(false);
            this.metroPanelFooter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanelMenu;
        private MetroFramework.Controls.MetroTile HomeTile;
        private MetroFramework.Controls.MetroPanel metroPanelFooter;
        private MetroFramework.Controls.MetroTile AdmToolsTile;
        private MetroFramework.Controls.MetroTile StatsTile;
        private MetroFramework.Controls.MetroTile DevicesTile;
        private MetroFramework.Controls.MetroTile ServicesTile;
        private MetroFramework.Controls.MetroTile CustomersTile;
        public MetroFramework.Controls.MetroPanel metroPanelContainer;
        private MetroFramework.Controls.MetroLabel LoggedLabel;
    }
}