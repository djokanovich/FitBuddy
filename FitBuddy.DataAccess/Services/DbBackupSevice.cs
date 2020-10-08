using System.Data.Entity;

namespace FitBuddy.DataAccess.Services
{
    public interface IDbBackupSevice
    {
        bool EsCrearBackupExitoso(string path);
    }

    public class DbBackupSevice : IDbBackupSevice
    {
        private readonly AppDbContext _dbContext;

        public DbBackupSevice(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool EsCrearBackupExitoso(string path)
        {
            var database = _dbContext.Database.Connection.Database;
            var resultado = _dbContext.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                $"BACKUP DATABASE [{database}] TO DISK = '{path}'");
            return resultado == 0;
        }
    }
}
