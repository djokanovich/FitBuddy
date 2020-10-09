using System.Threading;

namespace FitBuddy.WinForms.UI.Security
{
    public static class IdentityManager
    {
        static IdentityManager()
        {
            Thread.CurrentPrincipal = new CustomPrincipal();
        }

        public static CustomIdentity UsuarioActual => ObternerPrincipal.Identity;

        public static void IniciarSesionUsuario(int userId, string username, string[] roles)
        {
            ObternerPrincipal.Identity = new CustomIdentity(userId, username, roles);
        }

        public static void CerrarSesionUsuario()
        {
            ObternerPrincipal.Identity = new AnonymousIdentity();
        }

        public static bool HayUsuarioLogueado()
        {
            return ObternerPrincipal.Identity.UserId != 0 &&
                !string.IsNullOrWhiteSpace(ObternerPrincipal.Identity.Username);
        }

        private static CustomPrincipal ObternerPrincipal => Thread.CurrentPrincipal as CustomPrincipal;
    }
}
