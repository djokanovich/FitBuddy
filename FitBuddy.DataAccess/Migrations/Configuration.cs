using System.Data.Entity.Migrations;
using FitBuddy.Entidades;

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
            var tablaComidas = new Comida[]
            {
                new Comida
                {
                    Descripción = "Tostadas con queso crema y mermelada + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    TipoAlimento = TipoAlimento.Lácteos | TipoAlimento.Queso | TipoAlimento.Tacc
                },
                new Comida
                {
                    Descripción = "Galletas de arroz con mermelada + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    TipoAlimento = TipoAlimento.None
                },
                new Comida
                {
                    Descripción = "Pancake de avena con miel y banana + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    TipoAlimento = TipoAlimento.Huevo
                },
                new Comida
                {
                    Descripción = "Yougurt griego con frutas + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    TipoAlimento = TipoAlimento.Lácteos | TipoAlimento.Fructuosa
                },
                new Comida
                {
                    Descripción = "Yougurt griego + Sandwich de Jamón + Infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    TipoAlimento = TipoAlimento.CarneDeCerdo | TipoAlimento.Lácteos | TipoAlimento.Tacc
                },
            };
            
            context.Comidas.AddOrUpdate(tablaComidas);
        }
    }
}
