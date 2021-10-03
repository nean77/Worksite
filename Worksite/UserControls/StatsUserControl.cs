using System;
using System.Windows.Forms;
using MetroFramework.Controls;
using Worksite.UserControls.Helpers;
using Worksite.Forms;
using MetroFramework;

namespace Worksite.UserControls
{
    public partial class StatsUserControl : MetroUserControl
    {
        StatsControlHelpers helpers = new StatsControlHelpers();
        public  StatsUserControl()
        {
            InitializeComponent();
            FillData();
        }
        private async void FillData()
        {
            int servicesCount = await helpers.GetServicesCountAsync();
            allServicesCountTail.Text = $"{servicesCount} wykonanych serwisów";

            int openServicesCount = await helpers.GetOpenServicesCountAsync();
            openServicesCountTail.Text = $"{openServicesCount} otwartych serwisów";

            int expiredServicesCount = await helpers.GetExpiresServicesCountAsync();
            expiredServicesCountTile.Text = $"{expiredServicesCount} przedawnionych serwisów";

            decimal totalServicesPrice = await helpers.GetTotalServicesPriceAsync();
            totalServicesPriceTail.Text = $"Wycena wszystkich serwisów: {totalServicesPrice} zł";
            avgServicePriceTail.Text = $"Średnia cena serwisu: {totalServicesPrice / servicesCount} zł/serwis";

            var userStatsList = await helpers.GetUsersStatsAsync();
            foreach(var u in userStatsList)
            {
                userStatsSummaryGrid.Rows.Add(u[0], u[1], u[2]);
            }
        }

    }
}
