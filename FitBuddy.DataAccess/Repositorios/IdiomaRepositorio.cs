using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class IdiomaRepositorio : RepositorioGenérico<Idioma>
    {
        public IdiomaRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
