using System;
using System.Net;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using GitHub.Core.Models;
using GitHub.Core.DataBaseContext;
using GitHub.Core.Services.Abstractions;

namespace GitHub.Core.Services.Implementations
{
    public class UserManger : IUserManager
    {
        private readonly GitHubDataBaseContext DataBase;
        private readonly IPasswordEncryptor PasswordEncryptor;

        public UserManger(GitHubDataBaseContext dataBase, IPasswordEncryptor passwordEncryptor)
        {
            DataBase = dataBase;
            PasswordEncryptor = passwordEncryptor;
        }

        public User LoginUser(User user)
        {
            return DataBase.Users.FirstOrDefault(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)
                && PasswordEncryptor.DecryptPassword(u.Password) == user.Password);
        }

        public User RegisterUser(User user)
        {
            if (DataBase.Users.Any(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)
                 && PasswordEncryptor.DecryptPassword(u.Password) == user.Password))
            {
                return null;
            }

            user.Password = PasswordEncryptor.EncryptPassword(user.Password);
            DataBase.Users.Add(user);
            DataBase.SaveChanges();

            //TODO: სატესტოდ. თუ იმ იუზერის პაროლს შევცვლი რომელიც ბაზაში ჩავწერე
            // ლოგინის დროს ბაზიდან წამოიღებს შეცვლილს. ამიტომაც ვაკეთებთ კოპირებას.

            var copiedUser = user.ShallowCopy() as User;
            copiedUser.Password = PasswordEncryptor.DecryptPassword(user.Password);

            return copiedUser;
        }

        public User EditUser(User user)
        {
            var searchResult = DataBase.Users.Find(user.Id);

            if (searchResult == null)
                return null;

            searchResult.Name = user.Name;
            searchResult.LastName = user.LastName;
            searchResult.Bio = user.Bio;
            searchResult.Interest = user.Interest;
            searchResult.Image = user.Image;

            DataBase.SaveChanges();

            return searchResult;
        }

        public User ChangePassword(User user, string newPassword)
        {
            User searchResult = DataBase.Users.Find(user.Id);

            if (searchResult == null)
                return null;

            var encryptedPassword = PasswordEncryptor.EncryptPassword(newPassword);
            searchResult.Password = encryptedPassword;

            DataBase.SaveChanges();
            return searchResult;
        }

        public bool DeactivateUser(User user)
        {
            User searchResult = DataBase.Users.Find(user.Id);

            if (searchResult == null)
                return false;

            DataBase.Remove(searchResult);
            DataBase.SaveChanges();
            return true;
        }

        public User FindUser(string userName)
        {
            return DataBase.Users.FirstOrDefault(u => u.UserName.Equals(userName, StringComparison.CurrentCultureIgnoreCase));
        }

        public Task<bool> SentMailAsync(User user, string subject, string body)
        {
            return Task.Run(() =>
            {
                try
                {
                    var fromAddress = new MailAddress("githubapplicationun@gmail.com", "GitHub Application");
                    var toAddress = new MailAddress(user.Email, "Name");
                    const string fromPassword = "githubapplicationun123";

                    SmtpClient smtpClient = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                    };

                    using (MailMessage mailMessage = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtpClient.Send(mailMessage);
                        return true;
                    }
                }
                catch (Exception) { return false; }
            });
        }

        public bool PasswordRecovery(string userEmail)
        {
            User searchResult = DataBase.Users.FirstOrDefault(u => u.Email == userEmail);

            if (searchResult == null)
                return false;

            var decryptedPassword = PasswordEncryptor.DecryptPassword(searchResult.Password);

            return SentMailAsync(searchResult, "GitHab Application - Password Recovery", $"Your password is - {decryptedPassword}").Result;
        }
    }
}