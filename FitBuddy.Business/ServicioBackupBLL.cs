using FitBuddy.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business
{
    public class ServicioBackupBLL
    {
        public int CrearBackup(string path)
        {
            var servicioBackup = new ServicioBackup();
            return servicioBackup.CrearBackup(path);
        }
    }
}
