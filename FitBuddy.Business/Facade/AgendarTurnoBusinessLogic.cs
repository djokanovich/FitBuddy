using System.Collections.Generic;
using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IAgendarTurnoBusinessLogic
    {
        IEnumerable<Medico> ObtenerMedicos();
    }

    public class AgendarTurnoBusinessLogic : IAgendarTurnoBusinessLogic
    {
        private readonly IMedicoRepositorio _medicoRepositorio;

        public AgendarTurnoBusinessLogic(IMedicoRepositorio medicoRepositorio)
        {
            _medicoRepositorio = medicoRepositorio;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            return _medicoRepositorio.ObtenerMedicos();
        }
    }
}
