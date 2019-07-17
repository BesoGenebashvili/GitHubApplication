using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}