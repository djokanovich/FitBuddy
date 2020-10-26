using System;
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
    public class Paciente
    {
        // Perfil paciente
        public int Id { get; set; }
        public int Altura { get; set; }
        public int Edad { get; set; }
        public int ContornoBrazoEnCm { get; set; }
        public int ContornoCaderaEnCm { get; set; }
        public int ContornoCinturaEnCm { get; set; }
        public int ContornoMusloEnCm { get; set; }
        public int Objetivo { get; set; } // TODO: ¿Cuál es la función?
        public int Peso { get; set; } // TODO: ¿No debería ser float?
        public DateTime FechaRegistroPerfil { get; set; } // TODO: ¿Cuál es la función?
        public Genero Genero { get; set; }

        // Perfil Dieta
        public Alimento Alergias { get; set; }

        // Perfil Físico
        public Frecuencia FrecuenciaActual { get; set; }
        public DisponibilidadHoras DisposicionDiariaHoras { get; set; }
        public Frecuencia DisposicionSemanalDias { get; set; }
        public ObjetivoBuscado ObjetivoBuscado { get; set; }
        public Antecedentes Antecedentes { get; set; }

        // Propiedades de navegación
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
