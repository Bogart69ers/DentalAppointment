using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DentalAppointment.Utils
{
    internal class Func
    {
        public static void ShowResultMessageBox(String msg, ErrorCode code)
        {
            MessageBox.Show(msg, code.ToString(), MessageBoxButtons.OK, (int)code == 1 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }

        public static DialogResult ShowConfirmationPromptMessageBox(String msg, String caption)
        {
            return MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);
        }
    }
}
