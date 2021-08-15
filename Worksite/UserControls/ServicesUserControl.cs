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
                servicesGrid.Rows.Add(new object[] { s.ServiceOrderId, s.DeviceName, s.InventNo, s.LastName, s.ServiceStatusName, s.ServiceValue, s.Employee });
            }
        }
    }
}
