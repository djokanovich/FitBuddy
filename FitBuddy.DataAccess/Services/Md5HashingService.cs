using System;
using System.Security.Cryptography;
using System.Text;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Services
{
    internal static class Md5HashingService
    {
        public static string CalcularHash(MD5 md5, EntidadBase entidad)
        {
            var entidadKeyBytes = Encoding.ASCII.GetBytes(entidad.Key());
            var hash = md5.ComputeHash(entidadKeyBytes);
            var md5Hash = BitConverter.ToString(hash).Replace("-", "");

            return md5Hash;
        }
    }
}
