using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Windows.Forms;
using Worksite.Classes.EntityHelpers;
using Worksite.Exceptions;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class AddEditCustomerForm : MetroForm
    {
        CustomersControlHelpers customersControlHelpers = new CustomersControlHelpers();
        public AddEditCustomerForm(Customer customer = null)
        {
            InitializeComponent();
            customersControlHelpers.Customer = customer;
            initializeControlsContent();
        }

        private void initializeControlsContent()
        {
            if (customersControlHelpers.Customer == null)
            {
                this.Text = "Nowy klient";
            }
            else
            {
                this.Text = "Edycja klienta";
                firstNameTxt.Text = customersControlHelpers.Customer.FirstName;
                lastNameTxt.Text = customersControlHelpers.Customer.LastName;
                companyTxt.Text = customersControlHelpers.Customer.CompanyName;
                phoneTxt.Text = customersControlHelpers.Customer.PhoneNo;
                emailTxt.Text = customersControlHelpers.Customer.Email;
                descriptionTxt.Text = customersControlHelpers.Customer.Description;
            }
        }               
        private async void saveBtn_Click(object sender, EventArgs e)
        {
            bool result;
            if (!validateFields())
            {
                return;
            }
            if (customersControlHelpers.Customer == null)
            {
                customersControlHelpers.Customer = new Customer();
                passCustomerDetails();
            }
            if (customersControlHelpers.Customer.CustomerId > 0)
            {
                passCustomerDetails();
                try
                {
                    bool hasChanges = await customersControlHelpers.HasChanges();
                }
                catch (NoCustomerDataChangesException)
                {
                    MetroMessageBox.Show(this, "Nie dokonano zmian danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
                result = await customersControlHelpers.UpdateAsync();
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd aktualizacji danych", "Brak zmian", MessageBoxButtons.OK);
                }
            }
            else
            {
                result = await customersControlHelpers.SaveAsync();
                if (!result)
                {
                    MetroMessageBox.Show(this, "Błąd zapisu danych", "Brak zmian", MessageBoxButtons.OK);
                    return;
                }
            }
            DialogResult = DialogResult.OK;
            Close();
        }
        private void passCustomerDetails()
        {

            customersControlHelpers.Customer.FirstName = firstNameTxt.Text;
            customersControlHelpers.Customer.LastName = lastNameTxt.Text;
            customersControlHelpers.Customer.CompanyName = companyTxt.Text;
            customersControlHelpers.Customer.PhoneNo = phoneTxt.Text;
            customersControlHelpers.Customer.Email = emailTxt.Text;
            customersControlHelpers.Customer.Description = descriptionTxt.Text;
        }
        private bool validateFields()
        {
            if ( firstNameTxt.Text == "" || lastNameTxt.Text == "" || phoneTxt.Text == "")
            {
                MetroMessageBox.Show(this, "Nie wszystkie pola wymagane są wypełnione", "Wypełnij wymagane pola", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTxt.Text = lastNameTxt.Text = companyTxt.Text = phoneTxt.Text = emailTxt.Text = descriptionTxt.Text = String.Empty;
        }
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
