using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorios
{
    public interface IComidaRepositorio
    {
        IEnumerable<Comida> ComidasCompatiblesConAlergia(Alimento alergia);
    }

    public class ComidaRepositorio : IComidaRepositorio
    {
        private readonly AppDbContext _dbContext;

        public ComidaRepositorio(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Comida> ComidasCompatiblesConAlergia(Alimento alergia)
        {
            return _dbContext.Comidas.Where(c => (c.Contiene & alergia) == 0);
        }
    }
}
