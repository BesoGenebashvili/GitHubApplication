namespace Github.Core.Services.Abstractions
{
    public interface IPasswordEncryptor
    {
        string EncryptPassword(string passwordToEncrypt);
        string DecryptPassword(string passwordToDecrypt);
    }
}