namespace Common.Bitacora
{
    public interface IBitacora<T>
    {
        void Debug(string mensaje);
        void Info(string mensaje);
        void Advertencia(string mensaje);
        void Error(string mensaje);
    }
}