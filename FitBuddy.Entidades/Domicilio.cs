using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Entidades
{
   public class Domicilio
    {
        public int Id { get; set; }
        public int Altura { get; set; }
        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodPostal { get; set; }
        public string Depto { get; set; }
        public string Indicaciones { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public int Piso { get; set; }

    }
}
