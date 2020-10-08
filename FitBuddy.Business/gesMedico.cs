using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using System.Collections.Generic;

namespace FitBuddy.Business
{
    public class gesMedico
    {
        private readonly IMedicoDAL _medicoDAL;

        public gesMedico(IMedicoDAL medicoDAL)
        {
            _medicoDAL = medicoDAL;
        }

        public IEnumerable<Medico> ObtenerMedicos()
        {
            return _medicoDAL.ObtenerMedicos();
        }
    }
}
