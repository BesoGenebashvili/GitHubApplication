using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
     public partial class GitMessageBox : Form
    {
        public GitMessageBox(string message)
        {
            InitializeComponent();
            MessageLabel.Text = message;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void Message(string message)
        {
            GitMessageBox messageBoxForm = new GitMessageBox(message);
            messageBoxForm.ShowDialog();
        }
    }
}
