namespace FitBuddy.Entidades
{
    public enum Estado
    {
        Activo, Desactivado
    }

    public class Usuario : EntidadBase
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Estado Estado { get; set; }
        public int IdIdioma { get; set; }
        public int IntentosFallidos { get; set; }
    }
}
