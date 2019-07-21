using GitHubApplication.Forms;

namespace GitHubApplication.Common
{
    public class CustomBox
    {
        public static string Input()
        {
            return CustomInputBox.InputBox();
        }

        public static void Message(string message)
        {
            CustomMessageBox.Message(message);
        }
    }
}