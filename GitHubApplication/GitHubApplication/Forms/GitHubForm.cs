using Unity;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using GitHubApplication.Common;
using GitHubApplication.Models;
using GitHubApplication.Services;
using System.Threading.Tasks;

namespace GitHubApplication
{
    public partial class GitHubForm : Form
    {
        private readonly IUserService UserService;
        private readonly IGitHubApiService GitHubService;

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

        public GitHubForm(IGitHubApiService gitHubService, IUserService userService)
        {
            InitializeComponent();

            GitHubService = gitHubService;
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

        private void TopRepositoriesButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            Task.Run(() =>
            {
                RepositoryControl[] repositoryControls = GitHubService.TrendingRepositories().Result?
                    .Select(r => new RepositoryControl(r)).ToArray();

                MainPanel.Controls.AddRange(repositoryControls);
            });
        }

        private void TopDevelopersButton_Click(object sender, EventArgs e)
        {

        }
    }
}