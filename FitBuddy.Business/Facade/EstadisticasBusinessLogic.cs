using FitBuddy.DataAccess.Repositorio;
using System;

namespace FitBuddy.Business.Facade
{
    public interface IEstadisticasBusinessLogic
    {
        (string imc, string igc) CalcularIndices(int id);
    }

    public class EstadisticasBusinessLogic : IEstadisticasBusinessLogic
    {
        private readonly IPacienteRepositorio _pacienteRepositorio;

        public EstadisticasBusinessLogic(IPacienteRepositorio pacienteRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
        }

        public (string imc, string igc) CalcularIndices(int id)
        {
            var paciente = _pacienteRepositorio.ObtenerPacientePorUsuarioId(id);
            var peso = paciente.Peso;
            var altura = paciente.Altura;

            var imc = peso / Math.Pow(altura, 2);

            // Fórmula de Deurenberg
            // Para una mujer: IMG = (1, 2 × IMC) +(0, 23 × edad) -5,4
            // Para un hombre: IMG = (1, 2 × IMC) +(0, 23 × edad) -16,2

            var edad = paciente.Edad;

            var offset = paciente.Genero == "F" ? 5.4 : 16.2; //operador ternario

            var igc = (1.2 * imc) + (0.23 * edad) - offset;

            return (imc.ToString(), igc.ToString());
        }
    }
}
