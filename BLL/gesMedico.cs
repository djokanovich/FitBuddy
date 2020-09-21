using BE;
using DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
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
