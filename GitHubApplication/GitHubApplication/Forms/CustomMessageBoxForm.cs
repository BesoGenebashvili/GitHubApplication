using System;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            MessageLabel.Text = message;
        }

        public static void Message(string message)
        {
            CustomMessageBox messageBoxForm = new CustomMessageBox(message);
            messageBoxForm.ShowDialog();
        }

        private void OkButton_Click(object sender, EventArgs e) => Close();
    }
}