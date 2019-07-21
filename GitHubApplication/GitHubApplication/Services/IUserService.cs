using System.Threading.Tasks;
using GitHubApplication.Models;

namespace GitHubApplication.Services
{
    public interface IUserService
    {
        User LoginUser(User user);
        User RegisterUser(User user);
        User FindUser(string userName);
        User ChangePassword(User user, string newPassword);
        bool PasswordRecovery(string userEmail);
        bool DeactivateUser(User user);
        Task<bool> SentMailAsync(User mail, string subject, string body);
    }
}