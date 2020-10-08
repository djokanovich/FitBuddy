namespace FitBuddy.Entidades.Interfaces
{
    public interface IVerificoIntegridad
    {
        // es como un contrato
        int DVH { get; set; }

        byte[] ConcatenarPropiedades();
    }
}
