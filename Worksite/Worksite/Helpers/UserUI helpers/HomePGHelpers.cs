using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Helpers.UserUI_helpers
{
    public class HomePGHelpers
    {
        private byte openServices { get; set; }

        public static byte getUserOpenServices()
        {
            using (WorksiteEntities context = new WorksiteEntities())
            {
                //var openServices = context.AllOpenServices
                 //                   .Where(os => os.)

            }

            return 1;

        }
    }
}
