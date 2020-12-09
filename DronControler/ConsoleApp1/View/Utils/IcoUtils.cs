
using System.Drawing;
using System.Windows.Forms;

namespace DronApp
{
    public class IcoUtils
    {
        public static Color okColor = ColorTranslator.FromHtml("#A5DF00");
        public static Color autoColor = ColorTranslator.FromHtml("#0066ff");
        public static Color warningColor = ColorTranslator.FromHtml("#FACC2E");
        public static Color errorColor = ColorTranslator.FromHtml("#DF013A");

        public static void setState(PictureBox icon, State state)
        {
            switch (state)
            {
                case State.active:
                    icon.BackColor = okColor;
                    break;
                case State.warning:
                    icon.BackColor = warningColor;
                    break;
                case State.auto:
                    icon.BackColor = autoColor;
                    break;
                case State.error:
                    icon.BackColor = errorColor;
                    break;
            }           
        }
    }

    public enum State
    {
        active,
        auto,
        warning,
        error
    }
}
