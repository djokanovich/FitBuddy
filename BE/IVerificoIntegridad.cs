﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public interface IVerificoIntegridad
    {
        // es como un contrato
        int DVH { get; set; }

        byte[] ConcatenarPropiedades();
    }
}
