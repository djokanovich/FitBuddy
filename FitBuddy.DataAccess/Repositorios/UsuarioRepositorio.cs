using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Repositorios
{
    public class UsuarioRepositorio : RepositorioGenérico<Usuario>
    {
        public UsuarioRepositorio(AppDbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Usuario> Todos()
        {
            return _dbContext.Usuarios
                .Include(u => u.Idioma)
                .AsEnumerable();
        }

        public override IEnumerable<Usuario> BuscarPor(Expression<Func<Usuario, bool>> predicado)
        {
            return _dbContext.Usuarios
                .Include(u => u.Idioma)
                .Where(predicado)
                .AsEnumerable();
        }
    }
}
