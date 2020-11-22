using FitBuddy.Entidades;

namespace FitBuddy.DataAccess.Migrations.SeedData
{
    internal static class IdiomaSeedData
    {
        public static Idioma[] GetSeedData()
        {
            return new Idioma[]
            {
                new Idioma
                {
                    Id = 1,
                    Nombre = "Castellano Rioplatense",
                    Código = "es-AR"
                },
                new Idioma
                {
                    Id = 2,
                    Nombre = "American English",
                    Código = "en-US"
                },
            };
        }
    }
}
