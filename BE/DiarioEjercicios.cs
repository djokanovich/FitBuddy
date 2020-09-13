using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class DiarioEjercicios
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int IdEjercicio { get; set; }
        public int Tiempo { get; set; }
    }
}
