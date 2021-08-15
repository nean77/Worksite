namespace Worksite.UserControls
{
    partial class HomeUserControl
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
            this.addServiceHomeBtn = new MetroFramework.Controls.MetroButton();
            this.addCustomerHomeBtn = new MetroFramework.Controls.MetroButton();
            this.findServiceHomeBtn = new MetroFramework.Controls.MetroButton();
            this.infoHeaderServiceTxt = new MetroFramework.Controls.MetroLabel();
            this.openServiceCountTxt = new MetroFramework.Controls.MetroLabel();
            this.servicesTxt = new MetroFramework.Controls.MetroLabel();
            this.infoSecLineServiceTxt = new MetroFramework.Controls.MetroLabel();
            this.expiredServiceCountTxt = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // addServiceHomeBtn
            // 
            this.addServiceHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addServiceHomeBtn.Highlight = true;
            this.addServiceHomeBtn.Location = new System.Drawing.Point(36, 32);
            this.addServiceHomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addServiceHomeBtn.Name = "addServiceHomeBtn";
            this.addServiceHomeBtn.Size = new System.Drawing.Size(189, 60);
            this.addServiceHomeBtn.TabIndex = 1;
            this.addServiceHomeBtn.Text = "DODAJ NAPRAWĘ";
            this.addServiceHomeBtn.UseSelectable = true;
            // 
            // addCustomerHomeBtn
            // 
            this.addCustomerHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCustomerHomeBtn.Highlight = true;
            this.addCustomerHomeBtn.Location = new System.Drawing.Point(254, 32);
            this.addCustomerHomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addCustomerHomeBtn.Name = "addCustomerHomeBtn";
            this.addCustomerHomeBtn.Size = new System.Drawing.Size(189, 60);
            this.addCustomerHomeBtn.TabIndex = 2;
            this.addCustomerHomeBtn.Text = "DODAJ KLIENTA";
            this.addCustomerHomeBtn.UseSelectable = true;
            this.addCustomerHomeBtn.Click += new System.EventHandler(this.addCustomerHomeBtn_Click);
            // 
            // findServiceHomeBtn
            // 
            this.findServiceHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findServiceHomeBtn.Highlight = true;
            this.findServiceHomeBtn.Location = new System.Drawing.Point(474, 32);
            this.findServiceHomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.findServiceHomeBtn.Name = "findServiceHomeBtn";
            this.findServiceHomeBtn.Size = new System.Drawing.Size(318, 60);
            this.findServiceHomeBtn.TabIndex = 3;
            this.findServiceHomeBtn.Text = "WYSZUKAJ NAPRAWĘ";
            this.findServiceHomeBtn.UseSelectable = true;
            // 
            // infoHeaderServiceTxt
            // 
            this.infoHeaderServiceTxt.AutoSize = true;
            this.infoHeaderServiceTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.infoHeaderServiceTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.infoHeaderServiceTxt.Location = new System.Drawing.Point(36, 157);
            this.infoHeaderServiceTxt.Name = "infoHeaderServiceTxt";
            this.infoHeaderServiceTxt.Size = new System.Drawing.Size(191, 25);
            this.infoHeaderServiceTxt.TabIndex = 2;
            this.infoHeaderServiceTxt.Text = "Posiadasz otwartych:";
            // 
            // openServiceCountTxt
            // 
            this.openServiceCountTxt.AutoSize = true;
            this.openServiceCountTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.openServiceCountTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.openServiceCountTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openServiceCountTxt.Location = new System.Drawing.Point(51, 193);
            this.openServiceCountTxt.Name = "openServiceCountTxt";
            this.openServiceCountTxt.Size = new System.Drawing.Size(52, 25);
            this.openServiceCountTxt.TabIndex = 2;
            this.openServiceCountTxt.Text = "0000";
            this.openServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openServiceCountTxt.UseStyleColors = true;
            // 
            // servicesTxt
            // 
            this.servicesTxt.AutoSize = true;
            this.servicesTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.servicesTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.servicesTxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.servicesTxt.Location = new System.Drawing.Point(105, 193);
            this.servicesTxt.Name = "servicesTxt";
            this.servicesTxt.Size = new System.Drawing.Size(90, 25);
            this.servicesTxt.TabIndex = 2;
            this.servicesTxt.Text = "serwisów";
            this.servicesTxt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoSecLineServiceTxt
            // 
            this.infoSecLineServiceTxt.AutoSize = true;
            this.infoSecLineServiceTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.infoSecLineServiceTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.infoSecLineServiceTxt.Location = new System.Drawing.Point(36, 235);
            this.infoSecLineServiceTxt.Name = "infoSecLineServiceTxt";
            this.infoSecLineServiceTxt.Size = new System.Drawing.Size(184, 25);
            this.infoSecLineServiceTxt.TabIndex = 2;
            this.infoSecLineServiceTxt.Text = "w tym opóźnionych:";
            // 
            // expiredServiceCountTxt
            // 
            this.expiredServiceCountTxt.AutoSize = true;
            this.expiredServiceCountTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.expiredServiceCountTxt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.expiredServiceCountTxt.ForeColor = System.Drawing.Color.Red;
            this.expiredServiceCountTxt.Location = new System.Drawing.Point(51, 271);
            this.expiredServiceCountTxt.Name = "expiredServiceCountTxt";
            this.expiredServiceCountTxt.Size = new System.Drawing.Size(52, 25);
            this.expiredServiceCountTxt.Style = MetroFramework.MetroColorStyle.Red;
            this.expiredServiceCountTxt.TabIndex = 2;
            this.expiredServiceCountTxt.Text = "0000";
            this.expiredServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expiredServiceCountTxt.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(105, 271);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 25);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "serwisów";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.servicesTxt);
            this.Controls.Add(this.expiredServiceCountTxt);
            this.Controls.Add(this.openServiceCountTxt);
            this.Controls.Add(this.infoSecLineServiceTxt);
            this.Controls.Add(this.infoHeaderServiceTxt);
            this.Controls.Add(this.findServiceHomeBtn);
            this.Controls.Add(this.addCustomerHomeBtn);
            this.Controls.Add(this.addServiceHomeBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(869, 588);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton addServiceHomeBtn;
        private MetroFramework.Controls.MetroButton addCustomerHomeBtn;
        private MetroFramework.Controls.MetroButton findServiceHomeBtn;
        private MetroFramework.Controls.MetroLabel infoHeaderServiceTxt;
        private MetroFramework.Controls.MetroLabel openServiceCountTxt;
        private MetroFramework.Controls.MetroLabel servicesTxt;
        private MetroFramework.Controls.MetroLabel infoSecLineServiceTxt;
        private MetroFramework.Controls.MetroLabel expiredServiceCountTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}
