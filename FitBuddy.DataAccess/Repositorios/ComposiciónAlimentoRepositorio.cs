using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class ComposiciónAlimentoRepositorio : RepositorioGenérico<ComposiciónAlimento>
    {
        public ComposiciónAlimentoRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
