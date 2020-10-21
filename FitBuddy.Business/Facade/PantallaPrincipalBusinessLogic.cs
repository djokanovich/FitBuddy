using FitBuddy.DataAccess.Repositorios;

namespace FitBuddy.Business.Facade
{
    public interface IPantallaPrincipalBusinessLogic
    {
        bool AlturaPesoEdadPacienteDefinidos(int usuarioId);
    }

    public class PantallaPrincipalBusinessLogic : IPantallaPrincipalBusinessLogic
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public PantallaPrincipalBusinessLogic(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public bool AlturaPesoEdadPacienteDefinidos(int usuarioId)
        {
            var paciente = _pacienteRepositorio.ObtenerPacientePorUsuarioId(usuarioId);
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
