using System.Windows.Forms;
using GitHub.Core.Models;

namespace GitHubApplication
{
    public partial class RepositoryControl : UserControl
    {
        private Repository _Repository;

        public Repository Repository
        {
            get => _Repository;
            set
            {
                _Repository = value;

                NameLabel.Text = value.Name;
                DescriptionLabel.Text = value.Description;
                LanguageLabel.Text = value.LanguageName;
                StarCountLabel.Text = value.StarCount.ToString();
                ForkCountLabel.Text = value.ForkCount.ToString();
                CreatedDateLabel.Text = value.CreatedDate.ToString("yyyy-MM-dd");
            }
        }

        public RepositoryControl(Repository repository)
        {
            InitializeComponent();

            Repository = repository;
        }
    }
}