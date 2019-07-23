using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHub.Core.Services.Abstractions;
using GitHub.Core.Models;
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
            firstclic,
            secondclick,
            thirdclick
        }
        ClickCounter clickCounter = ClickCounter.firstclic;

        private void LanguageClick(object sender, EventArgs e)
        {
            Label clickedlabel = (sender as Label);

            CheckLanguageLabel(clickedlabel);
        }

      

        private async void ComparisionButton_ClickAsync(object sender, EventArgs e)
        {
            if (ComparisonLanguageOneLabel.Text == "" || ComparisonLanguageTwoLabel.Text == "")
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
            if (ClickCounter.secondclick == clickCounter)
            {
                if (ComparisonLanguageOneLabel.Text == clickedlabel.Text)
                {
                    ComparisonLanguageOneLabel.Text = "";
                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    LanguageOneColorpictureBox.Image = Properties.Resources.Blankcircle;
                    clickCounter = ClickCounter.firstclic;
                    return;
                }
                else if (ComparisonLanguageTwoLabel.Text == "" && clickedlabel.Text != ComparisonLanguageOneLabel.Text)
                {
                    ComparisonLanguageTwoLabel.Text = clickedlabel.Text;
                    clickedlabel.ForeColor = Color.Gray;
                    LanguageTwoColorpictureBox.Image = LanguageColor.GetColor(ComparisonLanguageTwoLabel.Text);
                    clickCounter = ClickCounter.thirdclick;
                    return;
                }

            }
            if (ClickCounter.firstclic == clickCounter && clickedlabel.Text != ComparisonLanguageTwoLabel.Text)
            {
                ComparisonLanguageOneLabel.Text = clickedlabel.Text;
                clickedlabel.ForeColor = Color.Gray;
                LanguageOneColorpictureBox.Image = LanguageColor.GetColor(ComparisonLanguageOneLabel.Text);
                clickCounter = ClickCounter.secondclick;
                return;
            }
            if (ComparisonLanguageOneLabel.Text == clickedlabel.Text)
            {
                ComparisonLanguageOneLabel.Text = "";
                clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                LanguageOneColorpictureBox.Image = Properties.Resources.Blankcircle;
                clickCounter = ClickCounter.firstclic;
            }
            if (ComparisonLanguageTwoLabel.Text == clickedlabel.Text)
            {
                if (ComparisonLanguageOneLabel.Text == "")
                {
                    ComparisonLanguageTwoLabel.Text = "";
                    LanguageTwoColorpictureBox.Image = Properties.Resources.Blankcircle;

                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    clickCounter = ClickCounter.firstclic;
                }
                else
                {
                    ComparisonLanguageTwoLabel.Text = "";
                    LanguageTwoColorpictureBox.Image = Properties.Resources.Blankcircle;
                    clickedlabel.ForeColor = Color.FromArgb(94, 94, 94);
                    clickCounter = ClickCounter.secondclick;
                }
            }
        }

    }
}
