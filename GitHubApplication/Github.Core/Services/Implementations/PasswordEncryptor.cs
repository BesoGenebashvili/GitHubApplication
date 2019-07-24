using Github.Core.Services.Abstractions;
using Eramake;

namespace Github.Core.Services.Implementations
{
    class PasswordEncryptor : IPasswordEncryptor
    {
        public string EncryptPassword(string passwordToEncrypt) => eCryptography.Encrypt(passwordToEncrypt);

        public string DecryptPassword(string passwordToDecrypt) => eCryptography.Decrypt(passwordToDecrypt);
    }
}