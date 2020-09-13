using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class UsuarioDataService

        // métodos de las cosas que uno querría de los usuarios sacado de la base de datos.
        // patrón repository: no consultás directamente a la DB sino que consultas "algo" que facilita la ultilización de los datos.
        // los sp son para ejecutar querys críticass
    {
        public Usuario GetUsuarioByNameAndPassword(string nombre, string password)
        {
            Usuario usuario;
            using (var dbContext = new AppDbContext())
            {
                var lists = dbContext.Usuarios.ToList();
                usuario = lists.SingleOrDefault(u => u.Username == nombre && u.Password == password);
            }

            return usuario;
        }

    }
}
