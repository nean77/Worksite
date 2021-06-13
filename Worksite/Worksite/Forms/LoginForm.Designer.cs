
namespace Worksite.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.passwordTxt = new MaterialSkin.Controls.MaterialTextBox();
            this.loginBtn = new MaterialSkin.Controls.MaterialButton();
            this.cancelBtn = new MaterialSkin.Controls.MaterialButton();
            this.headerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // loginTxt
            // 
            this.loginTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTxt.Depth = 0;
            this.loginTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loginTxt.Hint = "Login";
            this.loginTxt.LeadingIcon = null;
            this.loginTxt.Location = new System.Drawing.Point(47, 136);
            this.loginTxt.MaxLength = 50;
            this.loginTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.loginTxt.Multiline = false;
            this.loginTxt.Name = "loginTxt";
            this.loginTxt.Size = new System.Drawing.Size(296, 50);
            this.loginTxt.TabIndex = 0;
            this.loginTxt.Text = "nean";
            this.loginTxt.TrailingIcon = null;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Depth = 0;
            this.passwordTxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.passwordTxt.Hint = "Hasło";
            this.passwordTxt.LeadingIcon = global::Worksite.Properties.Resources.baseline_fingerprint_black_24dp;
            this.passwordTxt.Location = new System.Drawing.Point(47, 199);
            this.passwordTxt.MaxLength = 50;
            this.passwordTxt.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordTxt.Multiline = false;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Password = true;
            this.passwordTxt.Size = new System.Drawing.Size(296, 50);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Text = "nean";
            this.passwordTxt.TrailingIcon = null;
            this.passwordTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_MouseClick);
            this.passwordTxt.Enter += new System.EventHandler(this.passwordTxt_Enter);
            this.passwordTxt.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.passwordTxt_MouseDoubleClick);
            // 
            // loginBtn
            // 
            this.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.loginBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.loginBtn.Depth = 0;
            this.loginBtn.HighEmphasis = true;
            this.loginBtn.Icon = null;
            this.loginBtn.Location = new System.Drawing.Point(176, 294);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.loginBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(86, 36);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Zaloguj";
            this.loginBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.loginBtn.UseAccentColor = false;
            this.loginBtn.UseCompatibleTextRendering = true;
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.cancelBtn.Depth = 0;
            this.cancelBtn.HighEmphasis = true;
            this.cancelBtn.Icon = null;
            this.cancelBtn.Location = new System.Drawing.Point(267, 294);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cancelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(77, 36);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Anuluj";
            this.cancelBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.cancelBtn.UseAccentColor = false;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Depth = 0;
            this.headerLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.headerLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.headerLabel.Location = new System.Drawing.Point(47, 81);
            this.headerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(345, 29);
            this.headerLabel.TabIndex = 4;
            this.headerLabel.Text = "Zaloguj się do aplikacji Worksite";
            this.headerLabel.UseAccent = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 353);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.loginTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(396, 353);
            this.MinimumSize = new System.Drawing.Size(396, 353);
            this.Name = "LoginForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox loginTxt;
        private MaterialSkin.Controls.MaterialTextBox passwordTxt;
        private MaterialSkin.Controls.MaterialButton loginBtn;
        private MaterialSkin.Controls.MaterialButton cancelBtn;
        private MaterialSkin.Controls.MaterialLabel headerLabel;
    }
}