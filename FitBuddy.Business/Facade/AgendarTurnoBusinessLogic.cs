using System.Collections.Generic;
using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IAgendarTurnoBusinessLogic
    {
        List<Médico> ObtenerMédicos();
    }

    public class AgendarTurnoBusinessLogic : IAgendarTurnoBusinessLogic
    {
        private readonly IRepositorio<Médico> _médicoRepositorio;

        public AgendarTurnoBusinessLogic(IRepositorio<Médico> médicoRepositorio)
        {
            _médicoRepositorio = médicoRepositorio;
        }

        public List<Médico> ObtenerMédicos()
        {
            return _médicoRepositorio.Todos().ToList();
        }
    }
}
