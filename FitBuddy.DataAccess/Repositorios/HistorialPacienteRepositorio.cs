using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class HistorialPacienteRepositorio : RepositorioGenérico<HistorialPaciente>
    {
        public HistorialPacienteRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
