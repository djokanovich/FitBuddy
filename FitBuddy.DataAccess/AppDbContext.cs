using Common.Utilidades;
using FitBuddy.Entidades;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;

namespace FitBuddy.DataAccess
{
    public class AppDbContext : DbContext
    {
        private readonly IMd5HashingService _md5HashingService;

        // Necesario para hacer Update-Database.
        public AppDbContext() : this(null)
        {
        }

        public AppDbContext(IMd5HashingService md5HashingService) : base("FitBuddyDbConnectionString")
        {
            _md5HashingService = md5HashingService;
        }

        public DbSet<Comida> Comidas { get; set; }
        public DbSet<ComposiciónAlimento> ComposiciónAlimentos { get; set; }
        public DbSet<Médico> Medicos { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Idioma> Idiomas { get; set; }

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
                    entidadConIntegridad.Md5Hash = _md5HashingService.CalcularHashDeEntidadBase(md5, entidadConIntegridad);
                }
            }

            return base.SaveChanges();
        }
    }
}
