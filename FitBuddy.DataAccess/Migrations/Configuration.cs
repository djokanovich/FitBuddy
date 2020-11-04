using System.Data.Entity.Migrations;
using FitBuddy.DataAccess.Migrations.SeedData;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<FitBuddy.DataAccess.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        // Este método se llama luego haber migrado la base de datos a la última versión.
        // Usar DbSet<T>.AddOrUpdate(), que asegura que no se van a duplicar datos.
        protected override void Seed(FitBuddy.DataAccess.AppDbContext context)
        {
            var comidasSeedData = ComidaSeedData.GetSeedData();
            context.Comidas.AddOrUpdate(comidasSeedData);
            
            var composicionAlimentosSeedData = ComposicionAlimentoSeedData.GetSeedData();
            context.ComposiciónAlimentos.AddOrUpdate(composicionAlimentosSeedData);
        }
    }
}
