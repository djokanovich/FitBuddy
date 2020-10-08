using System.Security.Cryptography;
using System.Text;

namespace Common.Utilidades
{
    public interface IHashService
    {
        string Hash(string toHash);
    }

    public class HashService : IHashService
    {
        public string Hash(string toHash)
        {
            using (MD5 md5 = MD5.Create())
            {
                var inputBytes = Encoding.ASCII.GetBytes(toHash);
                var hashBytes = md5.ComputeHash(inputBytes);

                var sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; ++i)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
    }
}
