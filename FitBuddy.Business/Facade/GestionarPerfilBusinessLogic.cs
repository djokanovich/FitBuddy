using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IGestionarPerfilBusinessLogic
    {
        bool CrearOActualizarPacienteAsociadoAUsuario(int usuarioId, Paciente paciente);
        Paciente ObtenerPacienteAsociadoAUsuario(int userId);
    }

    public class GestionarPerfilBusinessLogic : IGestionarPerfilBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public GestionarPerfilBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        // TODO: Método duplicado en CrearDietaBusinessLogic
        public bool CrearOActualizarPacienteAsociadoAUsuario(int usuarioId, Paciente paciente)
        {
            if (paciente.Id == 0)
            {
                paciente.UsuarioId = usuarioId;
                _pacienteRepositorio.AgregarNuevo(paciente);
            }
            else
            {
                _pacienteRepositorio.ActualizarExistente(paciente);
            }

            return _pacienteRepositorio.GuardarCambios() > 0;
        }

        public Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId)
        {
            return _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
        }
    }
}
