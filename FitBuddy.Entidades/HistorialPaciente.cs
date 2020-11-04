using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitBuddy.Entidades
{
    public class HistorialPaciente
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaRegistro { get; set; }

        public int AlturaEnCm { get; set; }
        public float PesoEnKg { get; set; }

        public int ContornoBrazoEnCm { get; set; }
        public int ContornoCaderaEnCm { get; set; }
        public int ContornoCinturaEnCm { get; set; }
        public int ContornoMusloEnCm { get; set; }

        public int PacienteId { get; set; }
        public Paciente Paciente { get; set; }
    }
}
