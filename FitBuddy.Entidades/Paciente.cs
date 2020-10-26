using System;

namespace FitBuddy.Entidades
{
    public enum Genero
    {
        NoEspecificado, Masculino, Femenino
    }

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
        public int ContBrazo { get; set; }
        public int ContCadera { get; set; }
        public int ContCintura { get; set; }
        public int ContMuslo { get; set; }
        public int Objetivo { get; set; }
        public int Peso { get; set; }
        public DateTime FechaRegistroPerfil { get; set; }
        public Genero Genero { get; set; }

        // Propiedades de navegación
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Perfil Dieta
        public Alimento Alergias { get; set; }

        // Perfil Físico

        public Frecuencia FrecuenciaActual { get; set; }
        public DisponibilidadHoras DisposicionDiariaHoras { get; set; }
        public Frecuencia DisposicionSemanalDias { get; set; }
        public ObjetivoBuscado ObjetivoBuscado { get; set; }

        public bool ProblemasCardio { get; set; }
        public bool ProblemasResp { get; set; }

        public bool ProblemasArticulaciones { get; set; }

        public bool ProblemasEscoliosis { get; set; }

        public bool ProblemasMeñiscos { get; set; }

        public bool ProblemasArtrosis { get; set; }


    }
}
