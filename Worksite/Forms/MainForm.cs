using MetroFramework.Forms;
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
    }
}
