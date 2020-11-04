using System.Text.RegularExpressions;

namespace FitBuddy.Business.Validators
{
    public interface IPasswordValidator
    {
        int ContraseñaLongitudMínima { get; }
        bool EsContraseñaVálida(string contraseña);
    }

    public class PasswordValidator : IPasswordValidator
    {
        public int ContraseñaLongitudMínima => 8; // TODO: ¿Hacer este valor configurable?

        public bool EsContraseñaVálida(string contraseña)
        {
            var cumpleMínimoDeCaracteres = contraseña.Length >= ContraseñaLongitudMínima;

            var dígito = new Regex(@"[0-9]");
            var tieneDígitos = dígito.Match(contraseña).Success;

            var mayúscula = new Regex(@"[A-Z]");
            var tieneMayúscula = mayúscula.Match(contraseña).Success;

            return cumpleMínimoDeCaracteres &&
                tieneDígitos &&
                tieneMayúscula;
        }
    }
}
