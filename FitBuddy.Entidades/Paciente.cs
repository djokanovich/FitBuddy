using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using FitBuddy.Entidades.Enums;

namespace FitBuddy.Entidades
{
    public enum Frecuencia
    {
        Nunca, UnaVezPorSemana, DosVecesPorSemana, TresOMasVecesPorSemana
    }

    public enum DisponibilidadHoras
    {
        MenosUnaHora, EntreUnaYDosHoras, MasDeDosHoras
    }

    public enum ObjetivoBuscado
    {
        GanarPeso, PerderPeso, GanarMusculo, EstarSaludable
    }
    
    [Table("Pacientes")]
    public class Paciente
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }
        
        public int Edad => (int)(DateTime.Today - FechaNacimiento).TotalDays / 365;
        
        public Género Género { get; set; }
        
        // Perfil Dieta
        public Alimento Alergias { get; set; } = Alimento.None;

        // Perfil Físico
        public Frecuencia FrecuenciaActual { get; set; }
        public DisponibilidadHoras DisposiciónDiariaHoras { get; set; }
        public Frecuencia DisposiciónSemanalDias { get; set; }
        public ObjetivoBuscado ObjetivoBuscado { get; set; }
        public Antecedentes Antecedentes { get; set; }

        // Propiedades de navegación
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public List<HistorialPaciente> HistorialPaciente { get; set; } = new List<HistorialPaciente>();

        // TODO: Las entidades no deberían tener métodos. Considerar crear modelos en la BLL que sí contengan métodos.
        public HistorialPaciente ÚltimoRegistro()
        {
            if (HistorialPaciente == null || !HistorialPaciente.Any())
                return null;
            
            return HistorialPaciente.OrderByDescending(hp => hp.FechaRegistro).First();
        }
        
        public bool EsAlérgicoA(Alimento alimento)
        {
            return (Alergias & alimento) != 0;
        }

        public void AgregarAlergiaA(Alimento alimento)
        {
            Alergias |= alimento;
        }

        public void QuitarAlergiaA(Alimento alimento)
        {
            if (EsAlérgicoA(alimento))
            {
                Alergias -= alimento;
            }
        }
    }
}
