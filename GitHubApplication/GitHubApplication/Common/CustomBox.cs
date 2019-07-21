using GitHubApplication.Forms;

namespace GitHubApplication.Common
{
    public class CustomBox
    {
        public static string Input(string text = "")
        {
            return CustomInputBox.InputBox(text);
        }

        public static void Message(string message)
        {
            CustomMessageBox.Message(message);
        }
    }
}