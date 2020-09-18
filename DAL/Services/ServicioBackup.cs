using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Services
{
   public class ServicioBackup
    {
        public int CrearBackup(string path)
        {
            using (var dbContext = new AppDbContext())
            {
                return dbContext.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, $"BACKUP DATABASE [{dbContext.Database.Connection.Database}] TO DISK = '{path}'");
            }
        }

    }
}
