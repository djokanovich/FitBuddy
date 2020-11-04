using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FitBuddy.DataAccess.Repositorios.Genérico
{
    public abstract class RepositorioGenérico<T> : IRepositorio<T> where T : class
    {
        protected readonly AppDbContext _dbContext;

        public RepositorioGenérico(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T AgregarNuevo(T entidad)
        {
            return _dbContext.Set<T>().Add(entidad);
        }

        public virtual T ObtenerPorClavePrimaria(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual IEnumerable<T> Todos()
        {
            return _dbContext.Set<T>().AsEnumerable();
        }

        public virtual IEnumerable<T> BuscarPor(Expression<Func<T, bool>> predicado)
        {
            return _dbContext.Set<T>()
                .Where(predicado)
                .AsEnumerable();
        }

        public virtual T ActualizarExistente(T entidad)
        {
            _dbContext.Set<T>().Attach(entidad);
            _dbContext.Entry(entidad).State = System.Data.Entity.EntityState.Modified;
            return entidad;
        }

        public virtual T Eliminar(T entidad)
        {
            return _dbContext.Set<T>().Remove(entidad);
        }

        public virtual int GuardarCambios()
        {
            return _dbContext.SaveChanges();
        }
    }
}
