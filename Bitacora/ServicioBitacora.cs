using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Bitacora
{
    public class ServicioBitacora
    {
        private readonly string _path;

        public ServicioBitacora(string path)
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
