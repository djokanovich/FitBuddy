namespace Common.Bitacora
{
    public interface IBitacora
    {
        void Debug(string mensaje);
        void Info(string mensaje);
        void Advertencia(string mensaje);
        void Error(string mensaje);
    }
}