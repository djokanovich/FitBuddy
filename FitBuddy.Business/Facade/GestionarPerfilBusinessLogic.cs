using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IGestionarPerfilBusinessLogic
    {
        int CrearPacienteAsociadoAUsuario(int usuarioId, Paciente paciente);
        Paciente ObtenerPacienteAsociadoAUsuario(int userId);
    }

    public class GestionarPerfilBusinessLogic : IGestionarPerfilBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public GestionarPerfilBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public int CrearPacienteAsociadoAUsuario(int usuarioId, Paciente paciente)
        {
            paciente.UsuarioId = usuarioId;
            _pacienteRepositorio.AgregarNuevo(paciente);
            return _pacienteRepositorio.GuardarCambios();
        }

        public Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId)
        {
            return _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
        }
    }
}
