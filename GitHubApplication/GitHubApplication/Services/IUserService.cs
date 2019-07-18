using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IUserService
    {
        User LoginUser(User user);
        User RegisterUser(User user);
        User FindUser(string userName);
        User ChangePassword(User user, string newPassword);
        bool DeactivateUser(User user);
    }
}