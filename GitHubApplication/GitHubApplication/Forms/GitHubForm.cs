using Unity;
using System;
using System.Linq;
using System.Drawing;
using GitHub.Core.Models;
using System.Windows.Forms;
using System.Threading.Tasks;
using GitHubApplication.Common;
using GitHubApplication.Controls;
using GitHub.Core.Services.Abstractions;

namespace GitHubApplication
{
    public partial class GitHubForm : Form
    {
        private readonly IUserManager UserService;
        private readonly IGitHubApiService GitHubService;
        private readonly SearchLanguageCategoriesControl[] LanguageComboBoxControls;

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

            // შესაცვლელია
            LanguageComboBoxControls = new SearchLanguageCategoriesControl[]
            {
                new SearchLanguageCategoriesControl("C",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("C++",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("C#",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("Java",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("Python",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("Swift",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("JavaScript",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("PHP",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("HTML",LanguageButtonClickHandler),
                new SearchLanguageCategoriesControl("CSS",LanguageButtonClickHandler)
            };

            LanguageComboBoxPanel.Controls.AddRange(LanguageComboBoxControls);
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

        // ცოტა შესაცვლელია
        private void LanguageButtonClickHandler(object sender, string languageName)
        {
            ChooseLanguageButton.Text = languageName;
            LanguageChoosen = true;
            LanguageComboBoxPanel.Visible = false;
        }

        private bool LanguageChoosen = false; // ესეც შესაცვლელია.
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = true;
            UserRoomPanel.Visible = false;
            ComparisonPanel.Visible = false;
            if (MainPanel.Controls.Count > 0)
                MainPanel.Controls.Clear();

            if (!string.IsNullOrEmpty(SearchForRepositoryesTextBox.Text) && LanguageChoosen)
            {
                var repositories = await GitHubService.SearchForRepositories(ChooseLanguageButton.Text, default(DateTime), SearchForRepositoryesTextBox.Text);
                var controls = await GetRepositoryControls(repositories);
                MainPanel.Controls.AddRange(controls);
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

        // ამას არ ვიყენებთ მარა იყოს.
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

        private void ComparisionRepositoriesButton_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            UserRoomPanel.Visible = false;
            ComparisonPanel.Visible = true;
            ComparisonPanel.Controls.Add(new RepositoriesComparisonControl(GitHubService));
        }

        private void ChooseLanguageButton_Click(object sender, EventArgs e)
        {
            LanguageComboBoxPanel.Visible = !LanguageComboBoxPanel.Visible;
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

        private void UserPictureBox_Click(object sender, EventArgs e)
        {
            MainPanel.Visible = false;
            ComparisonPanel.Visible = false;
            UserRoomPanel.Visible = true;
            UserRoomPanel.Controls.Add(new UserRoomControl(UserService, User));
        }
    }
}