using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

        public bool SentMail(User mail, string subject, string body)
        {
            try
            {
                var fromAddress = new MailAddress("githubapplicationun@gmail.com", "githubapplicationun");
                var toAddress = new MailAddress(mail.Email, "Name");
                const string fromPassword = "githubapplicationun123";

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                    return true;
                }
            }
            catch (Exception)
            {
                Box.MessageBox("could not be sent");
                return false;
            }
        }

        public User RecoveryPassword(string userEmail)
        {
            User us =  DataBase.Users.FirstOrDefault(u => u.UserName.Equals("halamadriddd", StringComparison.CurrentCultureIgnoreCase));
            User searchResult = DataBase.Users.FirstOrDefault(u => u.Email == userEmail);
            if (searchResult == null)
                return null;
            SentMail(searchResult, "Recovery Password", $"Your Passwor is - {searchResult.Password}");
            return searchResult;
        }
    }
}