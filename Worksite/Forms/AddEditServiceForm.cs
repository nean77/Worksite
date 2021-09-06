using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.Classes;
using Worksite.Exceptions;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class AddEditServiceForm : MetroForm
    {
        ServicesControlHelpers servicesControlHelpers = new ServicesControlHelpers();
        ServiceOrder serviceOrder = new ServiceOrder();
        Dictionary<long, string> serviceTypesDict = new Dictionary<long, string>();
        
        public AddEditServiceForm(ServiceOrder selectedService = null)
        {
            InitializeComponent();
            serviceOrder = selectedService;
            initializeControlsContent();
        }
        #region Methods
        private async void initializeControlsContent()
        {            
            await fillCustomerCombo();
            fillServiceStatusCombo();
            fillUserCombo();
            fillServiceTypesCheckBoxes();

            if (serviceOrder == null)
            {
                this.Text = "Nowa naprawa";
            }
            else
            {
                this.Text = "Edycja naprawy";
                serviceIdTxt.Text = serviceOrder.ServiceOrderId.ToString();

                int idx = customerComboBox.FindString(serviceOrder.Customer.ToString());
                customerComboBox.SelectedIndex = idx;

                await fillCustomerDeviceCombo((Customer)customerComboBox.SelectedItem);
                idx = deviceComboBox.FindString(serviceOrder.Device.ToString());
                deviceComboBox.SelectedIndex = idx;

                var q = serviceOrder.ServiceOrders_ServiceStatuses.First();
                idx = serviceStatusComboBox.FindString(q.ServiceStatus.Name);
                serviceStatusComboBox.SelectedIndex = idx;

                startDateTime.Value = serviceOrder.OpenDate;
                endDateTime.Value = serviceOrder.CloseDate == null ? serviceOrder.OpenDate.AddDays(14) : (DateTime)serviceOrder.CloseDate;

                idx = userComboBox.FindString(serviceOrder.User.ToString());
                userComboBox.SelectedIndex = idx;

                descriptionTxt.Text = serviceOrder.Description;

                selectServiceTypesCheckBoxes(serviceOrder.ServiceOrders_ServiceTypes);
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
                    MetroCheckBox ctrl = Controls.Find(name, false)[0] as MetroCheckBox;
                    if (reloadNames)
                    {
                        ctrl.Text = l.Name;
                        ctrl.Tag = l;
                        serviceTypesDict.Add(l.ServiceTypeId, name);
                        ctrl.Enabled = false;

                    }
                    if (serviceStatusComboBox.SelectedIndex > 0 &&
                        serviceStatusComboBox.SelectedIndex < 4)
                    {
                        ctrl.Enabled = true;
                    }
                    else
                    {
                        ctrl.Enabled = false;
                    }
                        i++;
                }
                catch
                {
                    //save log
                }
            }
        }
        private void selectServiceTypesCheckBoxes(ICollection<ServiceOrders_ServiceTypes> collection)
        {
            foreach (var c in collection)
            {
                string value;
                serviceTypesDict.TryGetValue(c.ServiceTypeId, out value);
                MetroCheckBox ctrl = Controls.Find(value, false)[0] as MetroCheckBox;
                if (c.ServiceTypeId == 8)
                {
                    hoursQtyTxt.Text = serviceOrder.ServiceOrders_ServiceTypes
                        .Where(x => x.ServiceOrderId == serviceOrder.ServiceOrderId && x.ServiceTypeId == 8)
                        .Sum(x => x.Hours)
                        .ToString();
                }
                ctrl.Checked = true;
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
        private async Task fillCustomerCombo()
        {            
            var custList = await CustomersControlHelpers.GetCustomersAsync();
            customerComboBox.Items.Clear();
            foreach (var c in custList)
            {
               customerComboBox.Items.Add(c);
            }
            
        }
        private async Task fillCustomerDeviceCombo(Customer cust)
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
        private List<ServiceOrders_ServiceTypes> getSelectedServiceOrder_ServiceTypes()
        {
            List<ServiceOrders_ServiceTypes> list = new List<ServiceOrders_ServiceTypes>();
            for (int i=1; i<9; i++)
            {
                try
                {
                    string name = "metroCheckBox" + i;
                    MetroCheckBox ctrl = Controls.Find(name, false)[0] as MetroCheckBox;
                    
                    if (ctrl.Checked)
                    {
                        if (i == 8)
                        {
                            list.Add(new ServiceOrders_ServiceTypes(serviceOrder.ServiceOrderId, ((ServiceType)ctrl.Tag).ServiceTypeId, Convert.ToDecimal(hoursQtyTxt.Text)));
                            break;
                        }
                        list.Add(new ServiceOrders_ServiceTypes(serviceOrder.ServiceOrderId, ((ServiceType)ctrl.Tag).ServiceTypeId, null));
                    }
                }
                catch
                {
                    //save log
                }
            }
            return list;
        }
        private async void saveBtn_Click(object sender, EventArgs e)
        {            
            bool result;
            if (!validateFields())
            {
                return;
            }
            
            if (serviceOrder == null)
            {
                passServiceDetails();
            }
            if (serviceOrder.ServiceOrderId > 0)
            {
                passServiceDetails();
                try
                {
                    serviceOrder.ServiceOrders_ServiceTypes = getSelectedServiceOrder_ServiceTypes();
                    bool hasChanges = await servicesControlHelpers.HasChanges();
                }
                catch (NoServiceDataChangesException)
                {
                    MetroMessageBox.Show(this, "Nie dokonano zmian danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
                result = await servicesControlHelpers.UpdateAsync(getSelectedServiceOrder_ServiceTypes());
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd aktualizacji danych", "Brak zmian", MessageBoxButtons.OK);
                }
            }
            else
            {
                result = await servicesControlHelpers.SaveAsync();
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd zapisu danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void passServiceDetails()
        {
            CurrentUser currentUser = CurrentUser.GetInstance();
            servicesControlHelpers.ServiceOrder = serviceOrder;
            servicesControlHelpers.ServiceOrder.ServiceOrders_ServiceStatuses = serviceOrder.ServiceOrders_ServiceStatuses;

            servicesControlHelpers.ServiceOrder.CustomerId = ((Customer)customerComboBox.SelectedItem).CustomerId;
            servicesControlHelpers.ServiceOrder.DeviceId = ((Device)deviceComboBox.SelectedItem).DeviceId;
            servicesControlHelpers.ServiceOrder.OpenDate = startDateTime.Value;
            servicesControlHelpers.ServiceOrder.CloseDate = endDateTime.Value;
            servicesControlHelpers.ServiceOrder.Description = descriptionTxt.Text;
            servicesControlHelpers.ServiceOrder.UserId = ((User)userComboBox.SelectedItem).UserId;
            servicesControlHelpers.ServiceOrder.ServiceOrders_ServiceStatuses.FirstOrDefault().ServiceStatusId = ((ServiceStatus)serviceStatusComboBox.SelectedItem).ServiceStatusId;
            servicesControlHelpers.ServiceOrder.ServiceOrders_ServiceStatuses.FirstOrDefault().UserId = currentUser.UserId;
        }
        private bool validateFields()
        {
            
            if (customerComboBox.SelectedIndex == -1 ||
                deviceComboBox.SelectedIndex == -1 ||
                userComboBox.SelectedIndex == -1 ||
                serviceStatusComboBox.SelectedIndex == -1 ||
                (metroCheckBox8.Checked && hoursQtyTxt.Text == String.Empty)
                )
            {
                MetroMessageBox.Show(this, "Nie wszystkie pola wymagane są wypełnione", "Wypełnij wymagane pola", MessageBoxButtons.OK);
                return false;
            }
            
            return true;            
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
            inventNoTxt.Text = string.Empty;
        }
        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddEditCustomerForm form = new AddEditCustomerForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                fillCustomerCombo();
            }
        }
        private async void addDeviceBtn_Click(object sender, EventArgs e)
        {
            AddEditDeviceForm form = new AddEditDeviceForm();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                if (customerComboBox.SelectedIndex > -1)
                {
                    await fillCustomerDeviceCombo((Customer)customerComboBox.SelectedItem);
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
            try
            {
                fillServiceTypesCheckBoxes(false);
            }
            catch (Exception ex)
            { }
        }
        private async void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {            
            try
            {
                await fillCustomerDeviceCombo((Customer)customerComboBox.SelectedItem);
            }
            catch (Exception ex)
            { }
        }
        private void deviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                inventNoTxt.Text = ((Device)(deviceComboBox.SelectedItem)).InventNo.ToString();
            }
            catch(Exception ex)
            { }
        }
        #endregion

        
    }
}
