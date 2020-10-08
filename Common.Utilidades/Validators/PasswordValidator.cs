using System.Text.RegularExpressions;

namespace Common.Utilidades.Validators
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
            return CumpleMínimoDeCaracteres(contraseña) &&
                TieneDígitos(contraseña) &&
                TieneMayúscula(contraseña);
        }

        private bool CumpleMínimoDeCaracteres(string contraseña)
        {
            return contraseña.Length >= ContraseñaLongitudMínima;
        }

        private bool TieneDígitos(string contraseña)
        {
            var dígito = new Regex(@"[0-9]");
            var match = dígito.Match(contraseña);
            return match.Success;
        }

        private bool TieneMayúscula(string contraseña)
        {
            var mayúscula = new Regex(@"[A-Z]");
            var match = mayúscula.Match(contraseña);
            return match.Success;
        }
    }
}
