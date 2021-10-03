using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class StatsControlHelpers : BaseUserControlHelpers
    {
        public async Task<int> GetServicesCountAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();
            return await helpers.GetServicesCount();
        }
        public async Task<int> GetOpenServicesCountAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();
            return await helpers.GetOpenServicesCount();
        }
        public async Task<int> GetExpiresServicesCountAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();
            return await helpers.GetExpiresServicesCount();
        }
        public async Task<decimal> GetTotalServicesPriceAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();
            return await helpers.GetTotalServicesPrice();
        }
        public async Task<List<string[]>> GetUsersStatsAsync()
        {
            ReadEntityHelpers helpers = new ReadEntityHelpers();
            return await helpers.GetUsersStats();
        }
    }
}
