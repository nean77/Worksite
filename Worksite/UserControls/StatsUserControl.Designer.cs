namespace Worksite.UserControls
{
    partial class StatsUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statsLabel = new MetroFramework.Controls.MetroLabel();
            this.allServicesCountTail = new MetroFramework.Controls.MetroTile();
            this.openServicesCountTail = new MetroFramework.Controls.MetroTile();
            this.expiredServicesCountTile = new MetroFramework.Controls.MetroTile();
            this.totalServicesPriceTail = new MetroFramework.Controls.MetroTile();
            this.avgServicePriceTail = new MetroFramework.Controls.MetroTile();
            this.userStatsSummaryGrid = new MetroFramework.Controls.MetroGrid();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.userStatsSummaryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statsLabel
            // 
            this.statsLabel.AutoSize = true;
            this.statsLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.statsLabel.Location = new System.Drawing.Point(16, 24);
            this.statsLabel.Name = "statsLabel";
            this.statsLabel.Size = new System.Drawing.Size(74, 19);
            this.statsLabel.Style = MetroFramework.MetroColorStyle.Blue;
            this.statsLabel.TabIndex = 1;
            this.statsLabel.Text = "Statystyki";
            this.statsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statsLabel.UseStyleColors = true;
            // 
            // allServicesCountTail
            // 
            this.allServicesCountTail.ActiveControl = null;
            this.allServicesCountTail.Location = new System.Drawing.Point(28, 82);
            this.allServicesCountTail.Name = "allServicesCountTail";
            this.allServicesCountTail.Size = new System.Drawing.Size(267, 65);
            this.allServicesCountTail.Style = MetroFramework.MetroColorStyle.Green;
            this.allServicesCountTail.TabIndex = 2;
            this.allServicesCountTail.Text = "0 wykonanych serwisów";
            this.allServicesCountTail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.allServicesCountTail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.allServicesCountTail.UseSelectable = true;
            // 
            // openServicesCountTail
            // 
            this.openServicesCountTail.ActiveControl = null;
            this.openServicesCountTail.Location = new System.Drawing.Point(301, 82);
            this.openServicesCountTail.Name = "openServicesCountTail";
            this.openServicesCountTail.Size = new System.Drawing.Size(251, 65);
            this.openServicesCountTail.Style = MetroFramework.MetroColorStyle.Lime;
            this.openServicesCountTail.TabIndex = 2;
            this.openServicesCountTail.Text = "0 otwartych serwisów";
            this.openServicesCountTail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.openServicesCountTail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.openServicesCountTail.UseSelectable = true;
            // 
            // expiredServicesCountTile
            // 
            this.expiredServicesCountTile.ActiveControl = null;
            this.expiredServicesCountTile.Location = new System.Drawing.Point(558, 82);
            this.expiredServicesCountTile.Name = "expiredServicesCountTile";
            this.expiredServicesCountTile.Size = new System.Drawing.Size(279, 65);
            this.expiredServicesCountTile.Style = MetroFramework.MetroColorStyle.Red;
            this.expiredServicesCountTile.TabIndex = 2;
            this.expiredServicesCountTile.Text = "0 przedawnionych serwisów";
            this.expiredServicesCountTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.expiredServicesCountTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.expiredServicesCountTile.UseSelectable = true;
            // 
            // totalServicesPriceTail
            // 
            this.totalServicesPriceTail.ActiveControl = null;
            this.totalServicesPriceTail.Location = new System.Drawing.Point(28, 178);
            this.totalServicesPriceTail.Name = "totalServicesPriceTail";
            this.totalServicesPriceTail.Size = new System.Drawing.Size(475, 65);
            this.totalServicesPriceTail.Style = MetroFramework.MetroColorStyle.Orange;
            this.totalServicesPriceTail.TabIndex = 2;
            this.totalServicesPriceTail.Text = "Wycena wszystkich serwisów: ";
            this.totalServicesPriceTail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.totalServicesPriceTail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.totalServicesPriceTail.UseSelectable = true;
            // 
            // avgServicePriceTail
            // 
            this.avgServicePriceTail.ActiveControl = null;
            this.avgServicePriceTail.Location = new System.Drawing.Point(509, 178);
            this.avgServicePriceTail.Name = "avgServicePriceTail";
            this.avgServicePriceTail.Size = new System.Drawing.Size(328, 65);
            this.avgServicePriceTail.Style = MetroFramework.MetroColorStyle.Yellow;
            this.avgServicePriceTail.TabIndex = 2;
            this.avgServicePriceTail.Text = "Średnia cena serwisu: ";
            this.avgServicePriceTail.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.avgServicePriceTail.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.avgServicePriceTail.UseSelectable = true;
            // 
            // userStatsSummaryGrid
            // 
            this.userStatsSummaryGrid.AllowUserToAddRows = false;
            this.userStatsSummaryGrid.AllowUserToDeleteRows = false;
            this.userStatsSummaryGrid.AllowUserToResizeRows = false;
            this.userStatsSummaryGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userStatsSummaryGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.userStatsSummaryGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userStatsSummaryGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userStatsSummaryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userStatsSummaryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LastName,
            this.ServiceCount,
            this.TotalPrice});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userStatsSummaryGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.userStatsSummaryGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userStatsSummaryGrid.EnableHeadersVisualStyles = false;
            this.userStatsSummaryGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userStatsSummaryGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.userStatsSummaryGrid.Location = new System.Drawing.Point(28, 276);
            this.userStatsSummaryGrid.MultiSelect = false;
            this.userStatsSummaryGrid.Name = "userStatsSummaryGrid";
            this.userStatsSummaryGrid.ReadOnly = true;
            this.userStatsSummaryGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userStatsSummaryGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.userStatsSummaryGrid.RowHeadersVisible = false;
            this.userStatsSummaryGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.userStatsSummaryGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userStatsSummaryGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userStatsSummaryGrid.Size = new System.Drawing.Size(397, 233);
            this.userStatsSummaryGrid.TabIndex = 3;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // ServiceCount
            // 
            this.ServiceCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ServiceCount.HeaderText = "Liczba serwisów";
            this.ServiceCount.Name = "ServiceCount";
            this.ServiceCount.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalPrice.HeaderText = "Wycena wszystkich serwisów";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // StatsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.userStatsSummaryGrid);
            this.Controls.Add(this.expiredServicesCountTile);
            this.Controls.Add(this.openServicesCountTail);
            this.Controls.Add(this.avgServicePriceTail);
            this.Controls.Add(this.totalServicesPriceTail);
            this.Controls.Add(this.allServicesCountTail);
            this.Controls.Add(this.statsLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StatsUserControl";
            this.Size = new System.Drawing.Size(869, 588);
            ((System.ComponentModel.ISupportInitialize)(this.userStatsSummaryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel statsLabel;
        private MetroFramework.Controls.MetroTile allServicesCountTail;
        private MetroFramework.Controls.MetroTile openServicesCountTail;
        private MetroFramework.Controls.MetroTile expiredServicesCountTile;
        private MetroFramework.Controls.MetroTile totalServicesPriceTail;
        private MetroFramework.Controls.MetroTile avgServicePriceTail;
        private MetroFramework.Controls.MetroGrid userStatsSummaryGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
