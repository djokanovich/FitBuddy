using FitBuddy.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business
{
    public interface IServicioIntegridadBLL
    {
        bool DbTieneIntegridad();
    }

    public class ServicioIntegridadBLL : IServicioIntegridadBLL
    {
        public bool DbTieneIntegridad()
        {
            var servicioIntegridadDb = new ServicioIntegridadDb();
            return servicioIntegridadDb.DbTieneIntegridad();
        }
    }
}
