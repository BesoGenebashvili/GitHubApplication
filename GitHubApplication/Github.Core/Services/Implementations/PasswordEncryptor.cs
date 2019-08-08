using GitHub.Core.Services.Abstractions;
using Eramake;

namespace GitHub.Core.Services.Implementations
{
    public class PasswordEncryptor : IPasswordEncryptor
    {
        public string EncryptPassword(string passwordToEncrypt) => eCryptography.Encrypt(passwordToEncrypt);

        public string DecryptPassword(string passwordToDecrypt) => eCryptography.Decrypt(passwordToDecrypt);
    }
}