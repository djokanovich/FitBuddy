using System;
using System.IO;

namespace Common.Bitacora
{
    public class Bitacora<T> : IBitacora<T>
    {
        private const NivelMensajeBitacora NivelMensajesBitacoraPorDefecto = NivelMensajeBitacora.Info;

        private readonly string _path;
        private readonly NivelMensajeBitacora _minimoNivelMensajesBitacora;

        public Bitacora(string path, string minimoNivelMensajesBitacora)
        {
            _path = path;

            if (!Enum.TryParse(minimoNivelMensajesBitacora, ignoreCase: true, out _minimoNivelMensajesBitacora))
            {
                _minimoNivelMensajesBitacora = NivelMensajesBitacoraPorDefecto;
            }
        }

        public void Debug(string mensaje)
        {
            Log(mensaje, NivelMensajeBitacora.Debug);
        }
        public void Info(string mensaje)
        {
            Log(mensaje, NivelMensajeBitacora.Info);
        }

        public void Advertencia(string mensaje)
        {
            Log(mensaje, NivelMensajeBitacora.Advertencia);
        }

        public void Error(string mensaje)
        {
            Log(mensaje, NivelMensajeBitacora.Error);
        }

        private void Log(string mensaje, NivelMensajeBitacora nivelMensaje)
        {
            if (nivelMensaje < _minimoNivelMensajesBitacora)
                return;

            using (var writer = File.AppendText(_path))
            {
                writer.WriteLine(FormatMessage(mensaje, nivelMensaje));
            }
        }

        private string FormatMessage(string mensaje, NivelMensajeBitacora logLevel)
        {
            var timeStamp = DateTime.Now;
            var logLevelString = logLevel.ToString().ToUpperInvariant();
            var usedInType = $"{typeof(T).Namespace}.{typeof(T).Name}";
            
            return $"{timeStamp:yyyy-MM-dd HH:mm:ss} [{logLevelString,-11}] {usedInType} : {mensaje}";
        }
    }
}
