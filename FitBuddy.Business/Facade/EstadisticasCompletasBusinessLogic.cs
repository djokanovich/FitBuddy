using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBuddy.Business.Facade
{
    public interface IEstadisticasCompletasBusinessLogic
    {
        IEnumerable<HistorialPeso> ObtenerHistorialPesos(int usuarioId);
    }

    public class EstadisticasCompletasBusinessLogic : IEstadisticasCompletasBusinessLogic
    {
        private readonly IRepositorio<Paciente> _repositorioPaciente;
        private readonly IRepositorio<HistorialPaciente> _repositorioHistorialPaciente;

        public EstadisticasCompletasBusinessLogic(IRepositorio<Paciente> repositorioPaciente, IRepositorio<HistorialPaciente> repositorioHistorialPaciente)
        {
            _repositorioPaciente = repositorioPaciente;
            _repositorioHistorialPaciente = repositorioHistorialPaciente;
        }

        public IEnumerable<HistorialPeso> ObtenerHistorialPesos(int usuarioId)
        {
            var resultado = new List<HistorialPeso>();

            var pacienteAsociadoAUsuario = _repositorioPaciente.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (pacienteAsociadoAUsuario == null)
            {
                return resultado;
            }

            var pacienteHistorial = _repositorioHistorialPaciente.BuscarPor(hp => hp.PacienteId == pacienteAsociadoAUsuario.Id)
                .Select(hp => new HistorialPeso { Fecha = hp.FechaRegistro, Peso = hp.PesoEnKg });

            return pacienteHistorial;
        }
    }
}
