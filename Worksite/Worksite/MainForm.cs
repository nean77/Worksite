using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.Helpers;
using Worksite.Helpers.UserUI_helpers;

namespace Worksite
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        private DesignController designController = new DesignController();
        private void setColor()
        {
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Grey800,
                Primary.Grey900,
                Primary.Grey500,
                Accent.Blue400,
                TextShade.WHITE);
        }
        private void initTextSettings()
        {
            // openServiceCountTxt
            this.openServiceCountTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.openServiceCountTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.openServiceCountTxt.Location = new System.Drawing.Point(15, 282);
            this.openServiceCountTxt.Size = new System.Drawing.Size(57, 24);
            this.openServiceCountTxt.TabIndex = 0;
            this.openServiceCountTxt.Text = HomePGHelpers.getUserOpenServices().ToString();
            this.openServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            
            // expiredServiceCountTxt
            this.expiredServiceCountTxt.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.expiredServiceCountTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expiredServiceCountTxt.Location = new System.Drawing.Point(15, 354);
            this.expiredServiceCountTxt.Size = new System.Drawing.Size(57, 24);
            this.expiredServiceCountTxt.TabIndex = 0;
            this.expiredServiceCountTxt.Text = HomePGHelpers.getUserExpiredServices().ToString();
            this.expiredServiceCountTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // header login info
            this.Text += "   |    Zalogowany jako: " + Program.currentUser.FirstName + " " + Program.currentUser.LastName;
        }
        public MainForm()
        {
            InitializeComponent();
            setColor();
            initTextSettings();
            designController.initUserControls(this);
        }

        private void TabControl_TabIndexChanged(object sender, EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    break;
                case 6:
                    break;

            }
        }
    }
}
