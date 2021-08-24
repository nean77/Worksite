using MetroFramework;
using MetroFramework.Controls;
using System.Windows.Forms;
using Worksite.Forms;
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

        private void addDeviceBtn_Click(object sender, System.EventArgs e)
        {
            AddEditDeviceForm form = new AddEditDeviceForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                fillDevicesGrid();
            }
        }

        private void editDeviceBtn_Click(object sender, System.EventArgs e)
        {
            if (devicesGrid.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(this, "Aby edytować zaznacz sprzęt", "Brak rekodru", MessageBoxButtons.OK);
                return;
            }
            AddEditDeviceForm form = new AddEditDeviceForm((long?)devicesGrid.SelectedRows[0].Cells[0].Value);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                fillDevicesGrid();
            }
        }
    }
}
