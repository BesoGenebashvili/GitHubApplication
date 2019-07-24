using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHub.Core.Models;
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

        bool ValidateChosenLanguages()
        {
            if (string.IsNullOrEmpty(ComparisonLanguageOneLabel.Text) || string.IsNullOrEmpty(ComparisonLanguageTwoLabel.Text))
            {
                CustomBox.Message("Select both languages");
                return false;
            }
            return true;
        }

        private async void ComparisionButton_ClickAsync(object sender, EventArgs e)
        {
            await CompareChosenLanguages();
        }

        private async Task CompareChosenLanguages()
        {
            if (!ValidateChosenLanguages()) return;

            LoadAnimation.Visible = true;

            var languageRepositories = await Task.WhenAll(
                   GitHubService.SearchForRepositories(ComparisonLanguageOneLabel.Text),
                   GitHubService.SearchForRepositories(ComparisonLanguageTwoLabel.Text));

            LoadAnimation.Visible = false;

            ShowComparison(languageRepositories);
        }

        private void ShowComparison(Repository[][] languageRepositories)
        {
            if (languageRepositories.Length < 2 || languageRepositories.Any(r => r == null)) return;

            RepositorOneCountLabel.Text = languageRepositories[0].Length.ToString();
            RepositorTwoCountLabel.Text = languageRepositories[1].Length.ToString();
            StarOneCountLabel.Text = languageRepositories[0].Sum(x => x.StarCount).ToString();
            StarTwoCountLabel.Text = languageRepositories[1].Sum(x => x.StarCount).ToString();
            ForkOneCountLabel.Text = StarOneCountLabel.Text = languageRepositories[0].Sum(x => x.ForkCount).ToString();
            ForkTwoCountLabel.Text = StarOneCountLabel.Text = languageRepositories[1].Sum(x => x.ForkCount).ToString();
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
