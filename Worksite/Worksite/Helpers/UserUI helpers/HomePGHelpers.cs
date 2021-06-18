using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worksite.Helpers.UserUI_helpers
{
    public class HomePGHelpers
    {
        public static int getUserOpenServices()
        {
            using (WorksiteEntities context = new WorksiteEntities())
            {
                var openServices = context.AllOpenServices
                                    .Count(os => os.UserId == Program.currentUser.UserId);
                return openServices;
            }          
        }
        public static int getUserExpiredServices()
        {
            using (WorksiteEntities context = new WorksiteEntities())
            {
                var openServices = context.AllExpiredServices
                                    .Count(os => os.UserId == Program.currentUser.UserId);
                return openServices;
            }
        }
    }
}
