using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;
using System.Collections.Generic;
using System.Linq;

namespace FitBuddy.DataAccess.Repositorios
{
    public class ComidaRepositorio : RepositorioGenérico<Comida>
    {
        public ComidaRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
