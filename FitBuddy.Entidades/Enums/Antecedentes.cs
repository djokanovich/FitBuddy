using System;

namespace FitBuddy.Entidades.Enums
{
    [Flags]
    public enum Antecedentes
    {
        None = 0,
        InfartoCardiopatía = 1 << 0,
        EnfermedadRespiratoria = 1 << 1,
        ProblemasArticulatorios = 1 << 2,
        RoturaDeMeñiscosProblemaDeRodillas = 1 << 3,
        Escoliosis = 1 << 4,
        ArtrosisDolenciaCrónica = 1 << 5
    }
}
