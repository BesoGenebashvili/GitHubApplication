using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHubApplication.Common;

namespace GitHubApplication
{
    public partial class LoginForm : Form
    {
        private readonly Validator Validator;
        private readonly Dictionary<Label, TextBox> LabelTextBoxPairs;

        public LoginForm()
        {
            InitializeComponent();

            Validator = new Validator(UserNameLabel.ForeColor);
            LabelTextBoxPairs = new Dictionary<Label, TextBox>()
            {
                [UserNameLabel] = UserNameTextBox,
                [PasswordLabel] = PasswordTextBox
            };
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(Validator.ValidateTextBoxes(LabelTextBoxPairs))
            {
                SignInUser();
            }
        }

        private void SignInUser()
        {
            // 
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void TopButtons_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox topButtonPictureBox)
            {
                topButtonPictureBox.BackColor = Color.FromKnownColor(KnownColor.DimGray);
            }
        }

        private void TopButtons_MouseLeave(object sender, EventArgs e)
        {
            if (sender is PictureBox topButtonPictureBox)
            {
                topButtonPictureBox.BackColor = Color.Transparent;
            }
        }

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void CloseButton_Click(object sender, EventArgs e) => Close();

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            Validator.ValidateTextBoxes(LabelTextBoxPairs);
        }
    }
}