using FitBuddy.DataAccess.Services;

namespace FitBuddy.Business
{
    public interface IIntegridadBusinessLogic
    {
        bool DbTieneIntegridad();
    }

    public class IntegridadBusinessLogic : IIntegridadBusinessLogic
    {
        private readonly IDbIntegridadService _dbIntegridadService;

        public IntegridadBusinessLogic(IDbIntegridadService dbIntegridadService)
        {
            _dbIntegridadService = dbIntegridadService;
        }

        public bool DbTieneIntegridad()
        {
            return _dbIntegridadService.DbTieneIntegridad();
        }
    }
}
