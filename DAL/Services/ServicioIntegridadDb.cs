using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
    public class ServicioIntegridadDb
    {
        public bool DbTieneIntegridad()
        {
            using (var dbContext = new AppDbContext())
            {
                var dbTieneIntegridad = true;

                foreach (var usuario in dbContext.Usuarios.AsEnumerable())
                {
                    int dvhRecalculado = CodigoDeControl.Luhn(usuario.ConcatenarPropiedades());
                    if (usuario.DVH != dvhRecalculado) 
                    {
                        dbTieneIntegridad = false;
                        break;
                    }
                }

                return dbTieneIntegridad;
            }


        }
    }
}
