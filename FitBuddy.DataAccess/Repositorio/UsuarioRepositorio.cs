using FitBuddy.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IUsuarioRepositorio
    {
        IEnumerable<Usuario> ObtenerUsuarios();
        Usuario ObtenerUsuarioPorId(int id);
        Usuario CrearUsuario(Usuario usuario);
        Usuario ActualizarUsuario(Usuario usuario);
        Usuario EliminarUsuario(Usuario usuario);
        int GuardarCambios();
    }

    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly AppDbContext _dbContext;

        public UsuarioRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            var usuarios = _dbContext.Usuarios.ToList();
            return usuarios;
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            var usuario = _dbContext.Usuarios.SingleOrDefault(u => u.Id == usuarioId);
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
            if (usuarioActualizado != null)
            {
                usuarioActualizado.Apellido = usuario.Apellido;
                usuarioActualizado.Nombre = usuario.Nombre;
                usuarioActualizado.Username = usuario.Username;
                usuarioActualizado.Password = usuario.Password;
                usuarioActualizado.IdIdioma = usuario.IdIdioma;
            }

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
