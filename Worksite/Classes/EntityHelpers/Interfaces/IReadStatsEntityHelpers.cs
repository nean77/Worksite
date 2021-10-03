using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Classes.EntityHelpers.Interfaces
{
    public interface IReadStatsEntityHelpers
    {
        Task<int> GetServicesCount();
        Task<int> GetOpenServicesCount();
        Task<int> GetExpiresServicesCount();
        Task<decimal> GetTotalServicesPrice();
        //Task GetAvgServicePrice();
    }
}
