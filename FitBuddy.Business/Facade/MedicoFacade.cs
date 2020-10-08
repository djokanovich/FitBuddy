using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using System.Collections.Generic;

namespace FitBuddy.Business.Facade
{
    public interface IMedicoFacade
    {
        IEnumerable<Medico> ObtenerMedicos();
    }

    public class MedicoFacade : IMedicoFacade
    {
        private readonly IMedicoRepositorio _medicoDAL;

        public MedicoFacade(IMedicoRepositorio medicoDAL)
        {
            _medicoDAL = medicoDAL;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            return _medicoDAL.ObtenerMedicos();
        }
    }
}
