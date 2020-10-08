using FitBuddy.Entidades.Interfaces;
using System.Text;

namespace FitBuddy.Entidades
{
    public enum Estado
    {
        Activo, Desactivado
    }

    public class Usuario : IVerificoIntegridad
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Estado Estado { get; set; }
        public int IdIdioma { get; set; }
        public int IntentosFallidos { get; set; }
        public int DVH { get; set; }

        public byte[] ConcatenarPropiedades()
        {
            // Jokanovich1714...
            var concat = string.Concat(new[] { Apellido, Estado.ToString(), IdIdioma.ToString(), Id.ToString(), IntentosFallidos.ToString(), Nombre, Password, Username });
            return Encoding.ASCII.GetBytes(concat);
        }
    }
}
