using FitBuddy.Entidades.Enums;

namespace FitBuddy.Entidades
{
    public class Comida
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public TipoComida TipoComida { get; set; }
        public Objetivo Objetivo { get; set; }
        public Alimento Contiene { get; set; }
    }
}
