using BE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Bitacora : IVerificoIntegridad
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }

        public string Tipo { get; set; }
        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
        public int DVH { get; set; }

        public byte[] ConcatenarPropiedades()
        {
            var concat = string.Concat(new[] { Id.ToString(), IdUsuario.ToString(), Tipo, FechaHora.ToString(), Descripcion, });
            return Encoding.ASCII.GetBytes(concat);
        }
    } 
}
