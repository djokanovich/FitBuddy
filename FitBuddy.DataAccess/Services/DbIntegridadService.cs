using FitBuddy.DataAccess.Util;
using System.Linq;

namespace FitBuddy.DataAccess.Services
{
    public interface IDbIntegridadService
    {
        bool DbTieneIntegridad();
    }

    public class DbIntegridadService : IDbIntegridadService
    {
        private readonly AppDbContext _dbContext;

        public DbIntegridadService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool DbTieneIntegridad()
        {
            var dbTieneIntegridad = true;

            var usuarios = _dbContext.Usuarios.AsEnumerable();
            foreach (var usuario in usuarios)
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
