using Common.Utilidades;
using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using System.Linq;

namespace FitBuddy.Business.Facade
{
    public interface IUsuarioFacade
    {
        (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword);
        bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainTextPassword);
        Usuario ObtenerUsuario(int id);
    }

    public class UsuarioFacade : IUsuarioFacade
    {
        private readonly IHashService _hashService;
        private readonly IUsuarioRepositorio _usuarioDAL;

        public UsuarioFacade(IHashService hashService, IUsuarioRepositorio usuarioDAL)
        {
            _hashService = hashService;
            _usuarioDAL = usuarioDAL;
        }

        public (Usuario usuario, bool autenticaciónExitosa) AutenticarUsuarioConContraseña(string username, string plainPassword)
        {
            var hashedPassword = _hashService.Hash(plainPassword);

            var usuario = _usuarioDAL.ObtenerUsuarios()
                .SingleOrDefault(u => u.Username == username && u.Password == hashedPassword);

            return (usuario, usuario != null);
        }

        public bool EsUsuarioGuardadoConÉxito(Usuario usuario, string plainPassword)
        {
            var hashedPassword = _hashService.Hash(plainPassword);

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
