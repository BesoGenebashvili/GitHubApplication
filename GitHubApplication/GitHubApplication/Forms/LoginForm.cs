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
using GitHubApplication.Forms;
using GitHubApplication.Models;
using GitHubApplication.Services;
using Unity;

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
            string enteredEmail = CustomBox.Input();
            if (enteredEmail != null && enteredEmail.Contains('@'))
            {
                UserService.PasswordRecovery(enteredEmail);
            }
            CustomBox.Message($"Password successfully sent to : {enteredEmail}");
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