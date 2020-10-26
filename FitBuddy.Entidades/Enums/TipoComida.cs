using System;

namespace FitBuddy.Entidades.Enums
{
    [Flags]
    public enum TipoComida
    {
        Desayuno = 1 << 0,
        Almuerzo = 1 << 1,
        Merienda = 1 << 2,
        Cena = 1 << 3
    }
}
