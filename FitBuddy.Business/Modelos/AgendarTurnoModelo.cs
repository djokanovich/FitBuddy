using System;

namespace FitBuddy.Business.Modelos
{
    public class AgendarTurnoModelo
    {
        public string NombrePaciente { get; set; }
        public string NombreMédico { get; set; }
        public string EmailMédico { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }

        public string SmtpClientHost { get; set; }
        public int SmtpClientPort { get; set; }
        public string NetworkCredentialsEmail { get; set; }
        public string NetworkCredentialsPassword { get; set; }

        public string Mensaje { get; set; }
    }
}
