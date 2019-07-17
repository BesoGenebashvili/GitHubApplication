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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void topButtons_MouseHover(object sender, EventArgs e)
        {
            PictureBox senderPicBox = (sender as PictureBox);
            senderPicBox.BackColor = Color.FromKnownColor(KnownColor.DimGray);

        }
        private void topButtons_MouseLeave(object sender, EventArgs e)
        {
            PictureBox senderPicBox = (sender as PictureBox);
            senderPicBox.BackColor = Color.Transparent;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
