using BE;
using DAL.Repositorio;
using DAL.Services;
using FitBuddy.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class gesUsuario
    {
        public Usuario UsuarioAutenticado(string usuario, string password)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(password);

            var usuarioDAL = new UsuarioDAL();
            var usuarioEnBd = usuarioDAL.ObtenerUsuarios()
                .SingleOrDefault(u => u.Username == usuario && u.Password == hashedPassword);

            return usuarioEnBd;
        }

        public int GuardarUsuario(Usuario usuario, string plainTextPassword)
        {
            var hashService = new HashService();
            var hashedPassword = hashService.Hash(plainTextPassword);

            usuario.Password = hashedPassword;

            var usuarioDAL = new UsuarioDAL();
            usuarioDAL.CrearUsuario(usuario);

            return usuarioDAL.GuardarCambios();
        }

        public Usuario ObtenerUsuario(int id)
        {
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            return usuarioDAL.ObtenerUsuario(id);
        }
    }
}
