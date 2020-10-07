using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business
{
    public class gesPaciente
    {
        public int CrearPaciente(Paciente paciente)
        {
            var pacienteDAL = new PacienteDAL();
            return pacienteDAL.CrearPaciente(paciente);
        }

        public Paciente ObtenerPaciente(int idUsuario)
        {
            var pacienteDAL = new PacienteDAL();
            return pacienteDAL.ObtenerPaciente(idUsuario);
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            var pacienteDAL = new PacienteDAL();
            pacienteDAL.ActualizarPaciente(paciente);
        }
    }
}
