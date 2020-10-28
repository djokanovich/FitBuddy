using FitBuddy.DataAccess.Services;
using FitBuddy.Entidades;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;

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
                    .Where(e => e.Entity is EntidadBase && // ...elijo las que implementan la interfaz IVerificoIntegridad...
                        (e.State == EntityState.Added || e.State == EntityState.Modified)) // ...y que estoy creando o modificando.
                    .Select(e => e.Entity as EntidadBase);

            using (var md5 = MD5.Create())
            {
                foreach (var entidadConIntegridad in entidadesConIntegridad)
                {
                    entidadConIntegridad.Md5Hash = Md5HashingService.CalcularHash(md5, entidadConIntegridad);
                }
            }

            return base.SaveChanges();
        }
    }
}
