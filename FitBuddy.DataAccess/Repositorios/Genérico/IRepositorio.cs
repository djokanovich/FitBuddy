using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FitBuddy.DataAccess.Repositorios.Genérico
{
    public interface IRepositorio<T> where T : class
    {
        T AgregarNuevo(T entidad);
        T ActualizarExistente(T entidad);
        T ObtenerPorClavePrimaria(int id);
        IEnumerable<T> Todos();
        IEnumerable<T> BuscarPor(Expression<Func<T, bool>> predicado);
        T Eliminar(T entidad);
        int GuardarCambios();
    }
}
