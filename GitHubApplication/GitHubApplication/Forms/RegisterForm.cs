using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using GitHubApplication.Models;
using GitHubApplication.Common;
using GitHubApplication.Services;

namespace GitHubApplication
{
    public partial class RegisterForm : Form
    {
        private readonly Validator Validator;
        private readonly Dictionary<Label, TextBox> LabelTextBoxPairs;
        private readonly IUserService UserService;
        public event EventHandler<User> SuccessfullyRegistered;

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
            if (Validator.ValidateTextBoxes(LabelTextBoxPairs) & ValidateEmail() & ValidatePassword() & TermsAndPoliciesCheckBox.Checked)
            {
                User user = new User
                {
                    UserName = UserNameTextBox.Text,
                    Email = EmailTextBox.Text,
                    Password = PasswordTextBox.Text,
                };
                SignUpUser(user);
            }
        }

        private void SignUpUser(User newUser)
        {
            if (SentConfirmationCode(newUser))
            {
                User registeredUser = UserService.RegisterUser(newUser);

                if (registeredUser == null)
                    MessageBox.Show("User already registered");

                else
                {
                    SuccessfullyRegistered?.Invoke(this, registeredUser);
                    Close();
                    return;
                }
            }
            else
                foreach (var item in LabelTextBoxPairs) item.Value.Clear();
        }

        private bool SentConfirmationCode(User newUser)
        {
            string confirmationCode = Guid.NewGuid().ToString();

            if (UserService.SentMailAsync(newUser, "GitHab Application - Registration", $"Confirmation code - {confirmationCode}").Result)
            {
                if (CustomBox.Input($"Confirmation code sent to {newUser.Email}") == confirmationCode)
                    return true;

                else
                    CustomBox.Message("Confirmation code is incorrect");
            }
            else
                CustomBox.Message("Message could not be sent");

            return false;
        }

        private bool ValidateEmail()
        {
            if (EmailTextBox.Text.Contains('@'))
            {
                EmailFailedLabel.Visible = false;
                return true;
            }
            else
            {
                EmailFailedLabel.Visible = true;
                return false;
            }
        }

        private bool ValidatePassword()
        {
            if(PasswordTextBox.Text == RetypePasswordTextBox.Text)
            {
                PasswordsFailedLabel.Visible = false;
                return true;
            }
            else
            {
                PasswordsFailedLabel.Visible = true;
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

        private void TextBoxes_TextChanged(object sender, EventArgs e) => Validator.ValidateTextBoxes(LabelTextBoxPairs);

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void CloseButton_Click(object sender, EventArgs e) => Close();
    }
}