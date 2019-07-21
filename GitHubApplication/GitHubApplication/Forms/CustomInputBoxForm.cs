using System;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
    public partial class CustomInputBox : Form
    {
        public CustomInputBox()
        {
            InitializeComponent();
        }

        public static string InputBox(string text)
        {
            CustomInputBox confirmForm = new CustomInputBox();

            confirmForm.TextLabel.Text = text;
            confirmForm.TextLabel.Visible = string.IsNullOrWhiteSpace(text) ? false : true;

            confirmForm.ShowDialog();

            if (!string.IsNullOrWhiteSpace(confirmForm.ConfirmTextBox.Text))
                return confirmForm.ConfirmTextBox.Text;

            else
                return null;
        }

        private void OkButton_Click(object sender, EventArgs e) => Close();
    }
}