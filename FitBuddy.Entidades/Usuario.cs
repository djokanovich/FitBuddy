using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitBuddy.Entidades
{
    public enum Estado
    {
        Activo, Desactivado
    }

    [Table("Usuarios")]
    public class Usuario : EntidadBase
    {
        [Key, Column(Order = 1)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Estado Estado { get; set; }
        public int IdIdioma { get; set; }
        public int IntentosFallidos { get; set; }
    }
}
