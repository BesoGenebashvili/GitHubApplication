using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubApplication.Common
{
    class LanguageColor
    {
        static Dictionary<string, Bitmap> LanguageColorPairs = new Dictionary<string, Bitmap>()
        {
            { "Python", Properties.Resources.Python},
            { "Java", Properties.Resources.Java },
            { "JavaScript", Properties.Resources.JavaScript },
            { "HTML", Properties.Resources.Html },
            { "CSS", Properties.Resources.Css },
            { "PHP", Properties.Resources.Php },
            { "C", Properties.Resources.C },
            { "C++", Properties.Resources.CPlusPlus },
            { "C#", Properties.Resources.C_Sharp },
            { "Swift", Properties.Resources.Swift },
        };
        public static Bitmap GetColor(string languageName) => LanguageColorPairs[languageName];
    }
}
