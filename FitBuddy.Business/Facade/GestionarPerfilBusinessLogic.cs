using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IGestionarPerfilBusinessLogic
    {
        Paciente CrearPaciente(Paciente paciente);
        Usuario ObtenerUsuarioPorId(int usuarioId);
    }

    public class GestionarPerfilBusinessLogic : IGestionarPerfilBusinessLogic
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public GestionarPerfilBusinessLogic(IUsuarioRepositorio usuarioRepositorio, IPacienteRepositorio pacienteRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _pacienteRepositorio = pacienteRepositorio;
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            return _usuarioRepositorio.ObtenerUsuarioPorId(usuarioId);
        }

        public Paciente CrearPaciente(Paciente paciente)
        {
            return _pacienteRepositorio.CrearPaciente(paciente);
        }
    }
}
