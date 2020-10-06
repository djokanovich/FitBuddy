using BE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public enum Estado 
    {
        Activo, Desactivado
    }

    public class Usuario : IVerificoIntegridad
    {

        public string Apellido { get; set; }
        public Estado Estado { get; set; }
        public int IdIdioma { get; set; }
        public int Id { get; set; }
        public int IntentosFallidos { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public int DVH { get; set; }
        



        public byte[] ConcatenarPropiedades()
        {
            // Jokanovich1714...
            var concat = string.Concat(new[] { Apellido, Estado.ToString(), IdIdioma.ToString(), Id.ToString(), IntentosFallidos.ToString(), Nombre, Password, Username });
            return Encoding.ASCII.GetBytes(concat);
        }


    }
}
