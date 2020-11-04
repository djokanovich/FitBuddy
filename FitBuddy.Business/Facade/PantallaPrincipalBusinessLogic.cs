using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface IPantallaPrincipalBusinessLogic
    {
        bool PuedeMostrarEstadísticas(int usuarioId);
    }

    public class PantallaPrincipalBusinessLogic : IPantallaPrincipalBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public PantallaPrincipalBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public bool PuedeMostrarEstadísticas(int usuarioId)
        {
            var paciente = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (paciente == null || paciente.HistorialPaciente == null || !paciente.HistorialPaciente.Any())
                return false;

            var edad = paciente.Edad;

            var últimoRegistroDelPaciente = paciente.ÚltimoRegistro();
            var altura = últimoRegistroDelPaciente.AlturaEnCm;
            var peso = últimoRegistroDelPaciente.PesoEnKg;

            var puedeMostrarEstadísticas = edad > 0 &&
                altura > 0 &&
                peso > 0;

            return puedeMostrarEstadísticas;
        }
    }
}
