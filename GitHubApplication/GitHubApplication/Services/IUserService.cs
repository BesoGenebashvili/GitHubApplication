using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IUserService
    {
        User LoginUser(User user);
        User RegisterUser(User user);
        bool ChangePassword(User user, string newPassword);
    }
}