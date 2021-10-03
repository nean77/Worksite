using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.UserControls;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class MainForm : MetroForm
    {
        CurrentUser currentUser = CurrentUser.GetInstance();

        public MainForm()
        {
            InitializeComponent();
            HomeTile_Click(this, new System.EventArgs());
            LoggedLabel.Text += " " + currentUser.ToString();
            HideIfNotAdmin();
        }

        private void HideIfNotAdmin()
        {
            StatsTile.Visible = AdmToolsTile.Visible = currentUser.Administrator;
        }

        private void HomeTile_Click(object sender, System.EventArgs e)
        {
            HomeControlHelpers.SetUpUserControl(metroPanelContainer, new HomeUserControl());
        }

        private void CustomersTile_Click(object sender, System.EventArgs e)
        {
            CustomersControlHelpers.SetUpUserControl(metroPanelContainer, new CustomersUserControl());
        }

        private void ServicesTile_Click(object sender, System.EventArgs e)
        {
            ServicesControlHelpers.SetUpUserControl(metroPanelContainer, new ServicesUserControl());
        }

        private void DevicesTile_Click(object sender, System.EventArgs e)
        {
            DevicesControlHelpers.SetUpUserControl(metroPanelContainer, new DevicesUserControl());
        }

        private void AdmToolsTile_Click(object sender, System.EventArgs e)
        {
            AdministrationControlHelpers.SetUpUserControl(metroPanelContainer, new AdministrationUserControl());
        }

        private void StatsTile_Click(object sender, EventArgs e)
        {
            StatsControlHelpers.SetUpUserControl(metroPanelContainer, new StatsUserControl());
        }
    }
}
