using DAL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ServicioIntegridadBLL
    {
        public bool DbTieneIntegridad()
        {
            var servicioIntegridadDb = new ServicioIntegridadDb();
            return servicioIntegridadDb.DbTieneIntegridad();
        }
    }
}
