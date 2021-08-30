using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.Exceptions;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class AddEditDeviceForm : MetroForm
    {
        DevicesControlHelpers devicesControlHelpers = new DevicesControlHelpers();
        Device selectedDevice = new Device();

        public AddEditDeviceForm(Device dev = null)
        {
            selectedDevice = dev;
            InitializeComponent();
            init();
            initializeControlsContent();
        }

        private async void initializeControlsContent()
        {
            devTypeComboBox.DataSource = Enum.GetValues(typeof(DeviceTypes.DeviceType));
            devTypeComboBox.SelectedIndex = -1;
            await fillCustomerCombo();
            customerComboBox.SelectedIndex = -1;

            if (devicesControlHelpers.DevId == null)
            {
                this.Text = "Nowy sprzęt";
            }
            else
            {
                this.Text = "Edycja sprzęt";
                devicesControlHelpers.Device = DevicesControlHelpers.GetDeviceById(selectedDevice.DeviceId);
                nameTxt.Text = devicesControlHelpers.Device.Name;
                inventNoTxt.Text = devicesControlHelpers.Device.InventNo.ToString();
                devTypeComboBox.SelectedIndex = (int)devicesControlHelpers.Device.DeviceTypeId - 1;
                serialTxt.Text = devicesControlHelpers.Device.SerialNumber;
                int idx = customerComboBox.FindString(devicesControlHelpers.Device.Customer.ToString());
                customerComboBox.SelectedIndex = idx;
            }
        }      
        private async Task<bool> fillCustomerCombo()
        {
            var custList = await CustomersControlHelpers.GetCustomersAsync();
            customerComboBox.Items.Clear();
            foreach (var c in custList)
            {
               customerComboBox.Items.Add(c);
            }
            return true;
        }
        private async void saveBtn_Click(object sender, EventArgs e)
        {
            
            bool result;
            if (!validateFields())
            {
                return;
            }
            
            if (selectedDevice == null || selectedDevice.DeviceId == 0)
            {
                devicesControlHelpers.Device = new Device();
                passDeviceDetails();
            }
            
            if (devicesControlHelpers.Device.DeviceId > 0)
            {
                passDeviceDetails();
                try
                {
                    bool hasChanges = await devicesControlHelpers.HasChanges();
                }
                catch (NoDeviceDataChangesException)
                {
                    MetroMessageBox.Show(this, "Nie dokonano zmian danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
                result = await devicesControlHelpers.UpdateAsync();
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd aktualizacji danych", "Brak zmian", MessageBoxButtons.OK);
                }
            }
            else
            {
                result = await devicesControlHelpers.SaveAsync();
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd zapisu danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void passDeviceDetails()
        {
            devicesControlHelpers.Device.Name = nameTxt.Text;
            devicesControlHelpers.Device.InventNo = (int?)Convert.ToInt32(inventNoTxt.Text);
            devicesControlHelpers.Device.SerialNumber = serialTxt.Text;
            devicesControlHelpers.Device.DeviceTypeId = (int)((DeviceTypes.DeviceType)(devTypeComboBox.SelectedItem));
            devicesControlHelpers.Device.CustomerId = ((Customer)customerComboBox.SelectedItem).CustomerId;
        }
        private bool validateFields()
        {
            
            if ( nameTxt.Text == "" || devTypeComboBox.SelectedIndex == -1 || customerComboBox.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Nie wszystkie pola wymagane są wypełnione", "Wypełnij wymagane pola", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
        }
        private void init()
        {
            devicesControlHelpers.DevId = selectedDevice.DeviceId;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void addCustomerButton_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddEditCustomerForm form = new AddEditCustomerForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                await fillCustomerCombo();
                customerComboBox.SelectedIndex = customerComboBox.Items.Count - 1;
            }
            this.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Text = inventNoTxt.Text = serialTxt.Text = String.Empty;
            devTypeComboBox.SelectedIndex = customerComboBox.SelectedIndex = -1;
        }
    }
}
