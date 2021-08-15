using MetroFramework.Controls;
using Worksite.UserControls.Helpers;

namespace Worksite.UserControls
{
    public partial class DevicesUserControl : MetroUserControl
    {
        public DevicesUserControl()
        {
            InitializeComponent();
            fillDevicesGrid();
        }

        private async void fillDevicesGrid()
        {
            var devList = await DevicesControlHelpers.GetDevicesAsync();

            devicesGrid.Rows.Clear();
            foreach (var d in devList)
            {
                devicesGrid.Rows.Add(new object[] { d.DeviceId, d.Name, d.InventNo, d.DeviceType, d.FirstName, d.LastName });
            }
        }

    }
}
