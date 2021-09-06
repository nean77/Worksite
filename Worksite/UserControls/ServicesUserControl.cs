using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using Worksite.Forms;
using Worksite.UserControls.Helpers;

namespace Worksite.UserControls
{
    public partial class ServicesUserControl : MetroUserControl
    {
        public ServicesUserControl()
        {
            InitializeComponent();
            fillServicesGrid();
        }

        private async void fillServicesGrid()
        {
            var servicesList = await ServicesControlHelpers.GetServicesAsync();
            servicesGrid.Rows.Clear();
            foreach (var s in servicesList)
            {              
                int insertedRow = servicesGrid.Rows.Add(
                    new object[] {
                        s.ServiceOrderId,
                        s.Device.Name,
                        s.Device.InventNo,
                        s.Customer.LastName,
                        s.ServiceOrders_ServiceStatuses.FirstOrDefault().ServiceStatus,
                        ServicesControlHelpers.GetServicePrice(s),
                        s.User
                    });
                servicesGrid.Rows[insertedRow].Tag = s;
            }
        }

        private void addServiceBtn_Click(object sender, EventArgs e)
        {
            AddEditServiceForm form = new AddEditServiceForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "Naprawa została przyjęta");
                fillServicesGrid();
            }
        }

        private void editServiceBtn_Click(object sender, EventArgs e)
        {
            AddEditServiceForm form = new AddEditServiceForm((ServiceOrder)servicesGrid.SelectedRows[0].Tag);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "Naprawa została zmodyfikowana");
                fillServicesGrid();
            }
        }
    }
}
