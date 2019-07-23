using System;
using System.Net;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using GitHubApplication.Models;
using GitHubApplication.DataBaseContext;
using GitHubApplication.Services.Abstractions;

namespace GitHubApplication.Services.Implementations
{
    public class UserManger : IUserManager
    {
        private readonly GitHubDataBaseContext DataBase;

        public UserManger(GitHubDataBaseContext dataBase)
        {
            DataBase = dataBase;
        }

        public User LoginUser(User user)
        {
            return DataBase.Users.FirstOrDefault(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)
                && u.Password == user.Password);
        }

        public User RegisterUser(User user)
        {
            if (DataBase.Users.Any(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)
                 && u.Password == user.Password))
            {
                return null;
            }

            DataBase.Users.Add(user);
            DataBase.SaveChanges();
            return user;
        }

        public User ChangePassword(User user, string newPassword)
        {
            User searchResult = DataBase.Users.FirstOrDefault(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase));

            if (searchResult == null)
                return null;

            searchResult.Password = newPassword;
            DataBase.SaveChanges();
            return searchResult;
        }

        public bool DeactivateUser(User user)
        {
            User searchResult = DataBase.Users.FirstOrDefault(u => u.UserName.Equals(user.UserName, StringComparison.CurrentCultureIgnoreCase)
                && u.Password == user.Password);

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

            return SentMailAsync(searchResult, "GitHab Application - Password Recovery", $"Your password is - {searchResult.Password}").Result;
        }
    }
}