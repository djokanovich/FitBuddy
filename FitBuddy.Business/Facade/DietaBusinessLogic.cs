using FitBuddy.DataAccess.Repositorios.Genérico;
using FitBuddy.Entidades;
using System;
using System.Linq;

namespace FitBuddy.Business.Facade
{
    public interface IDietaBusinessLogic
    {
        string ElegirAlimentoAlAzar(int usuarioId);
    }

    public class DietaBusinessLogic : IDietaBusinessLogic
    {
        private readonly IRepositorio<Paciente> _pacienteRepositorio;
        private readonly IRepositorio<Comida> _comidaRepositorio;

        public DietaBusinessLogic(IRepositorio<Paciente> pacienteRepositorio, IRepositorio<Comida> comidaRepositorio)
        {
            _pacienteRepositorio = pacienteRepositorio;
            _comidaRepositorio = comidaRepositorio;
        }

        public string ElegirAlimentoAlAzar(int usuarioId)
        {
            var pacienteAsociadoAUsuario = _pacienteRepositorio.BuscarPor(p => p.UsuarioId == usuarioId).SingleOrDefault();
            if (pacienteAsociadoAUsuario == null)
            {
                return string.Empty;
            }

            // Buscar las comidas que no contengan las alergias del paciente.
            var comidas = _comidaRepositorio.BuscarPor(comida => (pacienteAsociadoAUsuario.Alergias & comida.Contiene) == 0)
                .ToList();

            var indice = new Random().Next(comidas.Count);
            return comidas[indice].Descripción;
        }
    }
}
