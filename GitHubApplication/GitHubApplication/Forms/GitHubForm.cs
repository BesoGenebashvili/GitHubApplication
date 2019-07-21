using GitHubApplication.Common;
using GitHubApplication.Models;
using GitHubApplication.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace GitHubApplication
{
    public partial class GitHubForm : Form
    {
        private readonly IUserService UserService;

        private User _User;
        public User User
        {
            get => _User;
            set
            {
                // ვავსებთ შესული მომხმარებლის ინფორმაციით ლეიბლებს.
                _User = value;
            }
        }

        public GitHubForm(IUserService userService)
        {
            InitializeComponent();

            UserService = userService;
        }

        private void GitHubForm_Load(object sender, EventArgs e)
        {
            var loginFrom = ServiceManager.Instance.Container.Resolve<LoginForm>();
            loginFrom.SuccessfullyLogged += SuccessfullyLoggedHandler;

            if (loginFrom.ShowDialog() == DialogResult.Cancel)
            {
                Close();
                return;
            }
            else
            {
                // თუ რამე უნდა ჩაიტვირთოს ავტომატურად შესვლისთანავე ვტვირთავთ აქ.
            }
        }

        public void SuccessfullyLoggedHandler(object sender, User user)
        {
            User = UserService.FindUser(user.UserName);

            if (sender is LoginForm loginForm)
                loginForm.SuccessfullyLogged -= SuccessfullyLoggedHandler;
        }

        private void MinimizeButton_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void CloseButton_Click(object sender, EventArgs e) => Close();

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
    }
}
