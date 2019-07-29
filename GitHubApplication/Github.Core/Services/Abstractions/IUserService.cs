using System.Threading.Tasks;
using GitHub.Core.Models;

namespace GitHub.Core.Services.Abstractions
{
    public interface IUserManager
    {
        User LoginUser(User user);
        User RegisterUser(User user);
        User EditUser(User user);
        User FindUser(string userName);
        User ChangePassword(User user, string newPassword);
        bool PasswordRecovery(string userEmail);
        bool DeactivateUser(User user);
        Task<bool> SentMailAsync(User mail, string subject, string body);
    }
}