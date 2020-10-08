using System.Text.RegularExpressions;

namespace Common.Utilidades.Validators
{
    public interface IPasswordValidator
    {
        int LongitudMínima { get; }
        bool EsContraseñaVálida(string contraseña);
        bool SonContraseñasIguales(string contraseña, string contraseñaRepetida);
    }

    public class PasswordValidator : IPasswordValidator
    {
        public int LongitudMínima => 8; // TODO: ¿Hacer este valor configurable?

        public bool SonContraseñasIguales(string contraseña, string contraseñaRepetida)
        {
            return contraseña == contraseñaRepetida;
        }

        public bool EsContraseñaVálida(string contraseña)
        {
            return CumpleMínimoDeCaracteres(contraseña) &&
                TieneDígitos(contraseña) &&
                TieneMayúscula(contraseña);
        }

        private bool CumpleMínimoDeCaracteres(string contraseña)
        {
            return contraseña.Length >= LongitudMínima;
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
