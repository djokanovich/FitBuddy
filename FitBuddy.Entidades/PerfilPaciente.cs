using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PerfilPaciente
    {
        public int Id { get; set; }
        public int Altura { get; set; }
        public int ContBrazo { get; set; }
        public int ContCadera { get; set; }
        public int ContCintura { get; set; }
        public int ContMuslo { get; set; }
        public int Objetivo { get; set; }
        public int Peso { get; set; }
    }
}
