using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorio
{
   public class UsuarioDAL
    {
        public IEnumerable<Usuario> ObtenerUsuarios()
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarios = dbContext.Usuarios.ToList();
                return usuarios;
            }
        }

        public Usuario ObtenerUsuario(int id)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuario = dbContext.Usuarios.SingleOrDefault(u => u.Id == id);
                return usuario;
            }
        }

        public Usuario CrearUsuario(Usuario usuario)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarioNuevo = dbContext.Usuarios.Add(usuario);
                return usuarioNuevo;
            }
        }

        public Usuario ActualizarUsuario(Usuario usuario)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarioActualizado = dbContext.Usuarios.SingleOrDefault(u => u.Id == usuario.Id);
                usuarioActualizado.Apellido = usuario.Apellido;
                usuarioActualizado.Nombre = usuario.Nombre;
                usuarioActualizado.Username = usuario.Username;
                usuarioActualizado.Password = usuario.Password;
                usuarioActualizado.IdIdioma = usuario.IdIdioma;

                return usuarioActualizado;
            }
        }

        public Usuario EliminarUsuario(Usuario usuario)
        {
            using (var dbContext = new AppDbContext())
            {
                var usuarioEliminado = dbContext.Usuarios.Remove(usuario);
                return usuarioEliminado;
            }
        }

        public int GuardarCambios()
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.SaveChanges();
            }
        }
    }
}
