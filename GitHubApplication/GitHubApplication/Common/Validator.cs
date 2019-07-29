using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GitHubApplication.Common
{
    public class Validator
    {
        private readonly Color DefaultColor;
        private readonly Color AttentionColor;

        public Validator(Color defaultColor, Color attentionColor)
        {
            DefaultColor = defaultColor;
            AttentionColor = attentionColor;
        }

        public bool ValidateTextBoxes(Dictionary<Label, TextBox> LabelTextBoxPairs)
        {
            bool valid = true;
            foreach (var pair in LabelTextBoxPairs)
            {
                valid = ValidatePair(pair) && valid;
            }
            return valid;
        }

        public bool ValidatePair(KeyValuePair<Label, TextBox> LabelTextBoxPair)
        {
            var label = LabelTextBoxPair.Key;
            var textBox = LabelTextBoxPair.Value;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                label.ForeColor = AttentionColor;
                return false;
            }
            else
            {
                label.ForeColor = DefaultColor;
                return true;
            }
        }

    }
}