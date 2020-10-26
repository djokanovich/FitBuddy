using System.Collections.Generic;
using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IAgendarTurnoBusinessLogic
    {
        List<Medico> ObtenerMedicos();
    }

    public class AgendarTurnoBusinessLogic : IAgendarTurnoBusinessLogic
    {
        private readonly IRepositorio<Medico> _medicoRepositorio;

        public AgendarTurnoBusinessLogic(IRepositorio<Medico> medicoRepositorio)
        {
            _medicoRepositorio = medicoRepositorio;
        }

        public List<Medico> ObtenerMedicos()
        {
            return _medicoRepositorio.Todos().ToList();
        }
    }
}
