using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business
{
    public class gesMedico
    {
        public IEnumerable<Medico> ObtenerMedicos()
        {
            var medicoDAL = new MedicoDAL();
            return medicoDAL.ObtenerMedicos();
        }
    }
}
