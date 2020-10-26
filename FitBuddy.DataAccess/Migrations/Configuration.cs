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
                    Contiene = Alimento.Lácteos | Alimento.Queso | Alimento.Tacc
                },
                new Comida
                {
                    Descripción = "Galletas de arroz con mermelada + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.None
                },
                new Comida
                {
                    Descripción = "Pancake de avena con miel y banana + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Huevo
                },
                new Comida
                {
                    Descripción = "Yogurt griego con frutas + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Lácteos | Alimento.Fructuosa
                },
                new Comida
                {
                    Descripción = "Yogurt griego + Sandwich de Jamón + Infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.CarneDeCerdo | Alimento.Lácteos | Alimento.Tacc
                },

                new Comida
                {
                    Descripción = "Pollo a la española con papas",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.CarneDePollo | Alimento.Lácteos | Alimento.Huevo
                },

                new Comida
                {
                    Descripción = "Omellette de champignones con puré de batata",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Huevo 
                },

                 new Comida
                {
                    Descripción = "Milanesas de tofu con puré mixto",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Tacc
                },

            };
            
            context.Comidas.AddOrUpdate(tablaComidas);
        }
    }
}
