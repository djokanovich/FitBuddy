using FitBuddy.DataAccess.Util;
using FitBuddy.Entidades;
using FitBuddy.Entidades.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace FitBuddy.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("FitBuddyDbConnectionString")
        {
        }

        public DbSet<Comida> Comidas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

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
