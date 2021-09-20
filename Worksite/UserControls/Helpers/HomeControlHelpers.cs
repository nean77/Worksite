using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Worksite.Classes.EntityHelpers;

namespace Worksite.UserControls.Helpers
{
    public class HomeControlHelpers : BaseUserControlHelpers
    {       

        public static async Task<int> GetOpenServices()
        {
            ReadEntityHelpers entityHelpers = new ReadEntityHelpers();

            return await entityHelpers.GetUserOpenServices();
        }
        public static async Task<int> GetExpiredServices()
        {
            ReadEntityHelpers entityHelpers = new ReadEntityHelpers();

            return await entityHelpers.GetUserExpiredServices();
        }
    }
}
