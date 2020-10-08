using FitBuddy.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IUsuarioDAL
    {
        Usuario ActualizarUsuario(Usuario usuario);
        Usuario CrearUsuario(Usuario usuario);
        Usuario EliminarUsuario(Usuario usuario);
        int GuardarCambios();
        Usuario ObtenerUsuarioPorId(int id);
        IEnumerable<Usuario> ObtenerUsuarios();
    }

    public class UsuarioDAL : IUsuarioDAL
    {
        private readonly AppDbContext _dbContext;

        public UsuarioDAL(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            var usuarios = _dbContext.Usuarios.ToList();
            return usuarios;
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            var usuario = _dbContext.Usuarios.SingleOrDefault(u => u.Id == id);
            return usuario;
        }

        public Usuario CrearUsuario(Usuario usuario)
        {
            var usuarioNuevo = _dbContext.Usuarios.Add(usuario);
            return usuarioNuevo;
        }

        public Usuario ActualizarUsuario(Usuario usuario)
        {
            var usuarioActualizado = _dbContext.Usuarios.SingleOrDefault(u => u.Id == usuario.Id);
            usuarioActualizado.Apellido = usuario.Apellido;
            usuarioActualizado.Nombre = usuario.Nombre;
            usuarioActualizado.Username = usuario.Username;
            usuarioActualizado.Password = usuario.Password;
            usuarioActualizado.IdIdioma = usuario.IdIdioma;

            return usuarioActualizado;
        }

        public Usuario EliminarUsuario(Usuario usuario)
        {
            var usuarioEliminado = _dbContext.Usuarios.Remove(usuario);
            return usuarioEliminado;
        }

        public int GuardarCambios()
        {
            return _dbContext.SaveChanges();
        }
    }
}
