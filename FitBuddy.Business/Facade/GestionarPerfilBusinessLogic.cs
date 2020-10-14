using FitBuddy.DataAccess.Repositorio;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IGestionarPerfilBusinessLogic
    {
        Usuario ObtenerUsuarioPorId(int usuarioId);
        int CrearPaciente(Paciente paciente);
        Paciente ObtenerPacientePorUsuarioId(int userId);
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

        public int CrearPaciente(Paciente paciente)
        {
            _pacienteRepositorio.CrearPaciente(paciente);
            return _pacienteRepositorio.GuardarCambios();
        }

        public Paciente ObtenerPacientePorUsuarioId(int userId)
        {
            return _pacienteRepositorio.ObtenerPacientePorUsuarioId(userId);
        }


    }
}
