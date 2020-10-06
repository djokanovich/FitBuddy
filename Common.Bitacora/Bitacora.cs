using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common.Bitacora
{
    public class Bitacora : IBitacora
    {
        private readonly string _path;

        public Bitacora(string path)
        {
            _path = path;
        }

        public void Agregar(string mensaje)
        {
            using (var writer = File.AppendText(_path))
            {
                writer.WriteLine($"{DateTime.Now} {mensaje}");
            }
        }
    }
}
