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
    public partial class GiInputBoxForm : Form
    {
        public GiInputBoxForm()
        {
            InitializeComponent();
        }
        public static string InputBox()
        {
            GiInputBoxForm confirmForm = new GiInputBoxForm();
            confirmForm.ShowDialog();
            if (!string.IsNullOrWhiteSpace(confirmForm.ConfirmTextBox.Text))
            {
                return confirmForm.ConfirmTextBox.Text;
            }
            else
            {
                return null;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
