using System.Drawing;
using System.Windows.Forms;

namespace GitHubApplication.Common
{
    public class CustomLabel : Label
    {
        private bool _IsActive { get; set; }
        public bool IsActive
        {
            get => _IsActive;
            set
            {
                _IsActive = value;

                if (value)
                {
                    ForeColor = ActiveColor;

                }
                else
                {
                    ForeColor = DefaultColor;
                }
            }
        }

        private Color DefaultColor { get; } = Color.FromArgb(94, 94, 94);
        private Color ActiveColor { get; } = Color.Gray;
        private new Color ForeColor { get; set; }
    }
}