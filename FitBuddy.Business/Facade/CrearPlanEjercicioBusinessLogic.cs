using System.Linq;
using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;

namespace FitBuddy.Business.Facade
{
    public interface ICrearPlanEjercicioBusinessLogic
    {
        bool GuardarPlanEjercicio(int userid, Paciente paciente);
    }

    public class CrearPlanEjercicioBusinessLogic : ICrearPlanEjercicioBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;

        public CrearPlanEjercicioBusinessLogic(IRepositorio<Paciente> pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;

        }
        public bool GuardarPlanEjercicio(int usuarioId, Paciente paciente)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();

            if (pacienteAsociadoAUsuario == null)
            {
                paciente.UsuarioId = usuarioId;
                _pacienteRepositorio.AgregarNuevo(paciente);
            }
            else
            {
                pacienteAsociadoAUsuario.Antecedentes = paciente.Antecedentes;
                pacienteAsociadoAUsuario.DisposiciónDiariaHoras = paciente.DisposiciónDiariaHoras;
                pacienteAsociadoAUsuario.DisposiciónSemanalDias = paciente.DisposiciónSemanalDias;
                pacienteAsociadoAUsuario.FrecuenciaActual = paciente.FrecuenciaActual;
                pacienteAsociadoAUsuario.ObjetivoBuscado = paciente.ObjetivoBuscado;

                _pacienteRepositorio.ActualizarExistente(pacienteAsociadoAUsuario);
            }

            return _pacienteRepositorio.GuardarCambios() > 0;
        }
    }
}
