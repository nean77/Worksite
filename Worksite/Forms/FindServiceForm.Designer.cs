namespace Worksite.Forms
{
    partial class FindServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindServiceForm));
            this.serviceIdTxt = new MetroFramework.Controls.MetroTextBox();
            this.findBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // serviceIdTxt
            // 
            // 
            // 
            // 
            this.serviceIdTxt.CustomButton.Image = null;
            this.serviceIdTxt.CustomButton.Location = new System.Drawing.Point(186, 1);
            this.serviceIdTxt.CustomButton.Name = "";
            this.serviceIdTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.serviceIdTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.serviceIdTxt.CustomButton.TabIndex = 1;
            this.serviceIdTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.serviceIdTxt.CustomButton.UseSelectable = true;
            this.serviceIdTxt.CustomButton.Visible = false;
            this.serviceIdTxt.Lines = new string[0];
            this.serviceIdTxt.Location = new System.Drawing.Point(32, 84);
            this.serviceIdTxt.MaxLength = 32767;
            this.serviceIdTxt.Name = "serviceIdTxt";
            this.serviceIdTxt.PasswordChar = '\0';
            this.serviceIdTxt.PromptText = "Nr naprawy";
            this.serviceIdTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.serviceIdTxt.SelectedText = "";
            this.serviceIdTxt.SelectionLength = 0;
            this.serviceIdTxt.SelectionStart = 0;
            this.serviceIdTxt.ShortcutsEnabled = true;
            this.serviceIdTxt.Size = new System.Drawing.Size(208, 23);
            this.serviceIdTxt.TabIndex = 0;
            this.serviceIdTxt.UseSelectable = true;
            this.serviceIdTxt.WaterMark = "Nr naprawy";
            this.serviceIdTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.serviceIdTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(32, 128);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(208, 23);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Znajdź";
            this.findBtn.UseSelectable = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // FindService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 185);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.serviceIdTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wyszukaj naprawę";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox serviceIdTxt;
        private MetroFramework.Controls.MetroButton findBtn;
    }
}