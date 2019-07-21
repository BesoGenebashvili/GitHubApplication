using System.Windows.Forms;
using GitHubApplication.Models;

namespace GitHubApplication
{
    public partial class DeveloperControl : UserControl
    {
        private User _Developer;

        public User Developer
        {
            get => _Developer;
            set
            {
                _Developer = value;

                UserNameLabel.Text = value.UserName;
                NameLabel.Text = value.Name;
                BioLabel.Text = value.Bio;
                LocationLabel.Text = value.Location;
                EmailLabel.Text = value.Email;
            }
        }

        public DeveloperControl(User developer)
        {
            InitializeComponent();

            Developer = developer;
        }
    }
}