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
            if (paciente == null)
                return false;
            
            var altura = paciente.Altura;
            var peso = paciente.Peso;
            var edad = paciente.Edad;

            var puedeMostrarEstadísticas = altura > 0 &&
                peso > 0 &&
                edad > 0;

            return puedeMostrarEstadísticas;
        }
    }
}
