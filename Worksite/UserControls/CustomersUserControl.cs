using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using Worksite.UserControls.Helpers;
using Worksite.Forms;
using MetroFramework;

namespace Worksite.UserControls
{
    public partial class CustomersUserControl : MetroUserControl
    {
        public CustomersUserControl()
        {
            InitializeComponent();
            fillCustomersGrid();
        }

        private async void fillCustomersGrid()
        {
            var custList = await CustomersControlHelpers.GetCustomersAsync();

            customersGrid.Rows.Clear();
            foreach (var c in custList)
            {
                int insertedRow = customersGrid.Rows.Add(new object[] { c.CustomerId, c.FirstName, c.LastName, c.CompanyName, c.PhoneNo, c.Email, c.Description });
                customersGrid.Rows[insertedRow].Tag = c;
            }
        }
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            AddEditCustomerForm form = new AddEditCustomerForm();
            if (form.ShowDialog(this) == DialogResult.OK)
                fillCustomersGrid();
        }
        private void editCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersGrid.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(this, "Aby edytować zaznacz klienta","Brak rekodru", MessageBoxButtons.OK);
                return;
            }
            AddEditCustomerForm form = new AddEditCustomerForm((Customer)customersGrid.Rows[customersGrid.CurrentCell.RowIndex].Tag);
            if (form.ShowDialog(this) == DialogResult.OK)
                fillCustomersGrid();
        }
    }
}
