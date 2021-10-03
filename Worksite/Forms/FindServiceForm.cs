using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.UserControls.Helpers;

namespace Worksite.Forms
{
    public partial class FindServiceForm : MetroForm
    {
        ServicesControlHelpers servicesControlHelpers = new ServicesControlHelpers();
        public FindServiceForm()
        {
            InitializeComponent();
        }

        private async void findBtn_Click(object sender, EventArgs e)
        {
            long servid;
            Int64.TryParse(serviceIdTxt.Text, out servid);
            var so = await ServicesControlHelpers.GetServiceById(servid);

            if (so == null)
            {
                MetroMessageBox.Show(this, "Nie znaleziono naprawy o podanym identyfikatorze");
                return;
            }
            AddEditServiceForm form = new AddEditServiceForm(so);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                MetroMessageBox.Show(this, "Naprawa została zmodyfikowana");
            }
        }
    }
}
