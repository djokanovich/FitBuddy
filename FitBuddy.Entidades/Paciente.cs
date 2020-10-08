using System;

namespace FitBuddy.Entidades
{
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
        public string Genero { get; set; }

        // Propiedades de navegación
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        // Perfil Dieta
        public bool Huevo { get; set; }
        public bool Tomate { get; set; }
        public bool Cerdo { get; set; }
        public bool Pollo { get; set; }
        public bool Vaca { get; set; }
        public bool Pescado { get; set; }
        public bool Mariscos { get; set; }
        public bool Leche { get; set; }
        public bool FrutosSecos { get; set; }
        public bool Queso { get; set; }
        public bool Tacc { get; set; }
        public bool Fructuosa { get; set; }
        public bool HojasVerdes { get; set; }
        public bool Soja { get; set; }
        public bool FrutasRojas { get; set; }

        // Perfil Físico

        public int DispDiaria { get; set; }
        public int DispSemanal { get; set; }
        public int IdPerfilFisico { get; set; }
        public bool ProblemasCardio { get; set; }
        public bool ProblemasResp { get; set; }
        public bool ProblemasTraumat { get; set; }

    }
}
