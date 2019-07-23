using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Controls
{
    public partial class RepositoriesComparisonControl : UserControl
    {
        public RepositoriesComparisonControl()
        {
            InitializeComponent();
        }
        bool FirstrClick = true;
        private void LanguageClick(object sender, EventArgs e)
        {
            if (FirstrClick)
            {
                ComparisonLanguageOneLabel.Text = (sender as Label).Text;
                (sender as Label).ForeColor = Color.Gray;
                FirstrClick = false;
            }
            else
            {
                ComparisonLanguageTwoLabel.Text = (sender as Label).Text;
                (sender as Label).ForeColor = Color.Gray;
            }
        }
    }
}
