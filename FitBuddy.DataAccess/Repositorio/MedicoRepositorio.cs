using FitBuddy.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorio
{
    public interface IMedicoRepositorio
    {
        IEnumerable<Medico> ObtenerMedicos();
    }

    public class MedicoRepositorio : IMedicoRepositorio
    {
        private readonly AppDbContext _dbContext;

        public MedicoRepositorio(AppDbContext dbContext)
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
