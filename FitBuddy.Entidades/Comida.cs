using System;

namespace FitBuddy.Entidades
{
    [Flags]
    public enum TipoComida
    {
        Desayuno = 1 << 0 ,
        Almuerzo = 1 << 1,
        Merienda = 1 << 2,
        Cena = 1 << 3
    }

    public enum Objetivo
    {
        AumentarPeso,
        BajarPeso
    }

    [Flags]
    public enum TipoAlimento
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

    public  class Comida
    {
        public int Id { get; set; }
        public string Descripción { get; set; }
        public TipoComida TipoComida { get; set; }
        public Objetivo Objetivo { get; set; }
        public TipoAlimento TipoAlimento { get; set; }
    }
}
