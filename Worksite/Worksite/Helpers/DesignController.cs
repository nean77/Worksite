using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.DataModels;
using Worksite.Helpers.UserUI_helpers;
using Worksite.UserControls.CustomersUC;

namespace Worksite.Helpers
{
    public  class DesignController
    {


        CustomersPGHelpers customersPGH = new CustomersPGHelpers();
        public void initUserControls(MainForm form)
        {
            var customerMainUC = new CustomersMainUC();
            form.customersTab.Controls.Add(customerMainUC);
            customerMainUC.Dock = DockStyle.Fill;
            customersPGH.initData();
            fillData(customerMainUC);
        }
        public void fillData(CustomersMainUC customerMainUC)
        {
            customerMainUC.customersDGV.Rows.Clear();
            customerMainUC.customersDGV.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
            foreach (var c in CustomerModel.customersList)
            {
                int insertedRow = customerMainUC.customersDGV.Rows.Add(c.ToObjTbl());
                customerMainUC.customersDGV.Rows[insertedRow].Tag = c;
            }
        }        
    }
}
