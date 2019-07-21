using Unity;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using GitHubApplication.Models;
using GitHubApplication.Common;
using System.Collections.Generic;
using GitHubApplication.Services;

namespace GitHubApplication
{
    public partial class LoginForm : Form
    {
        private readonly Validator Validator;
        private readonly Dictionary<Label, TextBox> LabelTextBoxPairs;
        private readonly IUserService UserService;
        public event EventHandler<User> SuccessfullyLogged;
        public LoginForm(IUserService userService)
        {
            InitializeComponent();

            UserService = userService;
            Validator = new Validator(UserNameLabel.ForeColor);
            LabelTextBoxPairs = new Dictionary<Label, TextBox>()
            {
                [UserNameLabel] = UserNameTextBox,
                [PasswordLabel] = PasswordTextBox
            };
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (Validator.ValidateTextBoxes(LabelTextBoxPairs))
            {
                User user = new User()
                {
                    UserName = UserNameTextBox.Text,
                    Password = PasswordTextBox.Text
                };
                SignInUser(user);
            }
            else
            {
                UserNameOrPasswordFailLabel.Visible = true;
            }
        }

        private void SignInUser(User user)
        {
            var result = UserService.LoginUser(user);
            if (result != null)
            {
                UserNameOrPasswordFailLabel.Visible = false;
                SuccessfullyLogged?.Invoke(this, result);
                DialogResult = DialogResult.OK;
                Close();
                return;
            }
            else
            {
                UserNameOrPasswordFailLabel.Visible = true;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var registerForm = ServiceManager.Instance.Container.Resolve<RegisterForm>();
            registerForm.SuccessfullyRegistered += SuccessfullyRegisteredHandler;
            registerForm.ShowDialog();
        }

        public void SuccessfullyRegisteredHandler(object sender, User user)
        {
            SignInUser(user);

            if (sender is RegisterForm registerForm)
                registerForm.SuccessfullyRegistered -= SuccessfullyRegisteredHandler;
        }

        private void ForgotYourPasswordButton_Click(object sender, EventArgs e)
        {
            string enteredEmail = CustomBox.Input("Enter your Email");
            if (enteredEmail != null && enteredEmail.Contains('@'))
            {
                if (UserService.PasswordRecovery(enteredEmail))
                {
                    CustomBox.Message($"Password successfully sent to: {enteredEmail}");
                    return;
                }
            }
            CustomBox.Message("Message could not be sent");
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

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            Validator.ValidateTextBoxes(LabelTextBoxPairs);
        }

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }
}