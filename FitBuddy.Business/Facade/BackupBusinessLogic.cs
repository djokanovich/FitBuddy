using FitBuddy.DataAccess.Services;

namespace FitBuddy.Business.Facade
{
    public interface IBackupBusinessLogic
    {
        bool EsCrearBackupExitoso(string path);
    }

    public class BackupBusinessLogic : IBackupBusinessLogic
    {
        private readonly IDbBackupSevice _dbBackupSevice;

        public BackupBusinessLogic(IDbBackupSevice dbBackupSevice)
        {
            _dbBackupSevice = dbBackupSevice;
        }

        public bool EsCrearBackupExitoso(string path)
        {
            return _dbBackupSevice.EsCrearBackupExitoso(path);
        }
    }
}
