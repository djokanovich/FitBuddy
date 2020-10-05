using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
   public class Paciente
    {
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

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

        // Perfil Dieta
        public bool AlergHuevo { get; set; }
        public bool AlergLacteos { get; set; }
        public bool AlergMariscos { get; set; }
        public bool AlergSecos { get; set; }
        public bool AlergTomates { get; set; }
        public bool Celiaco { get; set; }
        public bool Vegano { get; set; }
        public bool Vegetariano { get; set; }

        // Perfil Físico

        public int DispDiaria { get; set; }
        public int DispSemanal { get; set; }
        public int IdPerfilFisico { get; set; }
        public bool ProblemasCardio { get; set; }
        public bool ProblemasResp { get; set; }
        public bool ProblemasTraumat { get; set; }

    }
}
