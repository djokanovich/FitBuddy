using BE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public  class Comida : IVerificoIntegridad
    {
        public int Id { get; set; }
        public int Calorias { get; set; }
        public string Nombre { get; set; }
        public int Porcion { get; set; }
        public int DVH { get; set; }

        public byte[] ConcatenarPropiedades()
        {
            var concat = string.Concat(new[] { Id.ToString(), Calorias.ToString(), Nombre, Porcion.ToString() });
            return Encoding.ASCII.GetBytes(concat);
        }
    }
}
