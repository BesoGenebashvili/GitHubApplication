using System;
using System.Windows.Forms;
using GitHubApplication.Common;

namespace GitHubApplication.Controls
{
    public partial class SearchLanguageCategoriesControl : UserControl
    {
        public EventHandler<string> LanguageButtonClick;

        public SearchLanguageCategoriesControl(string languageName, EventHandler<string> LanguageButtonClickHandler)
        {
            InitializeComponent();

            LanguageNameButton.Text = languageName;
            LanguageButtonClick += LanguageButtonClickHandler;
            LanguageColorPictureBox.Image = LanguageColor.GetColor(languageName);
        }

        private void LanguageNameButton_Click(object sender, EventArgs e)
        {
            if(sender is Label languageNameButton)
            {
                LanguageButtonClick?.Invoke(this, languageNameButton.Text);
            }
        }
    }
}