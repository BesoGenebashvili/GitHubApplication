using GitHubApplication.Common;
using GitHubApplication.Models;
using GitHubApplication.Services;
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
        private readonly Validator Validator;
        private readonly Dictionary<Label, TextBox> LabelTextBoxPairs;
        private readonly IUserService UserService;

        public RegisterForm(IUserService userService)
        {
            InitializeComponent();

            UserService = userService;
            Validator = new Validator(UserNameLabel.ForeColor);
            LabelTextBoxPairs = new Dictionary<Label, TextBox>()
            {
                [UserNameLabel] = UserNameTextBox,
                [EmailLabel] = EmailTextBox,
                [PasswordLabel] = PasswordTextBox,
                [RetypePasswordLabel] = RetypePasswordTextBox
            };
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            // transfer to loginform.
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if(Validator.ValidateTextBoxes(LabelTextBoxPairs))
            {
                SignUpUser();
            }
        }

        private void SignUpUser()
        {
            User user = new User
            {
                UserName = UserNameTextBox.Text,
                Email = EmailTextBox.Text,
                Password = PasswordTextBox.Text,
            };

            User registeredUser = UserService.RegisterUser(user);
            if (registeredUser == null)
            {
                MessageBox.Show("User Registered");
            }
            else
            {
                MessageBox.Show("User successfully registered");
            }
        }
        
        private bool ValidateEmail()
        {
            if (EmailTextBox.Text.Contains('@'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool ValidatePassword()
        {
            if (PasswordTextBox.Text == RetypePasswordTextBox.Text && PasswordTextBox.Text.Length >= 6)
            {
                return true;
            }
            else
            {
                return false;
            }
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
