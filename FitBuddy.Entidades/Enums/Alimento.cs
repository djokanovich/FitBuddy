using System;

namespace FitBuddy.Entidades.Enums
{
    [Flags]
    public enum Alimento
    {
        None = 0,
        Huevo = 1 << 0,
        Tomate = 1 << 1,
        CarneDeVaca = 1 << 2,
        CarneDeCerdo = 1 << 3,
        CarneDePollo = 1 << 4,
        Pescado = 1 << 5,
        Mariscos = 1 << 6,
        Lácteos = 1 << 7,
        FrutosSecos = 1 << 8,
        Queso = 1 << 9,
        Tacc = 1 << 10, // Trigo, Avena, Cebada, y Centeno
        Fructuosa = 1 << 11,
        HojasVerdes = 1 << 12,
        FrutosRojos = 1 << 13,
        Soja = 1 << 14
    }
}
