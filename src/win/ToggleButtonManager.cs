using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorSID
{
    public static class ToggleButtonManager
    {
        public static void ChangeToggleButtonState(this Button button)
        {
            if (((bool?)button.Tag ?? false) == true)
                button.Tag = false;
            else
                button.Tag = true;
            SetToggleButtonBackground(button);
        }

        public static void SetToggleButtonBackground(this Button button)
        {
            if (button.Enabled == false)
                button.BackgroundImage = Properties.Resources.toggle_button_small_disabled;
            else
                button.BackgroundImage = ((bool?)button.Tag ?? false) ? Properties.Resources.toggle_button_small_on : button.BackgroundImage = Properties.Resources.toggle_button_small_off;
        }

        public static void SetValue(this Button button, bool value)
        {
            button.Tag = value;
            button.SetToggleButtonBackground();
        }

        public static bool GetValue(this Button button)
        {
            return (bool?)button.Tag ?? false;
        }
    }
}
