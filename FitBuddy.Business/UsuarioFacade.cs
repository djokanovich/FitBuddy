using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using FitBuddy.Seguridad;
using System.Linq;

namespace FitBuddy.Business
{
    public interface IUsuarioFacade
    {
        (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword);
        bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainTextPassword);
        Usuario ObtenerUsuario(int id);
    }

    public class UsuarioFacade : IUsuarioFacade
    {
        private readonly IUsuarioRepositorio _usuarioDAL;

        public UsuarioFacade(IUsuarioRepositorio usuarioDAL)
        {
            _usuarioDAL = usuarioDAL;
        }

        public (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(plainPassword);

            var usuario = _usuarioDAL.ObtenerUsuarios()
                .SingleOrDefault(u => u.Username == username && u.Password == hashedPassword);

            return (usuario, usuario != null);
        }

        public bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainPassword)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(plainPassword);

            usuario.Password = hashedPassword;

            _usuarioDAL.CrearUsuario(usuario);

            return _usuarioDAL.GuardarCambios() > 0;
        }

        public Usuario ObtenerUsuario(int id)
        {
            return _usuarioDAL.ObtenerUsuarioPorId(id);
        }
    }
}
