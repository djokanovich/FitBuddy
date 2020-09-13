using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PerfilDieta
    {
        public int Id { get; set; }
        public bool AlergHuevo { get; set; }
        public bool AlergLacteos { get; set; }
        public bool AlergMariscos { get; set; }
        public bool AlergSecos { get; set; }
        public bool AlergTomates { get; set; }
        public bool Celiaco { get; set; }
        public bool Vegano { get; set; }
        public bool Vegetariano { get; set; }

    }
}
