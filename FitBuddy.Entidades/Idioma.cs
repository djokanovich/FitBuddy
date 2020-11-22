using System.ComponentModel.DataAnnotations.Schema;

namespace FitBuddy.Entidades
{
    [Table("Idiomas")]
    public class Idioma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Código { get; set; }
    }
}
