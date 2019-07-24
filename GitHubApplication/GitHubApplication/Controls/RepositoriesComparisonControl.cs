using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using GitHub.Core.Services.Abstractions;
using GitHubApplication.Common;

namespace GitHubApplication.Controls
{
    public partial class RepositoriesComparisonControl : UserControl
    {
        private readonly IGitHubApiService GitHubService;

        public RepositoriesComparisonControl(IGitHubApiService gitHubService)
        {
            InitializeComponent();
            GitHubService = gitHubService;
        }

        enum ClickCounter
        {
            firstClick,
            secondClick,
            thirdClick
        }

        ClickCounter clickCounter = ClickCounter.firstClick;

        private void LanguageClick(object sender, EventArgs e)
        {
            if (sender is Label clickedLanguage)
                CheckLanguageLabel(clickedLanguage);
        }

        private async void ComparisionButton_ClickAsync(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ComparisonLanguageOneLabel.Text) || string.IsNullOrEmpty(ComparisonLanguageTwoLabel.Text))
            {
                CustomBox.Message("Select both languages");
                return;
            }

            LoadAnimation.Visible = true;
            var languageonerepositories = await GitHubService.SearchForRepositories(ComparisonLanguageOneLabel.Text, DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0)));
            var languagetworepositories = await GitHubService.SearchForRepositories(ComparisonLanguageTwoLabel.Text, DateTime.Now.Subtract(new TimeSpan(3, 0, 0, 0)));

            if (languageonerepositories == null || languagetworepositories == null)
                return;

            LoadAnimation.Visible = false;

            RepositorOneCountLabel.Text = languageonerepositories.Length.ToString();
            RepositorTwoCountLabel.Text = languagetworepositories.Length.ToString();
            StarOneCountLabel.Text = languageonerepositories.Sum(x => x.StarCount).ToString();
            StarTwoCountLabel.Text = languagetworepositories.Sum(x => x.StarCount).ToString();
            ForkOneCountLabel.Text = StarOneCountLabel.Text = languageonerepositories.Sum(x => x.ForkCount).ToString();
            ForkTwoCountLabel.Text = StarOneCountLabel.Text = languagetworepositories.Sum(x => x.ForkCount).ToString();
        }
        private void CheckLanguageLabel(Label clickedlabel)
        {
            if (ClickCounter.secondClick == clickCounter)
            {
                if (ComparisonLanguageOneLabel.Text == clickedlabel.Text)
                {
                    ComparisonLanguageOneLabel.Text = "";
                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    LanguageOneColorPictureBox.Image = Properties.Resources.Blankcircle;
                    clickCounter = ClickCounter.firstClick;
                    return;
                }
                else if (ComparisonLanguageTwoLabel.Text == "" && clickedlabel.Text != ComparisonLanguageOneLabel.Text)
                {
                    ComparisonLanguageTwoLabel.Text = clickedlabel.Text;
                    clickedlabel.ForeColor = Color.Gray;
                    LanguageTwoColorpictureBox.Image = LanguageColor.GetColor(ComparisonLanguageTwoLabel.Text);
                    clickCounter = ClickCounter.thirdClick;
                    return;
                }

            }
            if (ClickCounter.firstClick == clickCounter && clickedlabel.Text != ComparisonLanguageTwoLabel.Text)
            {
                ComparisonLanguageOneLabel.Text = clickedlabel.Text;
                clickedlabel.ForeColor = Color.Gray;
                LanguageOneColorPictureBox.Image = LanguageColor.GetColor(ComparisonLanguageOneLabel.Text);
                clickCounter = ClickCounter.secondClick;
                return;
            }
            if (ComparisonLanguageOneLabel.Text == clickedlabel.Text)
            {
                ComparisonLanguageOneLabel.Text = "";
                clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                LanguageOneColorPictureBox.Image = Properties.Resources.Blankcircle;
                clickCounter = ClickCounter.firstClick;
            }
            if (ComparisonLanguageTwoLabel.Text == clickedlabel.Text)
            {
                if (ComparisonLanguageOneLabel.Text == "")
                {
                    ComparisonLanguageTwoLabel.Text = "";
                    LanguageTwoColorpictureBox.Image = Properties.Resources.Blankcircle;

                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    clickCounter = ClickCounter.firstClick;
                }
                else
                {
                    ComparisonLanguageTwoLabel.Text = "";
                    LanguageTwoColorpictureBox.Image = Properties.Resources.Blankcircle;
                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    clickCounter = ClickCounter.secondClick;
                }
            }
        }

    }
}
