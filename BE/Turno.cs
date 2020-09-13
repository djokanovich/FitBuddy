using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
  public class Turno
    {
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public int Id { get; set; }
        public int IdPaciente { get; set; }
        public int IdMedico { get; set; }
    }
}
