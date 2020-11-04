using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICrearDietaBusinessLogic
    {
        Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId);
        bool CrearOActualizarPacienteAsociadoAUsuario(int usuarioId, Paciente paciente);
    }

    public class CrearDietaBusinessLogic : ICrearDietaBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public CrearDietaBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public Paciente ObtenerPacienteAsociadoAUsuario(int usuarioId)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            return pacienteAsociadoAUsuario;
        }

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
    }
}
