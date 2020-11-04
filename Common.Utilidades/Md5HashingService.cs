using System;
using System.Security.Cryptography;
using System.Text;
using FitBuddy.Entidades;

namespace Common.Utilidades
{
    public interface IMd5HashingService
    {
        string CalcularHash(string toHash);
        string CalcularHashDeEntidadBase(MD5 md5, EntidadBase entidad);
    }

    public class Md5HashingService : IMd5HashingService
    {
        public string CalcularHash(string toHash)
        {
            using (MD5 md5 = MD5.Create())
            {
                return CalcularHash(md5, toHash);
            }
        }

        public string CalcularHashDeEntidadBase(MD5 md5, EntidadBase entidad)
        {
            return CalcularHash(md5, entidad.Key());
        }

        private string CalcularHash(MD5 md5, string toHash)
        {
            var entidadKeyBytes = Encoding.ASCII.GetBytes(toHash);
            var hash = md5.ComputeHash(entidadKeyBytes);
            var md5Hash = BitConverter.ToString(hash).Replace("-", "");

            return md5Hash;
        }
    }
}
