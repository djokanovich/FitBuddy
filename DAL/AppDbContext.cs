using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("FitBuddyDbConnectionString")
        {
        }

        public DbSet<BE.Usuario> Usuarios { get; set; }

        public DbSet<BE.Permiso> Permisos { get; set; }

        public DbSet<BE.Bitacora> Bitacora { get; set; }

        public DbSet<BE.Tabla> Tabla { get; set; }

        public DbSet<BE.Backup> Backup { get; set; }

        public DbSet<BE.Idioma> Idioma { get; set; }

        public DbSet<BE.Leyenda> Leyenda { get; set; }

        public DbSet<BE.Paciente> Paciente { get; set; }

        public DbSet<BE.PerfilPaciente> PerfilPaciente { get; set; }

        public DbSet<BE.Email> Emails { get; set; }

        public DbSet<BE.Domicilio> Domicilios { get; set; }

        public DbSet<BE.Dieta> Dietas { get; set; }
        public DbSet<BE.Comida> Comidas { get; set; }
        public DbSet<BE.PerfilDieta> PerfilDieta { get; set; }

        public DbSet<BE.PlanEjercicio> PlanEjercicios { get; set; }
        public DbSet<BE.Ejercicio> Ejercicios { get; set; }
        public DbSet<BE.PerfilFisico> PerfilFisico { get; set; }
        public DbSet<BE.Medico> Medicos { get; set; }
        public DbSet<BE.Reclamo> Reclamos { get; set; }

        public DbSet<BE.DiarioComidas> DiarioComidas { get; set; }

        public DbSet<BE.DiarioEjercicios> DiarioEjercicios { get; set; }

        public DbSet<BE.Turno> Turnos { get; set; }













    }
}
