using System.Data.Entity;
using Common.Bitacora;

namespace FitBuddy.DataAccess.Services
{
    public interface IDbBackupSevice
    {
        bool EsCrearBackupExitoso(string path);
    }

    public class DbBackupSevice : IDbBackupSevice
    {
        private readonly AppDbContext _dbContext;
        private readonly IBitacora<DbBackupSevice> _bitacora;

        public DbBackupSevice(AppDbContext dbContext, IBitacora<DbBackupSevice> bitacora)
        {
            _dbContext = dbContext;
            _bitacora = bitacora;
        }

        public bool EsCrearBackupExitoso(string path)
        {
            var database = _dbContext.Database.Connection.Database;
            var sqlQuery = $"BACKUP DATABASE [{database}] TO DISK = '{path}'";
            var resultado = _dbContext.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlQuery);

            _bitacora.Debug($"Se ejecutó la sentencia SQL '{sqlQuery}' que devolvió el resultado {resultado}.");
            
            return resultado == 0;
        }
    }
}
