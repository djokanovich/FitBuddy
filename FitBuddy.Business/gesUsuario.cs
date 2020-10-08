using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using FitBuddy.Seguridad;
using System.Linq;

namespace FitBuddy.Business
{
    public class gesUsuario
    {
        private readonly IUsuarioDAL _usuarioDAL;

        public gesUsuario(IUsuarioDAL usuarioDAL)
        {
            _usuarioDAL = usuarioDAL;
        }

        public Usuario UsuarioAutenticado(string usuario, string password)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(password);

            var usuarioEnBd = _usuarioDAL.ObtenerUsuarios()
                .SingleOrDefault(u => u.Username == usuario && u.Password == hashedPassword);

            return usuarioEnBd;
        }

        public int GuardarUsuario(Usuario usuario, string plainTextPassword)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(plainTextPassword);

            usuario.Password = hashedPassword;

            _usuarioDAL.CrearUsuario(usuario);

            return _usuarioDAL.GuardarCambios();
        }

        public Usuario ObtenerUsuario(int id)
        {
            return _usuarioDAL.ObtenerUsuarioPorId(id);
        }
    }
}
