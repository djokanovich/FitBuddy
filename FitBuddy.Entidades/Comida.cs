using System;

namespace FitBuddy.Entidades
{
    [Flags]
    public enum TipoComida
    {
        Desayuno = 1 << 0,
        Almuerzo = 1 << 1,
        Merienda = 1 << 2,
        Cena = 1 << 3
    }

    public enum Objetivo
    {
        AumentarPeso,
        BajarPeso
    }

    public class Comida
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public TipoComida TipoComida { get; set; }
        public Objetivo Objetivo { get; set; }
        public Alimento Contiene { get; set; }
    }
}
