using System.Collections.Generic;
using System.Linq;
using FitBuddy.Business.Modelos;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICargarAlimentoBusinessLogic
    {
        IEnumerable<CargarAlimentoModelo> ObtenerAlimentosYCalorías();
    }

    public class CargarAlimentoBusinessLogic : ICargarAlimentoBusinessLogic
    {
        private readonly IRepositorio<ComposiciónAlimento> _composiciónAlimentoRepositorio;

        public CargarAlimentoBusinessLogic(IRepositorio<ComposiciónAlimento> composiciónAlimentoRepositorio)
        {
            _composiciónAlimentoRepositorio = composiciónAlimentoRepositorio;
        }

        public IEnumerable<CargarAlimentoModelo> ObtenerAlimentosYCalorías()
        {
            return _composiciónAlimentoRepositorio.Todos().Select(ca => new CargarAlimentoModelo { Comida = ca.Alimento, CaloríasCadaCienGramos = ca.Calorías });
        }
    }
}
