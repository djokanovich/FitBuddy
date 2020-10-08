using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IPacienteFacade
    {
        Paciente ObtenerPacientePorUsuarioId(int usuarioId);
        Paciente CrearPaciente(Paciente paciente);
        Paciente ActualizarPaciente(int pacienteId);
        int GuardarCambios();
    }

    public class PacienteFacade : IPacienteFacade
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public PacienteFacade(IPacienteRepositorio pacienteDAL)
        {
            _pacienteRepositorio = pacienteDAL;
        }

        public Paciente ObtenerPacientePorUsuarioId(int usuarioId)
        {
            return _pacienteRepositorio.ObtenerPacientePorUsuarioId(usuarioId);
        }

        public Paciente CrearPaciente(Paciente paciente)
        {
            return _pacienteRepositorio.CrearPaciente(paciente);
        }

        public Paciente ActualizarPaciente(int pacienteId)
        {
            return _pacienteRepositorio.ActualizarPaciente(pacienteId);
        }

        public int GuardarCambios()
        {
            return _pacienteRepositorio.GuardarCambios();
        }
    }
}
