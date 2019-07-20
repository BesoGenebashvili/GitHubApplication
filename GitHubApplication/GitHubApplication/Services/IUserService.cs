using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IUserService
    {
        User LoginUser(User user);
        User RegisterUser(User user);
        User FindUser(string userName);
        User ChangePassword(User user, string newPassword);
        User RecoveryPassword(string userEmail);
        bool DeactivateUser(User user);
        bool SentMail(User mail, string subject, string body);
    }
}