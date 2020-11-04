using System.ComponentModel.DataAnnotations.Schema;

namespace FitBuddy.Entidades
{
    [Table("Médicos")]
    public class Médico
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string DirecciónConsultorio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Teléfono { get; set; }
    }
}
