using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL.Repositorio;

namespace BLL
{
    public class gesPaciente
    {
        public int CrearPaciente(Paciente paciente)
        {
            PacienteDAL pacienteDAL = new PacienteDAL();
            pacienteDAL.CrearPaciente(paciente);

            return pacienteDAL.GuardarCambios();
        }
    }
}
