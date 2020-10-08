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
        private readonly IMedicoDAL _medicoDAL;

        public MedicoFacade(IMedicoDAL medicoDAL)
        {
            _medicoDAL = medicoDAL;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            return _medicoDAL.ObtenerMedicos();
        }
    }
}
