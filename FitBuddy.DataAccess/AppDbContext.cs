using FitBuddy.DataAccess.Util;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FitBuddy.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("FitBuddyDbConnectionString")
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Permiso> Permisos { get; set; }

        public DbSet<Bitacora> Bitacora { get; set; }

        public DbSet<Tabla> Tabla { get; set; }

        public DbSet<Backup> Backup { get; set; }

        public DbSet<Idioma> Idioma { get; set; }

        public DbSet<Leyenda> Leyenda { get; set; }

        public DbSet<Paciente> Paciente { get; set; }

        public DbSet<Email> Emails { get; set; }

        public DbSet<Domicilio> Domicilios { get; set; }

        public DbSet<Dieta> Dietas { get; set; }

        public DbSet<Comida> Comidas { get; set; }

        public DbSet<PlanEjercicio> PlanEjercicios { get; set; }

        public DbSet<Ejercicio> Ejercicios { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Reclamo> Reclamos { get; set; }

        public DbSet<DiarioComidas> DiarioComidas { get; set; }

        public DbSet<DiarioEjercicios> DiarioEjercicios { get; set; }

        public DbSet<Turno> Turnos { get; set; }

        public override int SaveChanges() // se ejecuta cada vez que modifico o creo una fila en alguna tabla (record)
        {
            var entidadesConIntegridad =
                ChangeTracker.Entries() // De todas las entidades que le pedí a Entity Framework que maneje...
                    .Where(e => e.Entity is IVerificoIntegridad && // ...elijo las que implementan la interfaz IVerificoIntegridad...
                        (e.State == EntityState.Added || e.State == EntityState.Modified)) // ...y que estoy creando o modificando.
                    .Select(e => e.Entity as IVerificoIntegridad);

            foreach (var entidadConIntegridad in entidadesConIntegridad)
            {
                entidadConIntegridad.DVH = CodigoDeControl.Luhn(entidadConIntegridad.ConcatenarPropiedades());
            }

            return base.SaveChanges();
        }
    }
}
