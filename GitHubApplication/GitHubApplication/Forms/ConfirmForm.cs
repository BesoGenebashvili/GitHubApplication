using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubApplication.Forms
{
    public partial class ConfirmForm : Form
    {
        public bool ConfirmStatus { get; set; }
        public string ConfirmCode { get; set; }

        public ConfirmForm(string confirmcode)
        {
            InitializeComponent();
            ConfirmCode = confirmcode;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (ConfirmCode == ConfirmTextBox.Text)
            {
                ConfirmStatus = true;
                this.Close();
            }
            else
            {
                ConfirmStatus = false;
                this.Close();
            }
        }
    }
}
