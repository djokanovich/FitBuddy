using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class MédicoRepositorio : RepositorioGenérico<Médico>
    {
        public MédicoRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
