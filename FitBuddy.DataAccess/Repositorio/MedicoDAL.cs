using FitBuddy.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.DataAccess.Repositorio
{
   public class MedicoDAL
    {
        public IEnumerable<Medico> ObtenerMedicos()
        {
            using (var dbContext = new AppDbContext())
            {
                var medicos = dbContext.Medicos.ToList();
                return medicos;
            }
        }
    }
}
