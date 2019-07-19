using System;
using System.Linq;
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

      
    }
}