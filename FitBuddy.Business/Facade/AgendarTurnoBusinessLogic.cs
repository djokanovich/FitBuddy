using System.Collections.Generic;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IAgendarTurnoBusinessLogic
    {
        IEnumerable<Medico> ObtenerMedicos();
    }

    public class AgendarTurnoBusinessLogic : IAgendarTurnoBusinessLogic
    {
        private readonly IRepositorio<Medico> _medicoRepositorio;

        public AgendarTurnoBusinessLogic(IRepositorio<Medico> medicoRepositorio)
        {
            _medicoRepositorio = medicoRepositorio;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            return _medicoRepositorio.Todos();
        }
    }
}
