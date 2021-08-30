using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.Exceptions;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class AddEditServiceForm : MetroForm
    {
        DevicesControlHelpers devicesControlHelpers = new DevicesControlHelpers();
        ServiceOrder serviceOrder = new ServiceOrder();
        
        public AddEditServiceForm(ServiceOrder selectedService = null)
        {
            InitializeComponent();
            serviceOrder = selectedService;
            initializeControlsContent();
        }
        #region Methods
        private void initializeControlsContent()
        {
            fillServiceTypesCheckBoxes();
            fillCustomerCombo();
            fillServiceStatusCombo();
            fillUserCombo();
            
            if (serviceOrder == null)
            {
                this.Text = "Nowa naprawa";
            }
            else
            {
                this.Text = "Edycja naprawy";
                int idx = customerComboBox.FindString(serviceOrder.Customer.ToString());
                customerComboBox.SelectedIndex = idx;

                //devicesControlHelpers.Device = DevicesControlHelpers.GetDeviceById(_devId);
                //nameTxt.Text = devicesControlHelpers.Device.Name;
                //inventNoTxt.Text = devicesControlHelpers.Device.InventNo.ToString();
                //devTypeComboBox.SelectedIndex = (int)devicesControlHelpers.Device.DeviceTypeId - 1;
                //serialTxt.Text = devicesControlHelpers.Device.SerialNumber;
                //int idx = customerComboBox.FindString(devicesControlHelpers.Device.Customer.ToString());
                //customerComboBox.SelectedIndex = idx;
            }
        }
        private void fillServiceTypesCheckBoxes(bool reloadNames = true)
        {
            var list = ServicesControlHelpers.GetServiceTypes();
            byte i = 1;
            foreach (var l in list)
            {                
                try
                {                    
                    string name = "metroCheckBox" + i;
                    Control[] x = Controls.Find(name, false);
                    if (reloadNames)
                    {
                        x[0].Text = l.Name;
                        x[0].Tag = l;
                    }
                    if (serviceStatusComboBox.SelectedIndex > 0 &&
                        serviceStatusComboBox.SelectedIndex < 4)
                    {
                        x[0].Enabled = true;
                    }
                    else
                    {
                        x[0].Enabled = false;
                    }
                        i++;
                }
                catch
                {
                    //save log
                }
            }
        }
        private void fillUserCombo()
        {
            var userList = DevicesControlHelpers.GetEmployees();
            userComboBox.Items.Clear();
            foreach (var u in userList)
            {
                userComboBox.Items.Add(u);
            }
        }
        private async void fillCustomerCombo()
        {            
            var custList = await CustomersControlHelpers.GetCustomersAsync();
            customerComboBox.Items.Clear();
            foreach (var c in custList)
            {
               customerComboBox.Items.Add(c);
            }
            
        }
        private async void fillCustomerDeviceCombo(Customer cust)
        {
            var devList = await DevicesControlHelpers.GetCustomerDevicesAsync(cust);
            deviceComboBox.Items.Clear();
            foreach (var d in devList)
            {
                deviceComboBox.Items.Add(d);
            }
            deviceComboBox.Enabled = true;
        }
        private void fillServiceStatusCombo()
        {
            var statusList = ServicesControlHelpers.GetServiceStatuses();
            serviceStatusComboBox.Items.Clear();
            foreach (var s in statusList)
            {
                serviceStatusComboBox.Items.Add(s);
            }
        }
        private async void saveBtn_Click(object sender, EventArgs e)
        {
            /*
            bool result;
            if (!validateFields())
            {
                return;
            }
            
            if (_devId == null || _devId == 0)
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
            */
        }
        private void passDeviceDetails()
        {
            /*
            devicesControlHelpers.Device.Name = nameTxt.Text;
            devicesControlHelpers.Device.InventNo = (int?)Convert.ToInt32(inventNoTxt.Text);
            devicesControlHelpers.Device.SerialNumber = serialTxt.Text;
            devicesControlHelpers.Device.DeviceTypeId = (int)((DeviceTypes.DeviceType)(devTypeComboBox.SelectedItem));
            devicesControlHelpers.Device.CustomerId = ((Customer)customerComboBox.SelectedItem).CustomerId;
            */
        }
        private void validateFields()
        {
            /*
            if ( nameTxt.Text == "" || devTypeComboBox.SelectedIndex == -1 || customerComboBox.SelectedIndex == -1)
            {
                MetroMessageBox.Show(this, "Nie wszystkie pola wymagane są wypełnione", "Wypełnij wymagane pola", MessageBoxButtons.OK);
                return false;
            }
            
            return true;
            */
        }
        #endregion
        #region Events
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            customerComboBox.SelectedIndex = deviceComboBox.SelectedIndex = userComboBox.SelectedIndex = serviceStatusComboBox.SelectedIndex = -1;
            startDateTime.Value = endDateTime.Value = DateTime.Now.Date;
        }
        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddEditCustomerForm form = new AddEditCustomerForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                fillCustomerCombo();
            }
        }
        private void addDeviceBtn_Click(object sender, EventArgs e)
        {
            AddEditDeviceForm form = new AddEditDeviceForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (customerComboBox.SelectedIndex > -1)
                {
                    fillCustomerDeviceCombo((Customer)customerComboBox.SelectedItem);
                }
            }
        }
        private void startDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (this.Text != "Edycja naprawy")
            {
                endDateTime.Value = startDateTime.Value.AddDays(14);
            }
        }
        private void metroCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            hoursQtyTxt.Enabled = metroCheckBox8.Checked;
        }
        private void hoursQtyTxt_EnabledChanged(object sender, EventArgs e)
        {
            if (!hoursQtyTxt.Enabled)
            {
                hoursQtyTxt.Text = String.Empty;
            }

        }
        private void serviceStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillServiceTypesCheckBoxes(false);
        }
        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillCustomerDeviceCombo((Customer)customerComboBox.SelectedItem);

        }
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            inventNoTxt.Text = ((Device)(deviceComboBox.SelectedItem)).InventNo.ToString();
        }
        #endregion

        
    }
}
