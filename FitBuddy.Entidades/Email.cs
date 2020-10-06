using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Entidades
{
   public class Email
    {
        public int Id { get; set; }
        public string CC { get; set; }
        public string Emisor { get; set; }
        public string Mensaje { get; set; }
    }
}
