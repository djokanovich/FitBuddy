using System.Linq;
using System.Windows.Forms;

namespace FitBuddy.WinForms.UI.ExtensionMethods
{
    internal static class ControlExtensionMethods
    {
        public static void FormatearControl(this Control control, params string[] formato)
        {
            control.Text = string.Format(control.Text, formato);
        }

        public static void FormatearControl(this Control control, int index, params string[] formato)
        {
            var s = control.Text.Split('|')[index];

            if (formato.Any())
                control.Text = string.Format(s, formato);
            else
                control.Text = s;
        }
    }
}
