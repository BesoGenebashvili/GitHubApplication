using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using GitHubApplication.Common;
using GitHubApplication.DataBaseContext;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public class UserServiceDb : IUserService
    {
        private readonly GitHubDataBaseContext DataBase;

        public UserServiceDb(GitHubDataBaseContext dataBase)
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
                catch (Exception)
                {
                    CustomBox.Message("could not be sent");
                    return false;
                }
            });
        }

        public User PasswordRecovery(string userEmail)
        {
            User searchResult = DataBase.Users.FirstOrDefault(u => u.Email == userEmail);

            if (searchResult == null)
                return null;

            SentMailAsync(searchResult, "Password Recovery", $"Your password is - {searchResult.Password}");
            return searchResult;
        }
    }
}