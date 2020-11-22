using FitBuddy.Entidades;
using FitBuddy.Entidades.Enums;

namespace FitBuddy.DataAccess.Migrations.SeedData
{
    internal static class ComidaSeedData
    {
        public static Comida[] GetSeedData()
        {
            return new Comida[]
            {
                new Comida
                {
                    Id = 1,
                    Descripción = "Tostadas con queso crema y mermelada + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Lácteos | Alimento.Queso | Alimento.Tacc
                },
                new Comida
                {
                    Id = 2,
                    Descripción = "Galletas de arroz con mermelada + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.None
                },
                new Comida
                {
                    Id = 3,
                    Descripción = "Pancake de avena con miel y banana + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Huevo
                },
                new Comida
                {
                    Id = 4,
                    Descripción = "Yogurt griego con frutas + infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Lácteos | Alimento.Fructuosa
                },
                new Comida
                {
                    Id = 5,
                    Descripción = "Yogurt griego + Sandwich de Jamón + Infusión",
                    TipoComida = TipoComida.Desayuno | TipoComida.Merienda,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.CarneDeCerdo | Alimento.Lácteos | Alimento.Tacc
                },
                new Comida
                {
                    Id = 6,
                    Descripción = "Pollo a la española con papas",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.CarneDePollo | Alimento.Lácteos | Alimento.Huevo
                },
                new Comida
                {
                    Id = 7,
                    Descripción = "Omellette de champignones con puré de batata",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Huevo
                },
                new Comida
                {
                    Id = 8,
                    Descripción = "Milanesas de tofu con puré mixto",
                    TipoComida = TipoComida.Almuerzo | TipoComida.Cena,
                    Objetivo = Objetivo.AumentarPeso,
                    Contiene = Alimento.Tacc
                },
            };
        }
    }
}
