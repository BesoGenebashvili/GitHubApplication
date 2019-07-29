using System;
using System.Windows.Forms;
using GitHub.Core.Models;
using GitHub.Core.Services.Abstractions;
using System.IO;
using GitHubApplication.Common;
using System.Threading.Tasks;

namespace GitHubApplication.Controls
{
    public partial class UserRoomControl : UserControl
    {
        private readonly IUserManager UserManager;
        public event EventHandler<User> UserDeactivated;

        private User _User;
        public User User
        {
            get => _User;
            set
            {
                _User = value;
                UpdateUserInfo = value;
            }
        }

        private User UpdateUserInfo
        {
            set
            {
                NameTextBox.Text = value.Name;
                LastNameTextBox.Text = value.LastName;
                InteresteLabel.Text = value.Interest;
                InterestTextBox.Text = value.Interest;
                BioTextBox.Text = value.Bio;
                FullNameLabel.Text = value.Name + " " + value.LastName;

                if (!string.IsNullOrWhiteSpace(value.Image))
                    UserImagePictureBox.Load(value.Image);
            }
        }

        public UserRoomControl(IUserManager userManager, User user)
        {
            InitializeComponent();

            UserManager = userManager;
            User = user;
        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            try
            {
                UploadImage();
            }
            catch
            {
                CustomBox.Message($"something went wrong.");
            }
        }

        private async void UploadImage()
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "image files (*.jpg, *.jpeg,*.png)|*.jpg; *.jpeg;*.png";
                fileDialog.InitialDirectory = @"C:\";
                fileDialog.Title = "Please select an image";

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string newImagePath = $"../../Assets/ProfileImage_{Guid.NewGuid()}{Path.GetExtension(fileDialog.FileName)}";
                    File.Copy(fileDialog.FileName, newImagePath, true);

                    UserImagePictureBox.LoadAsync(newImagePath);
                    User.Image = newImagePath;
                }
            }
        }

        public async Task CopyFileAsync(string sourcePath, string destinationPath)
        {
            using (Stream source = File.Open(sourcePath, FileMode.Open))
            {
                using (Stream destination = File.Create(destinationPath))
                {
                    await source.CopyToAsync(destination);
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e) => SaveData();

        private void SaveData()
        {
            User tempUser = new User()
            {
                Id = User.Id,
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                Interest = InterestTextBox.Text,
                Bio = BioTextBox.Text,
                Image = User.Image
            };

            User resultUser = UserManager.EditUser(tempUser);

            if (resultUser != null)
            {
                User = resultUser;
                CustomBox.Message("information updated successfully");
            }

            if (ChangePassword())
                CustomBox.Message("password changed succesfully");

            CurrentPasswordTextBox.Clear();
            NewPasswordTextBox.Clear();
        }

        private bool ChekPassword()
        {
            if (string.IsNullOrWhiteSpace(NewPasswordTextBox.Text))
                return false;

            if (!string.IsNullOrWhiteSpace(CurrentPasswordTextBox.Text))
            {
                if (CurrentPasswordTextBox.Text == User.Password)
                {
                    CurrentPasswordFailedLabel.Visible = false;
                    return true;
                }
                else
                {
                    CurrentPasswordFailedLabel.Visible = true;
                }
            }

            return false;
        }

        private bool ChangePassword()
        {
            if (ChekPassword())
            {
                User resultUser = UserManager.ChangePassword(User, NewPasswordTextBox.Text);
                return resultUser != null;
            }
            return false;
        }

        private void DeactivateProfileButton_Click(object sender, EventArgs e)
        {
            UserDeactivated?.Invoke(this, User);
        }
    }
}