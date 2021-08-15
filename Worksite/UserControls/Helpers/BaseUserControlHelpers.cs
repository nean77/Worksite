using MetroFramework.Controls;
using System.Windows.Forms;

namespace Worksite.UserControls.Helpers
{
    public class BaseUserControlHelpers
    {
        public static void SetUpUserControl(MetroPanel panel, UserControl userControl)
        {
            panel.Controls.Clear();
            panel.Controls.Add(userControl);
        }
    }
}
