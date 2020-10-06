using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Entidades
{
   public class Dieta
    {
        public int Id { get; set; }
        public int MaxCalDia { get; set; }
        public int MinCalDia { get; set; }
        public string Tipo { get; set; }
    }
}
