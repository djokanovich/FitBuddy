using System.Collections.Generic;
using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICargarAlimentoBusinessLogic
    {
        IEnumerable<string> ObtenerAlimentos();
    }

    public class CargarAlimentoBusinessLogic : ICargarAlimentoBusinessLogic
    {
        private readonly IRepositorio<ComposiciónAlimento> _composiciónAlimentoRepositorio;

        public CargarAlimentoBusinessLogic(IRepositorio<ComposiciónAlimento> composiciónAlimentoRepositorio)
        {
            _composiciónAlimentoRepositorio = composiciónAlimentoRepositorio;
        }

        public IEnumerable<string> ObtenerAlimentos()
        {
            return _composiciónAlimentoRepositorio.Todos().Select(ca => ca.Alimento);
        }
    }
}
