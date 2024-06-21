
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Text;

namespace TimeTracerCSharp
{
    static class Password
    {
        public static string generateHash(string username, string password)
        {
            byte[] salt = Encoding.ASCII.GetBytes(username);
            byte[] bytes = KeyDerivation.Pbkdf2(password, salt, KeyDerivationPrf.HMACSHA512, 450000, 49);
            return Convert.ToHexString(bytes);
        }

        public static bool verify(string username, string password, string hash)
        {
            return hash == generateHash(username, password);
        }
    }

}
