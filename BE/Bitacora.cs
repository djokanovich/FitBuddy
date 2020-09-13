using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Bitacora
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }

        public string Tipo { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
    }
}
