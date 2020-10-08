using FitBuddy.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IMedicoDAL
    {
        IEnumerable<Medico> ObtenerMedicos();
    }

    public class MedicoDAL : IMedicoDAL
    {
        private readonly AppDbContext _dbContext;

        public MedicoDAL(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            var medicos = _dbContext.Medicos.ToList();
            return medicos;
        }
    }
}
