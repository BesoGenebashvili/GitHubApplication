using GitHubApplication.Common;
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

        public RegisterForm()
        {
            InitializeComponent();

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
