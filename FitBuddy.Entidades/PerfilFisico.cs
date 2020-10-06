using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class PerfilFisico
    {

        public int DispDiaria { get; set; }
        public int DispSemanal { get; set; }
        public int IdPerfilFisico { get; set; }
        public int Id { get; set; }
        public bool ProblemasCardio { get; set; }
        public bool ProblemasResp { get; set; }
        public bool ProblemasTraumat { get; set; }
    }
}
