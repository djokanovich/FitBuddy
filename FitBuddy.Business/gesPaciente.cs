using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business
{
    public class gesPaciente
    {
        private readonly IPacienteDAL _pacienteDAL;

        public gesPaciente(IPacienteDAL pacienteDAL)
        {
            _pacienteDAL = pacienteDAL;
        }

        public Paciente CrearPaciente(Paciente paciente)
        {
            return _pacienteDAL.CrearPaciente(paciente);
        }

        public Paciente ObtenerPaciente(int usuarioId)
        {
            return _pacienteDAL.ObtenerPacientePorId(usuarioId);
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            _pacienteDAL.ActualizarPaciente(paciente);
        }
    }
}
