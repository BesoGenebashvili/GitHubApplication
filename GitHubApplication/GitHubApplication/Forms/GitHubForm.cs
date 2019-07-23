using Unity;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using GitHubApplication.Common;
using System.Threading.Tasks;
using GitHub.Core.Services.Abstractions;
using GitHub.Core.Models;

namespace GitHubApplication
{
    public partial class GitHubForm : Form
    {
        private readonly IUserManager UserService;
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

        public GitHubForm(IGitHubApiService gitHubService, IUserManager userService)
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

        private async void TrendingRepositoriesButton_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.Clear();

            var repositories = await GitHubService.TrendingRepositories();
            var controls = await GetRepositoryControls(repositories);
            MainPanel.Controls.AddRange(controls);
        }

        private async void TrendingDevelopersButton_Click(object sender, EventArgs e)
        {
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.Clear();

            var developers = await GitHubService.TrendingDevelopers();
            var controls = await GetDeveloperControls(developers);
            MainPanel.Controls.AddRange(controls);
        }

        private Task<TControl[]> GetControls<Tsource, TControl>(Tsource[] repositories, Func<Tsource, TControl> creator)  
        {
            return Task.Run(() => repositories.Select(creator).ToArray());
        }

        private Task<RepositoryControl[]> GetRepositoryControls(Repository[] repositories)
        {
            return Task.Run(() => repositories.Select(r => new RepositoryControl(r)).ToArray());
        }

        private Task<DeveloperControl[]> GetDeveloperControls(User[] developers)
        {
            return Task.Run(() => developers.Select(u => new DeveloperControl(u)).ToArray());
        }

        public void SuccessfullyLoggedHandler(object sender, User user)
        {
            User = UserService.FindUser(user.UserName);

            if (sender is LoginForm loginForm)
                loginForm.SuccessfullyLogged -= SuccessfullyLoggedHandler;
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
    }
}