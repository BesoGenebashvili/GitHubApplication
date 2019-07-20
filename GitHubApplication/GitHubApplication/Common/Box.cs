using GitHubApplication.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Common
{
    public class Box
    {
        public static string InputBox()
        {
            return GiInputBoxForm.InputBox();
        }
        public static void MessageBox(string message)
        {
            GitMessageBox.Message(message);
        }
    }
}
