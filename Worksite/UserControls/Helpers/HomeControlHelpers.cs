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
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetUserOpenServices();
        }
        public static async Task<int> GetExpiredServices()
        {
            ReadEntityHepers entityHelpers = new ReadEntityHepers();

            return await entityHelpers.GetUserExpiredServices();
        }
    }
}
