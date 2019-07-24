using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GitHub.Core.Models;
using GitHub.Core.Services.Abstractions;
using System.IO;
using GitHubApplication.Common;

namespace GitHubApplication.Controls
{
    public partial class UserRoomControl : UserControl
    {
        private User _User;
        public User User
        {
            get => _User;
            set
            {
                _User = value;
            }
        }
        private readonly IUserManager userManager;

        public UserRoomControl(IUserManager userManager, User user)
        {
            InitializeComponent();
            this.userManager = userManager;
            User = user;
            LoadInformation(user);
        }

      
        private void UploadPictureBox_Click(object sender, EventArgs e)
        {
            ChangeLogo();
        }

        private void ChangeLogo()
        {
            OpenFileDialog OpenIMage = new OpenFileDialog();
            OpenIMage.Filter = "image files (*.jpg, *.jpeg,*.png)|*.jpg; *.jpeg;*.png";
            OpenIMage.InitialDirectory = @"C:\";
            OpenIMage.Title = "Please select an image file to encrypt.";

            if (OpenIMage.ShowDialog() == DialogResult.OK)
            {
                File.Copy(OpenIMage.FileName, "../../Assets/UserImage" + Path.GetExtension(OpenIMage.FileName),true);
                User.ProfileImage = "../../Assets/UserImage" + Path.GetExtension(OpenIMage.FileName);
                DefaultUserImagePictureBox.Load(User.ProfileImage);
            }
        }

      

        private void SavePictureBox_Click(object sender, EventArgs e)
        {
            User changeduser = SaveChanges();
            if (changeduser == null) return;
            CustomBox.Message("information updated successfully");
            LoadInformation(changeduser);
        }

        private User SaveChanges()
        {
            User TempUser = new User
            {
                Id = User.Id,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Location = User.Location,
                Bio = AboutMeTextBox.Text,
                Interest = InterestTextBox.Text,
                UserName = User.UserName,
                Email = User.Email,
                Password = User.Password,
                ProfileImage = User.ProfileImage,
            };
            userManager.DeactivateUser(User);
           return  userManager.RegisterUser(TempUser);
        }
        private void LoadInformation(User user)
        {
            NameTextBox.Text = user.Name;
            LastNameTextBox.Text = user.LastName;
            InterestTextBox.Text = user.Interest;
            AboutMeTextBox.Text = user.Bio;
            FullNameLabel.Text = user.Name + " " + user.LastName;
            InteresteLabel.Text = user.Interest;
            UserImagePictureBox.Load(user.ProfileImage);
        }
    }
}
