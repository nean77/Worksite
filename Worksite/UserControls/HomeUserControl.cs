using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using Worksite.UserControls.Helpers;
using Worksite.Forms;
using MetroFramework;

namespace Worksite.UserControls
{
    public partial class HomeUserControl : MetroUserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
            getOpenServices();
            getExpiredServices();
        }

        private async void getOpenServices()
        {
            int os = await HomeControlHelpers.GetOpenServices();

            openServiceCountTxt.Text = os.ToString();
        }

        private async void getExpiredServices()
        {
            int os = await HomeControlHelpers.GetExpiredServices();

            expiredServiceCountTxt.Text = os.ToString();
        }

        private void addCustomerHomeBtn_Click(object sender, EventArgs e)
        {
            AddEditCustomerForm form = new AddEditCustomerForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "Dodano nowego klienta", "Zapisano nowego klienta", MessageBoxButtons.OK);
            }
        }
    }
}
